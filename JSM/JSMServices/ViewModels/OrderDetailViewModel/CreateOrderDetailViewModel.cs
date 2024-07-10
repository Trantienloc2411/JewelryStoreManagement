namespace JSMServices.ViewModels.OrderDetailViewModel
{
    public class CreateOrderDetailViewModel
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ManufactureCost { get; set; }
    }
}
