using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.CustomerViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;
[ApiController]
[Route("Customer")]
public class CustomerController : Controller
{
    private readonly ICustomerService _customerService;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerService customerService, IMapper mapper)
    {
        _customerService = customerService;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("GetAllCustomers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        var listCustomer = await _customerService.GetAllCustomers();
        return Ok(listCustomer);
    }

    [HttpGet]
    [Route("GetCustomerById")]
    public async Task<IActionResult> GetCustomerById(Guid customerId)
    {
        var customer = await _customerService.GetCustomer(customerId);
        return Ok(customer);
    }

    [HttpPost]
    [Route("AddCustomer")]
    public async Task<IActionResult> AddCustomer(AddCustomerViewModel viewModel)
    {
        var addCustomer = _customerService.AddCustomer(viewModel);
        if (addCustomer.Exception.Message == null)
        {
            return Ok(new ApiResponse
            {
                IsSuccess = true,
                Data = null,
                Message = "Add successfully"
            });
        }
        else
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Add failed!" + addCustomer.Exception.Message
            });
        }
    }
    
    [HttpPut]
    [Route("UpdateCustomer")]
    public async Task<IActionResult> UpdateCustomer (Guid customerId,AddCustomerViewModel viewModel)
    {
        var updateCustomer = _customerService.UpdateCustomer(customerId,viewModel);
        if (updateCustomer.Exception.Message != null)
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Update failed! Due to: " + updateCustomer.Exception.InnerExceptions
            });
        }
        else
        {
            return Ok(new ApiResponse
            {
                IsSuccess = true,
                Data = null,
                Message = "Update successfully!"
            });
        }
    }
    

}