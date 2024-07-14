using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.ProductViewModel;
using Microsoft.AspNetCore.Authorization;
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
        [Route("GetAllProducts")]        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {
            var listProduct = await _productService.GetAllProducts();
            var result = _mapper.Map<ICollection<ProductViewModel>>(listProduct);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductByBarcode")]        [Authorize]
        public async Task<IActionResult> GetProductByBarCode(string Barcode)
        {
            var listProduct = await _productService.GetProductByBarcode(Barcode);
            var result = _mapper.Map<ProductByBarcodeViewModel>(listProduct);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductByCounterId")]        [Authorize]
        public async Task<IActionResult> GetProductByCounterId(int counterId)
        {
            var listProduct = await _productService.GetProductByCounterId(counterId);
            var result = _mapper.Map<ICollection<ProductByCounterIdViewModel>>(listProduct);

            return Ok(result);
        }

        [HttpGet]
        [Route("ViewProductDetail")]        [Authorize]
        public async Task<IActionResult> GetProductById(Guid productId)
        {
            var listProduct = await _productService.GetProductById(productId);
            var result = _mapper.Map<ProductByBarcodeViewModel>(listProduct);

            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewProduct")]        [Authorize]
        public async Task<IActionResult> AddNewProduct(AddProductViewModel addProductViewModelmodel)
        {
            if (_productService == null)
            {
                return BadRequest("The Product Service is not initialized!");
            }
            else
            {
                var result = await _productService.AddNewProductAsync(addProductViewModelmodel);
                return Ok(result);
            }
        }

        [HttpDelete]
        [Route("DeleteProduct")]        [Authorize]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var result = await _productService.DeleteProduct(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateStatus")]        [Authorize]
        public async Task<IActionResult> UpdateStatusProduct(Guid uid)
        {
            var result = await _productService.UpdateStatusProduct(uid);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateProduct")]        [Authorize]
        public async Task<IActionResult> UpdateInformationProduct(
        [FromBody] UpdateProductViewModel updateProductViewModel, Guid productId)
        {
            var result = await _productService.UpdateInformationProduct(updateProductViewModel, productId);
            return Ok(result);
        }
    }
}
