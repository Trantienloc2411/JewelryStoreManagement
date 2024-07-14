using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using static DataLayer.Entities.Order;

namespace JSMServices.ViewModels.OrderViewModel
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public Types Type { get; set; }
        public string PromotionCode { get; set; }
        public int AccumulatedPoint { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }

        public OrderStatuses OrderStatus { get; set; }

        public EmployeeNameViewModel Employee { get; set; }

        public CustomerNameViewModel Customer { get; set; }

        public CounterNameViewModel Counter { get; set; }
    }
}
