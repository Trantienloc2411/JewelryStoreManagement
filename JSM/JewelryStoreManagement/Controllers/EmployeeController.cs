using AutoMapper;
using JewelryStoreManagement.ViewModels;
using JSMServices.IServices;
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
        if (_employeeService == null)
        {
            return BadRequest("The Employee Service is not initialized!");
        }
        else
        {
            await _employeeService.AddAccountEmployee(registerEmployeeViewModel);
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
    public async Task<IActionResult> UpdateStatusEmployeeAccount( Guid uid)
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