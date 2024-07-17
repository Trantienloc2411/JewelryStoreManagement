using DataLayer.Entities;

namespace JSMServices.ViewModels.OrderViewModel
{
    public class OrderStatusCancelledViewModel
    {
        public string OrderId { get; set; }
        public Order Order { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
