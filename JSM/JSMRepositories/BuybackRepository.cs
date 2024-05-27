using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class BuybackRepository : GenericRepositories<BuyBack>
{
    public BuybackRepository(JSMDbContext context)  : base(context) {}
}