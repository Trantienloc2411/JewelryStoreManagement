using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class ProductRepository : GenericRepositories<Product>
{
    public ProductRepository(JSMDbContext context)  : base(context) {}
}