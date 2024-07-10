using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.GiftViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("Gift")]
    public class GiftController : Controller
    {
        private readonly IGiftService _giftService;
        private readonly IMapper _mapper;

        public GiftController(IGiftService giftService, IMapper mapper)
        {
            _giftService = giftService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetAllGifts")]
        public async Task<IActionResult> GetAllGift()
        {
            var listGift = await _giftService.GetAllGifts();
            var result = _mapper.Map<ICollection<GiftViewModel>>(listGift);
            return Ok(result);
        }

        [HttpGet]
        [Route("ViewGiftDetail")]
        public async Task<IActionResult> ViewGiftDetail(Guid giftId)
        {
            var listGift = await _giftService.GetGiftDetailsByGiftId(giftId);
            var result = _mapper.Map<CreateGiftViewModel>(listGift);
            return Ok(result);
        }

        [HttpPost]
        [Route("CreateNewGift")]
        public async Task<IActionResult> CreateNewGift(CreateGiftViewModel viewModel)
        {
            var response = await _giftService.CreateGift(viewModel);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            else
            {
                return Ok("Create successfully");
            }
        }
    }
}
