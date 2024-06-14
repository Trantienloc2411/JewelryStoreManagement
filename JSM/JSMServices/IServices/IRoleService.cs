using DataLayer.Entities;

namespace JSMServices.IServices;

public interface IRoleService
{
    Task<ICollection<Role>> GetAllRoles();
}