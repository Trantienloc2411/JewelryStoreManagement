using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.CustomerViewModel;

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
        try
        {
            var getCustomerList = await _customerRepository.GetAllWithAsync();
            if (getCustomerList.Count == 0)
            {
                throw new Exception("Empty");
            }
            else
            {
                return getCustomerList;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
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

    public async Task UpdateCustomer(Guid customerId, AddCustomerViewModel customerViewModel)
    {
        try
        {
            var customer = new Customer();
            var getListCustomer = await _customerRepository.GetAllWithAsync();
            var customerUpdate = getListCustomer.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            if (customerUpdate is null)
            {
                throw new Exception("This user not found");
            }
            else
            {
                var updateUser = _mapper.Map(customerViewModel, customer);
                _customerRepository.Update(updateUser);
                _customerRepository.SaveChanges();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task AddCustomer(AddCustomerViewModel customerViewModel)
    {
        try
        {
            
            var customer = new Customer();
            if (customerViewModel == null)
            {
                throw new Exception("The data is null");

            }
            else
            {
                var checkEmailExisted = await _customerRepository.GetSingleWithAsync(c => c.Email.ToLower().Equals(customerViewModel.Email));
                var checkPhoneExisted = await _customerRepository.GetSingleWithAsync(c => c.Phone.ToLower().Equals(customerViewModel.Phone));
                if (checkEmailExisted != null)
                {
                    throw new Exception("Email is already existed");
                }
                else if (checkPhoneExisted != null)
                {
                    throw new Exception("Phone is already existed");
                }
                else
                {
                    var newCustomer = _mapper.Map(customerViewModel, customer);
                    _customerRepository.Add(newCustomer);
                    _customerRepository.SaveChanges();
                }
            }
            
            
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}