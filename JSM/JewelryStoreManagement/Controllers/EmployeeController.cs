using AutoMapper;
using JewelryStoreManagement.ViewModels;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
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
    [Route("AddNewEmployee")]
    public async Task<IActionResult> AddEmployee(RegisterEmployeeViewModel registerEmployeeViewModel)
    {
        var user = HttpContext.User;
        if (_employeeService == null)
        {
            return BadRequest("The Employee Service is not initialized!");
        }
        else
        {
            
            var employee = await _employeeService.AddAccountEmployee(registerEmployeeViewModel,user);
            if (employee.EmployeeId == null && employee.Email != null)
            {
                return BadRequest(new ApiResponse()
                {
                    IsSuccess = false,
                    Message = @"Email is already registered. Please use another email.",
                    Data = null
                });
            }
            else if (employee.EmployeeId == null && employee.Phone != null)
            {
                return BadRequest(new ApiResponse()
                {
                    IsSuccess = false,
                    Message = @"Phone number is already registered. Please use another phone number.",
                    Data = null
                });
            }
            return Ok("Create successfully");
            
        }
    }

    [HttpGet]
    [Route("GetAllEmployee")]
    public async Task<IActionResult> GetAllEmployee()
    {
        var listUser = await _employeeService.GetAllEmployee();
        var result = _mapper.Map<ICollection<ViewEmployeeListViewModel>>(listUser);

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdatePassword")]
    public async Task<IActionResult> UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword)
    {
        await _employeeService.UpdatePasswordEmployeeAccount(email, oldPassword, newPassword);
        return Ok("Update successfully");
    }

    [HttpPut]
    [Route("UpdateStatus")]
    public async Task<IActionResult> UpdateStatusEmployeeAccount(Guid uid)
    {
        await _employeeService.UpdateStatusEmployeeAccount(uid);
        return Ok("Update successfully");
    }

    [HttpDelete]
    [Route("DeleteEmployee")]
    public async Task<IActionResult> DeleteEmployeeAccount(Guid id)
    {
        await _employeeService.DeleteEmployeeAccount(id);
        return Ok("Remove successfully");
    }

    [HttpPut]
    [Route("UpdateEmployee")]
    public async Task<IActionResult> UpdateInformationEmployee(
        [FromBody] UpdateInformationViewModel updateInformationViewModel)
    {
        await _employeeService.UpdateInformationEmployee(updateInformationViewModel);
        return Ok("Update Successfully");
    }
}