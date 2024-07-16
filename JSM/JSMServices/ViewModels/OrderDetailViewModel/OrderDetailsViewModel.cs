using JSMServices.ViewModels.ProductViewModel;
using static DataLayer.Entities.OrderDetail;

namespace JSMServices.ViewModels.OrderDetailViewModel
{
    public class OrderDetailsViewModel
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ManufactureCost { get; set; }
        public OrderDetailStatuses OrderDetailStatus { get; set; }

        public ProductByOrderDetailViewModel Products { get; set; }
    }
}
