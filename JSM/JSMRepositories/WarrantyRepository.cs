using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class WarrantyRepository : GenericRepositories<Warranty>
{
    public WarrantyRepository(JSMDbContext context) : base(context)
    {
        
    }
}