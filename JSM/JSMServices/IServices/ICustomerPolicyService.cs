using System.Security.Claims;
using DataLayer.Entities;
using JSMServices.ViewModels.CustomerPolicyViewModel;

namespace JSMServices.IServices;

public interface ICustomerPolicyService
{
    public Task<ICollection<CustomerPolicy>> GetAllCustomerPolicies();

    public Task UpdateInformationCustomerPolicy(UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId);

    public Task CreateRequestCustomerPolicy(CreateRequestCustomerPolicyViewModel viewModel);

    public Task ApproveCustomerPolicy(Guid customerPolicy, ClaimsIdentity user);
}