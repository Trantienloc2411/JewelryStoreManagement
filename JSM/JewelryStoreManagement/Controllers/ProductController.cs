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


    }
}
