using DataLayer.Entities;

namespace JSMServices.IServices;

public interface IProductService
{
    public Task<ICollection<Product>> GetAllProducts();
}