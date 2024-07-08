using DataLayer.Entities;
using JSMServices.ViewModels.CustomerViewModel;

namespace JSMServices.IServices;

public interface ICustomerService
{
    Task<ICollection<Customer>> GetAllCustomers();
    Task<Customer> GetCustomer(Guid customerId);
    Task<Customer> UpdateCustomer(Guid customerId, AddCustomerViewModel customerViewModel);
    Task<Customer> AddCustomer(AddCustomerViewModel customerViewModel);

    Task<Customer> GetCustomerByPhone(string phone);

}
