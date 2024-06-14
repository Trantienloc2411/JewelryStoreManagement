using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class RoleRepository : GenericRepositories<Role>
{
    public RoleRepository(JSMDbContext context) : base(context){}
}