using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class PromotionRepository : GenericRepositories<Promotion>
{
    public PromotionRepository(JSMDbContext context) : base (context){}
}