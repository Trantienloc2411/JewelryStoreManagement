using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.EmployeeViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers
{
    [ApiController]
    [Route("Counter")]
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public CounterController(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllCounters")]
        [Authorize]
        public async Task<IActionResult> GetAllCounters()
        {
            var listCounter = await _counterService.GetAllCounters();
            var result = _mapper.Map<ICollection<CounterViewModel>>(listCounter);

            return Ok(result);
        }


        [HttpGet]
        [Route("ViewCounterDetail")]        [Authorize]
        public async Task<IActionResult> ViewCounterDetail(int counterId)
        {
            var listCounter = await _counterService.GetCounterById(counterId);
            var result = _mapper.Map<AddNewCounterViewModel>(listCounter);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewCounter")]        [Authorize]
        public async Task<IActionResult> AddNewCounter(AddNewCounterViewModel addNewCounterViewModel)
        {
            if (_counterService == null)
            {
                return BadRequest("The Counter Service is not initialized!");
            }
            else
            {
                var result = await _counterService.AddNewCounter(addNewCounterViewModel);
                return Ok(result);
            }
        }

        [HttpPut]
        [Route("AssignCounterToEmployee")]        [Authorize]
        public async Task<IActionResult> AssignCounterToEmployee(
            [FromBody] AssignCounterToViewModel assignCounterToViewModel, Guid employeeId)
        {
            var result = await _counterService.AssignCounterToEmployee(assignCounterToViewModel, employeeId);
            return Ok(result);
        }
    }
}
