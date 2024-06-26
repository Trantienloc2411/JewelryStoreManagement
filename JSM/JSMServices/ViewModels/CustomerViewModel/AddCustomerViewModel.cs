using DataLayer.Entities;

namespace JSMServices.ViewModels.CustomerViewModel;

public class AddCustomerViewModel
{
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public Customer.CustomerGenders CustomerGender { get; set; }
}