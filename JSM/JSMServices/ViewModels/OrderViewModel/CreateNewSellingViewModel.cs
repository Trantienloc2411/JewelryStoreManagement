using JSMServices.ViewModels.OrderDetailViewModel;

namespace JSMServices.ViewModels.OrderViewModel
{
    public class CreateNewSellingViewModel
    {
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public double Discount { get; set; }
        public int AccumulatedPoint { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }

        public CreateOrderDetailViewModel OrderDetail { get; set; }

    }
}
