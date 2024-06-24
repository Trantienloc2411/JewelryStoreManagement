using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.PromotionViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;
[ApiController]
[Route("Promotion")]
public class PromotionController : Controller
{
    private readonly IPromotionService _promotionService;

    public PromotionController(IPromotionService promotionService)
    {
        _promotionService = promotionService;
    }

    [HttpPost]
    [Route("AddPromotion")]
    [Authorize]
    public Task<IActionResult> AddNewPromotion(CreatePromotionViewModel viewModel)
    {
        var p = _promotionService.AddNewPromotion(viewModel);

        if (p.Exception is { Message: not null })
        {
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = p.Exception.Message,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        }
        else
        {
            var successResponse = new ApiResponse
            {
                IsSuccess = true,
                Message = "Create Successfully",
                Data = null
            };

            return Task.FromResult<IActionResult>(Ok(successResponse));
        }
    }

    [HttpDelete]
    [Route("DeletePromotion/{promotionCode}")]
    public Task<IActionResult> DeletePromotion(string promotionCode)
    {
        var p = _promotionService.DeletePromotion(promotionCode);
        {
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = p.Exception?.Message,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        }
    }

    [HttpGet]
    [Route("GetAllPromotion")]
    public async Task<IActionResult> GetAllPromotions()
    {
        try
        {
            var promotionList = await _promotionService.GetAllPromotion();
            return Ok(promotionList);
        }
        catch (Exception ex)
        {
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = ex.Message,
                Data = null
            };

            return BadRequest(errorResponse);
        }
    }

    [HttpGet]
    [Route("GetPromotion/{promotionCode}")]
    public IActionResult GetPromotion(string promotionCode)
    {
        var promotion = _promotionService.GetSinglePromotion(promotionCode);
        return Ok(promotion);
    }





}