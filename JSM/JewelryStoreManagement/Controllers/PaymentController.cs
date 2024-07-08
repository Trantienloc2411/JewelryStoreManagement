using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.PaymentViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;
[ApiController]
[Route("Payment")]
public class PaymentController : Controller
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }
    
    [Authorize]
    [HttpPost]
    [Route("CreatePayment")]
    public async Task<IActionResult> CreatePaymentLink(PaymentRequestLinkViewModel body)
    {
        try
        {
            var url = await _paymentService.CreatePaymentLink(body);
            return Ok(url);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Something happen unexpectedly!"
            });
        }
    }
    
    
    [Authorize]
    [HttpGet]
    [Route("GetOrder/{orderId}")]
    public async Task<IActionResult> CreatePaymentLink(string orderId)
    {
        try
        {
            var result  = await _paymentService.GetOrderPayment(orderId);
            return Ok(result);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Something happen unexpectedly!"
            });
        }
    }
    
    
    [Authorize]
    [HttpGet]
    [Route("CancelOrder/{orderId}")]
    public async Task<IActionResult> CancelOrder(string orderId)
    {
        try
        {
            var result  = await _paymentService.CancelOrder(orderId);
            return Ok(result);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Something happen unexpectedly!"
            });
        }
    }
}