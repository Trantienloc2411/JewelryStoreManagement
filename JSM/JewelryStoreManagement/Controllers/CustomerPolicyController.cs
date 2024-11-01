using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using Microsoft.AspNetCore.Authorization;
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
         
        public async Task<IActionResult> GetAllCustomerPolicies()
        {
            var listCP = await _customerPolicyService.GetAllCustomerPolicies();
            var result = _mapper.Map<ICollection<CustomerPolicyViewMode>>(listCP);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCustomerPolicyByCustomerId")]
         
        public async Task<IActionResult> GetOrderByCustomerId(Guid customerId)
        {
            var listOrder = await _customerPolicyService.GetAllCustomerPolicyByCustomerId(customerId);
            var result = _mapper.Map<ICollection<CustomerPolicyByCustomerId>>(listOrder);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateCustomerPolicy")]
         
        public async Task<IActionResult> UpdateInformationCustomerPolicy(
        [FromBody] UpdateCustomerPolicyViewModel updateCustomerPolicyViewModel, Guid CPId)
        {
            var result = await _customerPolicyService.UpdateInformationCustomerPolicy(updateCustomerPolicyViewModel, CPId);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePolicyStatus")]
         
        public async Task<IActionResult> UpdatePolicyStatus(Guid CPId)
        {
            var result = await _customerPolicyService.UpdatePolicyStatus(CPId);
            return Ok(result);
        }

        [HttpPost]
         
        [Route("CreateCustomerPolicy")]
        public async Task<IActionResult> CreateCustomerPolicy([FromBody] CreateRequestCustomerPolicyViewModel viewModel)
        {
            var result = await _customerPolicyService.CreateRequestCustomerPolicy(viewModel);
            if (result != "")
            {
                return BadRequest(result);
            }
            else
            {
                return Ok("Make request successfully");
            }
        }

        [HttpPut]
         
        [Route("ApproveCustomerPolicy")]
        public async Task<IActionResult> ApproveCustomerPolicy(Guid Cpid)
        {
            var claims = HttpContext.User;
            var result = await _customerPolicyService.ApproveCustomerPolicy(Cpid, claims);
            if (result != "")
            {
                return BadRequest(result);
            }
            else
            {
                return Ok("Approve Successfully");
            }
        }


        [HttpPut]
         
        [Route("DenyCustomerPolicy")]
        public async Task<IActionResult> DenyCustomerPolicy(Guid Cpid)
        {
            var claims = HttpContext.User;
            var result = await _customerPolicyService.DenyCustomerPolicy(Cpid, claims);
            if (result != "")
            {
                return BadRequest(result);
            }
            else
            {
                return Ok("Denied Successfully");
            }
        }
    }
}
