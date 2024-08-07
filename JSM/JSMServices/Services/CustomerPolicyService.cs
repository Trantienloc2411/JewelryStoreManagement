using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using System.Security.Claims;

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
            var listCP = await _customerPolicyRepository.GetAllWithIncludeAsync(e => true, e => e.Customer);
            listCP = listCP.ToList();
            return listCP;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task<ApiResponse> UpdateInformationCustomerPolicy(UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId)
    {
        try
        {
            var customerPolicy = _customerPolicyRepository.GetAll()
                .FirstOrDefault(c => c.CPId == CPId);
            if (customerPolicy == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Update not successfully! Reload Page again!"
                };

            }
            else
            {
                if (customerPolicy.PublishingStatus == CustomerPolicy.PublishingStatuses.Denied)
                {
                    return new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = $"CustomerPolicy does not existed or was deleted!."
                    };

                }
                else
                {
                    var customerPolicyUpdate = _mapper.Map(updateCustomerPolicyViewModel, customerPolicy);
                    await _customerPolicyRepository.UpdateWithAsync(customerPolicyUpdate);
                    return new ApiResponse
                    {
                        IsSuccess = true,
                        Data = null,
                        Message = $"Update Successfully"
                    };
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ApiResponse> UpdatePolicyStatus(Guid CPId)
    {
        try
        {
            var customerPolicy = await _customerPolicyRepository.GetSingleWithAsync(c => c.CPId == CPId);

            if (customerPolicy == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "The CustomerPolicy does not exist or was deleted!"
                };
            }
            customerPolicy.PolicyStatus = customerPolicy.PolicyStatus switch
            {
                CustomerPolicy.PolicyStatuses.Active => CustomerPolicy.PolicyStatuses.Used,
                _ => throw new InvalidOperationException("Invalid policy status")
            };

            await _customerPolicyRepository.SaveChangesAsync();

            return new ApiResponse
            {
                IsSuccess = true,
                Data = null,
                Message = "Policy status updated successfully"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = $"An error occurred: {e.Message}"
            };
        }
    }

    public async Task<string> CreateRequestCustomerPolicy(CreateRequestCustomerPolicyViewModel viewModel)
    {
        try
        {
            var cp = new CustomerPolicy();
            if (viewModel.ValidFrom < DateTime.Today)
            {
                return "ValidFrom Date can not in the past";
            }
            else if (viewModel.ValidTo < viewModel.ValidFrom && viewModel.ValidTo < DateTime.Today)
            {

                return "End Date can not in the past";
            }
            else
            {
                cp = _mapper.Map(viewModel, cp);
                _customerPolicyRepository.Add(cp);
                await _customerPolicyRepository.SaveChangesAsync();
                return "";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }



    }

    public async Task<string> ApproveCustomerPolicy(Guid customerPolicy, ClaimsPrincipal user)
    {
        var existCp = await _customerPolicyRepository.GetSingleWithAsync(c => c.CPId == customerPolicy);
        if (existCp.Equals(null))
        {
            return "This customerPolicy is not existed";
        }
        else if (user.FindFirst("EmployeeId").Value.ToString() == null)
        {
            return "Not Authorize";
        }
        else
        {
            existCp.PublishingStatus = CustomerPolicy.PublishingStatuses.Approved;
            existCp.ApprovedBy = user.FindFirst("EmployeeName").Value.ToString();
            existCp.ApprovedDate = DateTime.Now;
            await _customerPolicyRepository.UpdateWithAsync(existCp);
            _customerPolicyRepository.SaveChanges();
            return "";
        }
    }

    public async Task<string> DenyCustomerPolicy(Guid customerPolicy, ClaimsPrincipal user)
    {
        var existCp = await _customerPolicyRepository.GetSingleWithAsync(c => c.CPId == customerPolicy);
        if (existCp.Equals(null))
        {
            return "This customerPolicy is not existed";
        }
        else if (user.FindFirst("EmployeeId").Value.ToString() == null)
        {
            return "Not Authorize";
        }
        else
        {
            existCp.PublishingStatus = CustomerPolicy.PublishingStatuses.Denied;
            existCp.ApprovedBy = user.FindFirst("EmployeeName").Value.ToString();
            existCp.ApprovedDate = DateTime.Now;
            await _customerPolicyRepository.UpdateWithAsync(existCp);
            _customerPolicyRepository.SaveChanges();
            return "";
        }
    }

    public async Task<ICollection<CustomerPolicy>> GetAllCustomerPolicyByCustomerId(Guid customerId)
    {
        try
        {
            var cp = await _customerPolicyRepository.GetAllWithAsync();
            var filtercp = cp.Where(c => c.CustomerId == customerId).ToList();
            if (!filtercp.Any())
            {
                throw new Exception("No CustomerPolicies found for the specified CustomerId.");
            }
            return filtercp;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}