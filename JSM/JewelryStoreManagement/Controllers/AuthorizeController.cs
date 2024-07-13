using DataLayer.Entities;
using JSMServices.IServices;
using JSMServices.ViewModels.AuthorizeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JewelryStoreManagement.Controllers
{
#pragma warning disable
    [Route("[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly IEmployeeService _employeeServices;
        private readonly IRefreshHandlerService _refreshHandler;

        //private readonly IRefreshHandler refresh;

        public AuthorizeController(IEmployeeService employeeServices, IRefreshHandlerService refreshHandler)
        {

            _employeeServices = employeeServices;
            _refreshHandler = refreshHandler;
        }
        #region GenerateToken
        /// <summary>
        /// Which will generating token accessible for employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [NonAction]
        private TokenViewModel GenerateToken(Employee employee, String? rt)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim("EmployeeId", employee.EmployeeId.ToString()),
                new Claim("EmployeeName", employee.Name),
                new Claim("Email", employee.Email),
                new Claim("Role", employee.RoleId.ToString()),
                new Claim("IsLogin", employee.IsLogin.ToString()),
                new Claim("CounterId", employee.CounterId.ToString()),
                new Claim("CounterName", employee.Counter.CounterName)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("c2VydmVwZXJmZWN0bHljaGVlc2VxdWlja2NvYWNoY29sbGVjdHNsb3Bld2lzZWNhbWU="));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claimPrincipal = new ClaimsIdentity(claims);
            var token = new JwtSecurityToken(
                issuer: "YourIssuer",
                audience: "YourAudience",
                claims: claimPrincipal.Claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            if (rt != null)
            {
                return new TokenViewModel()
                {
                    AccessTokenToken = accessToken,
                    RefreshToken = rt,
                    ExpiredAt = _refreshHandler.GetRefreshTokenByEmployeeId(employee.EmployeeId.ToString()).ExpireAt
                };
            }
            return new TokenViewModel()
            {
                AccessTokenToken = accessToken,
                RefreshToken = GenerateRefreshToken(employee),
                ExpiredAt = _refreshHandler.GetRefreshTokenByEmployeeId(employee.EmployeeId.ToString()).ExpireAt
            };
        }
        #endregion

        #region GenerateRefreshToken
        // Hàm tạo refresh token
        [NonAction]
        private string GenerateRefreshToken(Employee employee)
        {
            var randomnumber = new byte[32];
            using (var randomnumbergenerator = RandomNumberGenerator.Create())
            {
                randomnumbergenerator.GetBytes(randomnumber);
                string refreshToken = Convert.ToBase64String(randomnumber);
                var refreshTokenEntity = new RefreshToken
                {
                    EmployeeId = employee.EmployeeId,
                    TokenId = new Random().Next().ToString(),
                    RefreshTokenString = refreshToken,
                    ExpireAt = DateTime.Now.AddDays(7),
                    Statuses = ReStatuses.Enable
                };

                _refreshHandler.GenerateRefreshToken(refreshTokenEntity);
                return refreshToken;
            }
        }
        #endregion

        #region RefreshAccessToken
        [HttpPost("RefreshAccessToken")]
        public async Task<ActionResult> RefreshAccessToken(TokenViewModel token)
        {
            try
            {
                var jwtTokenHander = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("c2VydmVwZXJmZWN0bHljaGVlc2VxdWlja2NvYWNoY29sbGVjdHNsb3Bld2lzZWNhbWU=")),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,
                    ValidateLifetime = false
                };
                //ResetRefreshToken in DB if token is disabled or expired will Remove RT
                _refreshHandler.ResetRefreshToken();
                //check validate of Parameter
                var tokenVerification = jwtTokenHander.ValidateToken(token.AccessTokenToken, tokenValidationParameters, out _);
                if (tokenVerification == null)
                {
                    return Ok(new APIResponse
                    {
                        Success = false,
                        Message = "Invalid Param"
                    });
                }
                //check AccessToken expire?
                var epochTime = long.Parse(tokenVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
                DateTimeOffset dateTimeUtc = DateTimeOffset.FromUnixTimeSeconds(epochTime);
                DateTime dateTimeUtcConverted = dateTimeUtc.UtcDateTime;
                if (dateTimeUtcConverted > DateTime.UtcNow)
                {
                    return Ok(new APIResponse
                    {
                        Success = false,
                        Message = "AccessToken had not expired",
                        data = "Expire time: " + dateTimeUtcConverted.ToString()
                    });
                }
                //check RefreshToken exist in DB
                var storedToken = _refreshHandler.GetRefreshToken(token.RefreshToken);
                //check RefreshToken is revoked?
                if (storedToken.Statuses == ReStatuses.Disable)
                {
                    return Ok(new APIResponse
                    {
                        Success = false,
                        Message = "RefreshToken had been revoked"
                    });
                }
                var employee = _employeeServices.GetEmployeeById(storedToken.EmployeeId);
                var newAt = GenerateToken(employee, token.RefreshToken);

                return Ok(new APIResponse
                {
                    Success = true,
                    Message = "Refresh AT success fully",
                    data = newAt
                });
            }
            catch (Exception ex)
            {
                return Ok(new APIResponse
                {
                    Success = false,
                    Message = "Something go wrong"
                });
            }
        }
        #endregion

        #region Login
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var employee = await _employeeServices.GetEmployeeByEmail(email);

            if (employee == null)
            {
                return BadRequest(new APIResponse
                {
                    Success = false,
                    Message = "Invalid email or password",
                    data = null
                });
            }
            else
            {
                if (password == employee.Password)
                {
                    var rfTkexisted = _refreshHandler.GetRefreshTokenByEmployeeId(employee.EmployeeId.ToString());
                    if (rfTkexisted != null)
                    {
                        _refreshHandler.RemoveAllRefreshToken();
                    }
                    _refreshHandler.ResetRefreshToken();
                    var token = GenerateToken(employee, null);
                    return Ok(token);
                }
                else
                {
                    return BadRequest(new APIResponse
                    {
                        Success = false,
                        Message = "Status Code:401 Unauthorized | Invalid email or password",
                        data = null
                    });
                }
            }



        }
        #endregion

        #region Logout
        [HttpPost]
        [Route("Logout")]
        public IActionResult Logout()
        {
            try
            {
                string token = HttpContext.Request.Headers["Authorization"];
                token = token.Split(' ')[1];
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("c2VydmVwZXJmZWN0bHljaGVlc2VxdWlja2NvYWNoY29sbGVjdHNsb3Bld2lzZWNhbWU=")),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,
                    ValidateLifetime = false
                };
                var claimsPrincipal = tokenHandler.ValidateToken(token, tokenValidationParameters, out _);
                var employeeIdClaim = claimsPrincipal.FindFirst("EmployeeId");
                var refreshToken = _refreshHandler.GetRefreshTokenByEmployeeId(employeeIdClaim.Value);
                _refreshHandler.UpdateRefreshToken(refreshToken);
                _refreshHandler.ResetRefreshToken();
                if (HttpContext.Request.Headers.ContainsKey("Authorization"))
                {
                    HttpContext.Request.Headers.Remove("Authorization");
                }
                return Ok(new APIResponse
                {
                    Success = true,
                    Message = "Logout successfully!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse
                {
                    Success = false,
                    Message = "Something go wrong" + ex.Message
                });
            }
        }
        #endregion
    }
}
