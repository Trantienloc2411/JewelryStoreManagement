using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class GiftRepository : GenericRepositories<Gift>
{
    public GiftRepository(JSMDbContext context) : base(context){}
}