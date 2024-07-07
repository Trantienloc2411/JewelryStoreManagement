using AutoMapper;
using JSMServices.IServices;
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
        [Route("GetAllOrders")]        [Authorize]
        public async Task<IActionResult> GetAllOrders()
        {
            var listOrder = await _orderService.GetAllOrders();
            var result = _mapper.Map<ICollection<OrderViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewOrder")]        [Authorize]
        public async Task<IActionResult> AddNewOrder(
            [FromBody] CreateOrderViewModel createOrderViewModel)
        {
            if (_orderService == null)
            {
                return BadRequest("The Order Service is not initialized!");
            }
            else
            {
                await _orderService.CreateNewOrder(createOrderViewModel);
                return Ok("Create successfully");
            }
        }
    }
}
