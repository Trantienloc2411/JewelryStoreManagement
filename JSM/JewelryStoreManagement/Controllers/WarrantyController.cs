using JSMServices.IServices;
using JSMServices.ViewModels.WarrantyViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;
[ApiController]
[Route("Warranty")]
public class WarrantyController : Controller
{
    
    private readonly IWarrantyService _service;

    public WarrantyController(IWarrantyService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("GetAllWarranty")]
    [Authorize]
    public async Task<IActionResult> GetAllWarranties()
    {
        var result = await _service.GetAllWarranty();
        return Ok(result);
    }

    [HttpGet]
    [Route("GetWarrantyById/{warrantyId}")]
    [Authorize]
    public async Task<IActionResult> GetWarrantyByWarrantyId(Guid warrantyId)
    {
        var result = await _service.GetWarrantyById(warrantyId);
        if (result.Equals(null))
        {
            return BadRequest("Warranty not found");
        }
        else
        {
            return Ok(result);
        }
    }


    [HttpPut]
    [Route("UpdateWarrantyDate")]
    [Authorize]
    public async Task<IActionResult> UpdateWarrantyDate([FromBody] UpdateWarrantyViewModel viewModel)
    {
        var result = await _service.UpdateWarrantyDate(viewModel);
        if (result != "")
        {
            return BadRequest(result);
        }
        else
        {
            return Ok("Update Successfully");
        }
    }

    [HttpPost]
    [Route("CreateNewWarranty")]
    [Authorize]
    public async Task<IActionResult> CreateWarranty([FromBody] CreateWarrantyViewModel viewModel)
    {
        var result = await _service.CreateWarranty(viewModel);
        if (result != "")
        {
            return BadRequest(result);
        }
        else
        {
            return Ok("Create Successfully");
        }
    }



}