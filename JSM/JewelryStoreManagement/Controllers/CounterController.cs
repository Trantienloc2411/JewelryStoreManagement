using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.EmployeeViewModel;
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
        [Route("ViewCounterDetail")]
        public async Task<IActionResult> ViewCounterDetail(int counterId)
        {
            var listCounter = await _counterService.GetCounterById(counterId);
            var result = _mapper.Map<AddNewCounterViewModel>(listCounter);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddNewCounter")]
        public async Task<IActionResult> AddNewCounter(AddNewCounterViewModel addNewCounterViewModel)
        {
            if (_counterService == null)
            {
                return BadRequest("The Counter Service is not initialized!");
            }
            else
            {
                await _counterService.AddNewCounter(addNewCounterViewModel);
                return Ok("Create Successfully");
            }
        }

        [HttpPut]
        [Route("AssignCounterToEmployee")]
        public async Task<IActionResult> AssignCounterToEmployee(
            [FromBody] AssignCounterToViewModel assignCounterToViewModel, Guid employeeId)
        {
            await _counterService.AssignCounterToEmployee(assignCounterToViewModel, employeeId);
            return Ok("Assign Successfully");
        }
    }
}
