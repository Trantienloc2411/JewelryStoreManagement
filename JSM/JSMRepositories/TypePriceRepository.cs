using DataLayer;
using DataLayer.Entities;
using JSMRepositories;

namespace JewelryStoreManagement;

public class TypePriceRepository : GenericRepositories<TypePrice>
{
    public TypePriceRepository(JSMDbContext context) : base (context){}
}