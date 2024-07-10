using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllOrders")]
        [Authorize]
        public async Task<IActionResult> GetAllOrders()
        {
            var listOrder = await _orderService.GetAllOrders();
            var result = _mapper.Map<ICollection<OrderViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewBuyBack")]
        [Authorize]
        public async Task<IActionResult> AddNewBuyBack([FromBody] CreateNewBuyBackViewModel viewModel)
        {
            var user = HttpContext.User;
            var order = await _orderService.CreateNewBuyBack(viewModel, user);
            if (order.OrderId == null)
            {
                return BadRequest("Create not successfully! Due to existed key");
            }
            else
            {
                return Ok("Create successfully");
            }
        }

        [HttpPost]
        [Route("AddNewSelling")]
        [Authorize]
        public async Task<IActionResult> AddNewSelling(CreateNewSellingViewModel viewModel)
        {
            var user = HttpContext.User;
            var order = await _orderService.CreateNewOrderSelling(viewModel, user);
            if (order.OrderId == null)
            {
                return BadRequest("Create not successfully! Due to existed key");
            }
            else
            {
                return Ok("Create successfully");
            }
        }
    }
}
