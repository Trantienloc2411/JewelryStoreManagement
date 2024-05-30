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
        var result = _mapper.Map<ICollection<RegisterEmployeeViewModel>>(listUser);
        
        return Ok(result);
    }
    
}