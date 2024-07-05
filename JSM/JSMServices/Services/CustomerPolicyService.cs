using System.Security.Claims;
using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.CustomerPolicyViewModel;

namespace JSMServices.Services;

public class CustomerPolicyService : ICustomerPolicyService
{
    private readonly CustomerPolicyRepository _customerPolicyRepository;
    private readonly IMapper _mapper;

    public CustomerPolicyService(CustomerPolicyRepository customerPolicyRepository, IMapper mapper)
    {
        _customerPolicyRepository = customerPolicyRepository;
        _mapper = mapper;
    }

    public async Task<ICollection<CustomerPolicy>> GetAllCustomerPolicies()
    {
        try
        {
            var listProduct = _customerPolicyRepository.GetAll();
            return listProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task UpdateInformationCustomerPolicy(UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId)
    {
        try
        {
            var customerPolicy = _customerPolicyRepository.GetAll()
                .FirstOrDefault(c => c.CPId == CPId);
            if (customerPolicy == null)
            {
                throw new Exception("Update not successfully! Reload Page again!");
            }
            else
            {
                if (customerPolicy.PublishingStatus == CustomerPolicy.PublishingStatuses.Denied)
                {
                    throw new Exception("CustomerPolicy does not existed or was deleted!");
                }
                else
                {
                    var customerPolicyUpdate = _mapper.Map(updateCustomerPolicyViewModel, customerPolicy);
                    await _customerPolicyRepository.UpdateWithAsync(customerPolicyUpdate);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task CreateRequestCustomerPolicy(CreateRequestCustomerPolicyViewModel viewModel)
    {
        throw new NotImplementedException();
    }

    public async Task ApproveCustomerPolicy(Guid customerPolicy, ClaimsIdentity user)
    {
        throw new NotImplementedException();
    }
}