using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("CustomerPolicy")]
    public class CustomerPolicyController : Controller
    {
        private readonly ICustomerPolicyService _customerPolicyService;
        private readonly IMapper _mapper;

        public CustomerPolicyController(ICustomerPolicyService customerPolicyService, IMapper mapper)
        {
            _customerPolicyService = customerPolicyService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllCustomerPolicies")]
        public async Task<IActionResult> GetAllProducts()
        {
            var listProduct = await _customerPolicyService.GetAllCustomerPolicies();
            var result = _mapper.Map<ICollection<CustomerPolicyViewMode>>(listProduct);

            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateCustomerPolicy")]
        public async Task<IActionResult> UpdateInformationCustomerPolicy(
        [FromBody] UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId)
        {
            await _customerPolicyService.UpdateInformationCustomerPolicy(updateCustomerPolicyViewModel, CPId);
            return Ok("Update Successfully");
        }
    }
}
