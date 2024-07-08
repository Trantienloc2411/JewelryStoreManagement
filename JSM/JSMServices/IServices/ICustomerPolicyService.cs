using System.Collections;
using System.Security.Claims;
using DataLayer.Entities;
using JSMServices.ViewModels.CustomerPolicyViewModel;

namespace JSMServices.IServices;

public interface ICustomerPolicyService
{
    public Task<ICollection<CustomerPolicy>> GetAllCustomerPolicies();
    public Task UpdateInformationCustomerPolicy(UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId);
    public Task<string> CreateRequestCustomerPolicy(CreateRequestCustomerPolicyViewModel viewModel);
    public Task<string> ApproveCustomerPolicy(Guid customerPolicy, ClaimsPrincipal user);
    public Task<string> DenyCustomerPolicy(Guid customerPolicy, ClaimsPrincipal user);

    public Task<ICollection<CustomerPolicy>> GetAllCustomerPolicyByCustomerId(Guid customerId);
}