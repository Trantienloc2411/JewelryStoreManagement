using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.CustomerViewModel;
using Microsoft.AspNetCore.Authorization;
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
     
    [Route("GetCustomerById/{customerId}")]
    public async Task<IActionResult> GetCustomerById(Guid customerId)
    {
        var customer = await _customerService.GetCustomer(customerId);
        return Ok(customer);
    }

    [HttpPost]
    [Route("AddCustomer")]
     
    public async Task<IActionResult> AddCustomer(AddCustomerViewModel viewModel)
    {
        if (viewModel.Name == null)
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Add failed! Name is null"
            });
        }
        else if (viewModel.Email == null)
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Add failed! Email is null" 
            });
            
        }
        else if(viewModel.Phone == null)
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Add failed! Phone is null" 
            });
        }
        else if (viewModel.Address == null)
        {
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Add failed! Address is null"
            });
        }
        else
        {
            var addCustomer = await _customerService.AddCustomer(viewModel);
            if (addCustomer.CustomerId == Guid.Empty)
            {
                if (addCustomer.Email != null)
                {
                    return BadRequest(new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "Add failed" + addCustomer.Email
                    });
                }
                else if (addCustomer.Phone != null)
                {
                    return BadRequest(new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "Add failed" + addCustomer.Phone
                    });
                }
                else if (addCustomer.Address != null)
                {
                    return BadRequest(new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "Add failed" + addCustomer.Address
                    });
                }
                else
                {
                    return BadRequest(new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "Add failed"
                    });
                }


            }
            else
            {
                return Ok(new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Add successfully"
                });
            }
        }
        
    }
    
    [HttpPut]
    [Route("UpdateCustomer")]
     
    public async Task<IActionResult> UpdateCustomer (Guid customerId,AddCustomerViewModel viewModel)
    {
        var updateCustomer = await _customerService.UpdateCustomer(customerId,viewModel);
        var customer = updateCustomer;
        if (customer.CustomerId.Equals(Guid.Empty))
        {
            if (customer.Email != null)
            {
                return BadRequest(new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Update failed! Due to: " + customer.Email.ToString()
                });
            }
            else if (customer.Phone != null)
            {
                return BadRequest(new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Update failed! Due to: " + customer.Phone.ToString()
                });
            }
            else
            {
                return BadRequest(new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Update failed! Due to: " + updateCustomer
                }); 
            }
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
    [HttpGet]
    [Route("GetCustomerByPhone/{phoneNumber}")]
     
    public async Task<IActionResult> GetCustomerByPhone(string phoneNumber)
    {
        try
        {
            var result = await _customerService.GetCustomerByPhone(phoneNumber);

            // Use null-conditional operator to safely check if result is null
            if (result?.Phone == null)
            {
                return NotFound($"Customer with phone number {phoneNumber} not found");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }


}