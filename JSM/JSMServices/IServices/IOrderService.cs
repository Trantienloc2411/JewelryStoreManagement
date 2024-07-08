using System.Security.Claims;
using DataLayer.Entities;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;

namespace JSMServices.IServices;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAllOrders();
    Task<Order> CreateNewOrder(CreateOrderViewModel createOrderViewModel);
    public Task<Order> GetOrderByOrderId(string orderCode);
    Task<Order> CreateNewBuyBack(CreateNewBuyBackViewModel viewModel,ClaimsPrincipal claims);
}