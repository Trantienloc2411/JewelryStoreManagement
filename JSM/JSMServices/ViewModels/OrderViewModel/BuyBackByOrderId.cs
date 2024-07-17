using DataLayer.Entities;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using JSMServices.ViewModels.OrderDetailViewModel;

namespace JSMServices.ViewModels.OrderViewModel;

public class BuyBackByOrderId
{
    public string OrderId { get; set; }
    public Guid CustomerId { get; set; }
    public Guid EmployeeId { get; set; }
    public DateTime OrderDate { get; set; }
    public double? Discount { get; set; }
    public Order.Types Type { get; set; }
    public string? PromotionCode { get; set; }
    public int? AccumulatedPoint { get; set; }
    public int CounterId { get; set; }
    public int PaymentId { get; set; }
    public Guid? CPId { get; set; }
    public Order.OrderStatuses OrderStatus { get; set; }
    public BuyBack? BuyBack { get; set; }
    public CustomerByOrderViewModel Customer { get; set; }
    public EmployeeByOrderViewModel Employee { get; set; }
}