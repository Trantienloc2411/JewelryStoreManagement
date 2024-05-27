using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class RefreshHandlerRepository : GenericRepositories<RefreshToken>
{
    public RefreshHandlerRepository(JSMDbContext context) : base(context){}
}