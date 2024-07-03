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
                await _typePriceService.CreateNewTypePrice(createTypePriceViewModel);
                return Ok("Create successfully");
            }
        }

        [HttpPut]
        [Route("UpdateTypePrice")]
        public async Task<IActionResult> UpdateTypePriceInfomation(
            [FromBody] UpdateTypePriceViewModel updateTypePriceViewModel, int typeId)
        {
            await _typePriceService.UpdateTypePriceInfo(updateTypePriceViewModel, typeId);
            return Ok("Update Successfully");
        }

        [HttpGet]
        [Route("ViewTypePriceDetail")]
        public async Task<IActionResult> ViewTypePriceDetail(int typeId)
        {
            var listTypePrice = await _typePriceService.GetTypePriceById(typeId);
            var result = _mapper.Map<CreateTypePriceViewModel>(listTypePrice);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteTypePrice")]
        public async Task<IActionResult> DeleteTypePrice(int typeId)
        {
            await _typePriceService.DeleteTypePrice(typeId);
            return Ok("Remove successfully");
        }
    }
}
