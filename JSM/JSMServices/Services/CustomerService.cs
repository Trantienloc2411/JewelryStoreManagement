using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.CustomerViewModel;
#pragma warning disable
namespace JSMServices.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CustomerService(CustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<ICollection<Customer>> GetAllCustomers()
    {

        var getCustomerList = await _customerRepository.GetAllWithAsync();

        return getCustomerList.ToList();


    }

    public async Task<Customer> GetCustomer(Guid customerId)
    {
        try
        {
            var customerList = await _customerRepository.GetAllWithAsync();
            var customerFind = customerList.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            if (customerFind is null)
            {
                throw new Exception("This customer is not found");
            }
            else
            {
                return customerFind;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Customer> UpdateCustomer(Guid customerId, AddCustomerViewModel customerViewModel)
    {
        try
        {
            var customer = new Customer();
            var getListCustomer = _customerRepository.GetAll();
            var customerUpdate = getListCustomer.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            if (customerUpdate == null)
            {
                return null;
            }
            else
            {
                //Processing when enter existed information
                var updateUser = _mapper.Map(customerViewModel, customerUpdate);
                _customerRepository.Update(updateUser);
                await _customerRepository.SaveChangesAsync();
                return updateUser;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Customer> AddCustomer(AddCustomerViewModel customerViewModel)
    {
        try
        {
            var customer = new Customer();
            var checkEmailExisted =
                await _customerRepository.GetSingleWithAsync(c => c.Email.ToLower().Equals(customerViewModel.Email));
            var checkPhoneExisted =
                await _customerRepository.GetSingleWithAsync(c => c.Phone.ToLower().Equals(customerViewModel.Phone));
            if (checkEmailExisted != null)
            {
                customer.Email = "Email is already existed";
                return customer;
            }
            else if (checkPhoneExisted != null)
            {
                customer.Phone = "Phone is already existed";
                return customer;
            }
            else
            {
                var newCustomer = _mapper.Map(customerViewModel, customer);
                _customerRepository.Add(newCustomer);
                _customerRepository.SaveChanges();
                return newCustomer;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}