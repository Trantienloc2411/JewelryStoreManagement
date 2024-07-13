using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using System.Security.Claims;

namespace JSMServices.IServices;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAllOrders();
    public Task<Order> GetOrderByOrderId(string orderCode);
    public Task<ICollection<OrderOrderDetailByCounterIdViewModel>> GetOrderOrderDetailByCounterId(int counterId);

    Task<ApiResponse> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims);
    Task<Order> CreateNewBuyBack(CreateNewBuyBackViewModel viewModel, ClaimsPrincipal claims);
}