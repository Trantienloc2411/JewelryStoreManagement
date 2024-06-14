using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;

namespace JSMServices.Services;

public class RoleService : IRoleService
{
    private readonly RoleRepository _roleRepository;

    public RoleService(RoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<ICollection<Role>> GetAllRoles()
    {
        try
        {
            var allRole =  _roleRepository.GetAll().Where(c => c.RoleId != 4);

            return (ICollection<Role>)allRole;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}