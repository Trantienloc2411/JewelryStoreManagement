using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using System.Security.Claims;

namespace JSMServices.IServices;

public interface IOrderService
{
    public Task<ICollection<OrderViewModel>> GetAllOrders();
    public Task<Order> GetOrderByOrderId(string orderCode);
    public Task<ICollection<OrderOrderDetailByCounterIdViewModel>> GetOrderOrderDetailByCounterId(int counterId);
    public Task<ICollection<Order>> GetOrderByCustomerId(Guid customerId);
    public Task<ICollection<Order>> GetOrderByEmployeeId(Guid employeeId);
    Task<ApiResponse> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims);
    Task<Order> CreateNewBuyBack(CreateNewBuyBackViewModel viewModel, ClaimsPrincipal claims);
}