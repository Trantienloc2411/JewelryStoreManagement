using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
#pragma warning disable
namespace JSMServices.Services;

public class RefreshHandlerService : IRefreshHandlerService
{
    private readonly RefreshHandlerRepository _refreshTokenRepository;
        public RefreshHandlerService(RefreshHandlerRepository refreshTokenRepository)
        {
            _refreshTokenRepository = refreshTokenRepository;
        }

        public void GenerateRefreshToken(RefreshToken token)
        {
            _refreshTokenRepository.Add(token);
            _refreshTokenRepository.SaveChanges();
        }

        public RefreshToken GetRefreshToken(string refreshToken)
        {
            try
            {
                var _refreshToken = _refreshTokenRepository.Get(x => x.RefreshTokenString == refreshToken);
                return _refreshToken;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RefreshToken GetRefreshTokenByEmployeeId(string employeeId)
        {
            try
            {
                var _refreshToken = _refreshTokenRepository.Get(x => x.EmployeeId.ToString().Equals(employeeId));
                return _refreshToken;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveAllRefreshToken()
        {
            try {
                var _refreshTokenList = _refreshTokenRepository.GetAll();
                foreach (var item in _refreshTokenList)
                {
                    _refreshTokenRepository.Remove(item);
                }
                _refreshTokenRepository.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public void ResetRefreshToken()
        {
            try
            {
                var _refreshToken = (List<RefreshToken>)_refreshTokenRepository.GetAll();
                foreach (var item in _refreshToken)
                {
                    if (item.Statuses == ReStatuses.Disable || item.ExpireAt <= DateTime.Now)
                    {
                        _refreshTokenRepository.Remove(item);
                        _refreshTokenRepository.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRefreshToken(RefreshToken _refreshToken)
        {
            try { 
                _refreshToken.Statuses = ReStatuses.Disable;
                _refreshTokenRepository.Update(_refreshToken);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }