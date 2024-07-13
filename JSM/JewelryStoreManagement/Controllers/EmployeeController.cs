using AutoMapper;
using JewelryStoreManagement.ViewModels;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;
[ApiController]
[Route("Employee")]
public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;
    private readonly IMapper _mapper;

    public EmployeeController(IEmployeeService employeeService, IMapper mapper)
    {
        _employeeService = employeeService;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("AddNewEmployee")]        [Authorize]
    public async Task<IActionResult> AddEmployee(RegisterEmployeeViewModel registerEmployeeViewModel)
    {
        var user = HttpContext.User;
        if (_employeeService == null)
        {
            return BadRequest("The Employee Service is not initialized!");
        }
        else
        {

            var employee = await _employeeService.AddAccountEmployee(registerEmployeeViewModel, user);
            if (employee != "")
            {
                return BadRequest(new ApiResponse()
                {
                    IsSuccess = false,
                    Message = employee,
                    Data = null
                });
            }
            
            return Ok("Create successfully");

        }
    }

    [HttpGet]
    [Route("GetAllEmployee")]        [Authorize]
    public async Task<IActionResult> GetAllEmployee()
    {
        var listUser = await _employeeService.GetAllEmployee();
        var result = _mapper.Map<ICollection<ViewEmployeeListViewModel>>(listUser);

        return Ok(result);
    }

    [HttpGet]
    [Route("GetEmployeeByCounterId")]
    public async Task<IActionResult> GetEmployeeByCounterId(int counterId)
    {
        var listEmployee = await _employeeService.GetEmployeeByCounterId(counterId);
        var result = _mapper.Map<ICollection<ViewEmployeeByCounterId>>(listEmployee);
        return Ok(result);
    }

    [HttpPut]
    [Route("UpdatePassword")]        [Authorize]
    public async Task<IActionResult> UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword)
    {
        var account = await _employeeService.UpdatePasswordEmployeeAccount(email, oldPassword, newPassword);
        if (account.Password == "" || account.Password.Length == 0)
        {
            return BadRequest(new ApiResponse()
            {
                IsSuccess = false,
                Message = @"Old password is wrong.",
                Data = null
            });
        }
        return Ok("Update successfully");
    }

    [HttpPut]
    [Route("UpdateStatus")]        [Authorize]
    public async Task<IActionResult> UpdateStatusEmployeeAccount(Guid uid)
    {
        string result = await _employeeService.UpdateStatusEmployeeAccount(uid);
        if (result != "" || result.Length != 0)
        {
            return BadRequest(new ApiResponse()
            {
                IsSuccess = false,
                Message = $"{result}",
                Data = null
            });
        }
        return Ok("Update successfully");
    }

    [HttpDelete]
    [Route("DeleteEmployee")]        [Authorize]
    public async Task<IActionResult> DeleteEmployeeAccount(Guid id)
    {
        string result = await _employeeService.DeleteEmployeeAccount(id);
        if (result != "" || result.Length != 0)
        {
            return BadRequest(new ApiResponse()
            {
                IsSuccess = false,
                Message = $"{result}",
                Data = null
            });
        }
        else return Ok("Remove successfully");

    }

    [HttpPut]
    [Route("UpdateEmployee")]        [Authorize]
    public async Task<IActionResult> UpdateInformationEmployee(
        [FromBody] UpdateInformationViewModel updateInformationViewModel)
    {
        string result = await _employeeService.UpdateInformationEmployee(updateInformationViewModel);
        if (result != null || result.Length != 0)
        {
            return BadRequest(new ApiResponse()
            {
                IsSuccess = false,
                Message = $"{result}",
                Data = null
            });
        }
        return Ok("Update Successfully");
    }

    [HttpPost]
    [Authorize]
    [Route("ResetPassword/{employeeId}")]
    public async Task<IActionResult> ResetPasswordEmployee(Guid employeeId)
    {
        var user = HttpContext.User;
        string result = await _employeeService.ResetPasswordEmployee(employeeId, user);
        if (result != "")
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = result
            });
        }
        else
        {
            return Ok("Password Reset successfully");
        }
    }
}