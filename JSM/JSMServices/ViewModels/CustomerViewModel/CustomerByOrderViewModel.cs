using static DataLayer.Entities.Customer;

namespace JSMServices.ViewModels.CustomerViewModel
{
    public class CustomerByOrderViewModel
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int AccumulatedPoint { get; set; }
        public string? Email { get; set; }
        public CustomerGenders CustomerGender { get; set; }

    }
}
