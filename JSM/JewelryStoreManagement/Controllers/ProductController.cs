using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.ProductViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var listProduct = await _productService.GetAllProducts();
            var result = _mapper.Map<ICollection<ProductViewModel>>(listProduct);

            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewProduct")]
        public async Task<IActionResult> AddNewProduct(AddProductViewModel addProductViewModelmodel)
        {
            if (_productService == null)
            {
                return BadRequest("The Product Service is not initialized!");
            }
            else
            {
                await _productService.AddNewProductAsync(addProductViewModelmodel);
                return Ok("Create successfully");
            }
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _productService.DeleteProduct(id);
            return Ok("Remove successfully");
        }

        [HttpPut]
        [Route("UpdateStatus")]
        public async Task<IActionResult> UpdateStatusProduct(Guid uid)
        {
            await _productService.UpdateStatusProduct(uid);
            return Ok("Update successfully");
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateInformationProduct(
        [FromBody] UpdateProductViewModel updateProductViewModel)
        {
            await _productService.UpdateInformationProduct(updateProductViewModel);
            return Ok("Update Successfully");
        }
    }
}
