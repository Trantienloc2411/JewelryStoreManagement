using DataLayer.Entities;
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
        string errorMessage;
        
        if(viewModel.DiscountPercentage.Equals(0) && viewModel.FixedDiscountAmount.Equals(0))
        {
            errorMessage = "The discount percentage and fix discount is empty";
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = errorMessage,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        } else if (viewModel.EndDate  < DateTime.Today)
        {
            errorMessage = "The end of discount must not in the past";
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = errorMessage,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        } else if (viewModel.StartDate < DateTime.Today)
        {
            errorMessage = "The start of discount must not in the past";
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = errorMessage,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        }
        else if (viewModel.StartDate > viewModel.EndDate)
        {
            errorMessage = "The start of discount must not larger than end date";
            var errorResponse = new ApiResponse
            {
                IsSuccess = false,
                Message = errorMessage,
                Data = null
            };

            return Task.FromResult<IActionResult>(BadRequest(errorResponse));
        }
        else 
        {
            var promotion =  _promotionService.AddNewPromotion(viewModel).Result;
            if (promotion is null)
            {
                errorMessage = "This code is already used!";
                var errorResponse = new ApiResponse
                {
                    IsSuccess = false,
                    Message = errorMessage,
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