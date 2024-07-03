using DataLayer.Entities;
using JSMServices.ViewModels.OrderViewModel;

namespace JSMServices.IServices;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAllOrders();

    Task<Order> CreateNewOrder(CreateOrderViewModel createOrderViewModel);
}