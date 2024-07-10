using DataLayer.Entities;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using System.Security.Claims;

namespace JSMServices.IServices;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAllOrders();
    public Task<Order> GetOrderByOrderId(string orderCode);

    Task<Order> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims);
    Task<Order> CreateNewBuyBack(CreateNewBuyBackViewModel viewModel, ClaimsPrincipal claims);
}