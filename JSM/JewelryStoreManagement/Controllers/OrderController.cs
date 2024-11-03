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
         
        public async Task<IActionResult> GetAllOrders()
        {
            var listOrder = await _orderService.GetAllOrders();
            var result = _mapper.Map<ICollection<OrderViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetOrdersByOrderId")]
         
        public async Task<IActionResult> GetOrdersByOrderId(string orderId)
        {
            var (order, apiResponse) = await _orderService.GetOrdersByOrderId(orderId);
            if (!apiResponse.IsSuccess)
            {
                return BadRequest(apiResponse.Message);
            }
            else
            {
                var result = _mapper.Map<OrderByOrderIdViewModel>(order);
                return Ok(result);
            }
        }
        [HttpGet]
        [Route("GetOrderByCounterId")]

        public async Task<IActionResult> GetOrderByCounterId(int counterId)
        {
            var listOrder = await _orderService.GetOrderOrderDetailByCounterId(counterId);
            var result = _mapper.Map<ICollection<OrderOrderDetailByCounterIdViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetOrderByEmployeeId")]

        public async Task<IActionResult> GetOrderByEmployeeId(Guid employeeId)
        {
            var listOrder = await _orderService.GetOrderByEmployeeId(employeeId);
            var result = _mapper.Map<ICollection<OrderViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetOrderByCustomerId")]

        public async Task<IActionResult> GetOrderByCustomerId(Guid customerId)
        {
            var listOrder = await _orderService.GetOrderByCustomerId(customerId);
            var result = _mapper.Map<ICollection<OrderByCustomerIdViewModel>>(listOrder);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewBuyBack")]
         
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
         
        public async Task<IActionResult> AddNewSelling(CreateNewSellingViewModel viewModel)
        {
            var user = HttpContext.User;
            var response = await _orderService.CreateNewOrderSelling(viewModel, user);
            if (!response.IsSuccess)
            {
                return BadRequest(response.Message);
            }
            else
            {
                return Ok(new { message = "Create successfully" });

            }
        }

        [HttpPut]
        [Route("UpdateOrderStatus")]
         
        public async Task<IActionResult> UpdateOrderStatus(
        [FromBody] UpdateOrderStatusViewModel updateOrderStatusViewModel, string orderId)
        {
            var result = await _orderService.UpdateOrderStatus(updateOrderStatusViewModel, orderId);
            return Ok(result);
        }

        [HttpPut]
        [Route("UndoPointQuantity")]
         
        public async Task<IActionResult> UndoPointQuantity([FromQuery] string orderId)
        {
            var result = await _orderService.UndoPointQuantity(orderId);
            return Ok(result);
        }


        [HttpGet]
        [Route("GetBuyBackByOrderId")]
         
        public async Task<IActionResult> GetBuyBackOrderId(string orderId)
        {
            var order = await _orderService.GetBuyBackByOrderId(orderId);
            var result = _mapper.Map<BuyBackByOrderId>(order);
            return Ok(result);
        }




    }

    
}
