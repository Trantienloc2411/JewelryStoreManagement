using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.TypePriceViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("TypePrice")]
    public class TypePriceController : Controller
    {
        private readonly ITypePriceService _typePriceService;
        private readonly IMapper _mapper;

        public TypePriceController(ITypePriceService typePriceService, IMapper mapper)
        {
            _typePriceService = typePriceService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("CreateNewTypePrice")]
        public async Task<IActionResult> AddNewProduct(CreateTypePriceViewModel createTypePriceViewModel)
        {
            if (_typePriceService == null)
            {
                return BadRequest("The TypePrice Service is not initialized!");
            }
            else
            {
                var result = await _typePriceService.CreateNewTypePrice(createTypePriceViewModel);
                return Ok(result);
            }
        }

        [HttpPut]
        [Route("UpdateTypePrice")]
        public async Task<IActionResult> UpdateTypePriceInfomation(
            [FromBody] UpdateTypePriceViewModel updateTypePriceViewModel, int typeId)
        {
            var result = await _typePriceService.UpdateTypePriceInfo(updateTypePriceViewModel, typeId);
            return Ok(result);
        }

        [HttpGet]
        [Route("ViewTypePriceDetail")]
        public async Task<IActionResult> ViewTypePriceDetail(int typeId)
        {
            var listTypePrice = await _typePriceService.GetTypePriceById(typeId);
            var result = _mapper.Map<CreateTypePriceViewModel>(listTypePrice);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllTypePrice")]
        public async Task<IActionResult> GetAllTypePrice()
        {
            var listTypePrice = await _typePriceService.GetAllTypePrice()
                ;
            return Ok(listTypePrice);
        }

        [HttpDelete]
        [Route("DeleteTypePrice")]
        public async Task<IActionResult> DeleteTypePrice(int typeId)
        {
            var result = await _typePriceService.DeleteTypePrice(typeId);
            return Ok(result);
        }
    }
}
