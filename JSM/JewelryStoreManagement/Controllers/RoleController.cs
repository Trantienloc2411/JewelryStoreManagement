using JSMServices.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;

[ApiController]
[Route("Role")]
public class RoleController : Controller
{
    private readonly IRoleService _roleService;

    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet]
    [Route("GetAllRole")]       
    
    public async Task<IActionResult> GetAllRoutes()
    {
        var listRole = await _roleService.GetAllRoles();
        return Ok(listRole);
    }
}
