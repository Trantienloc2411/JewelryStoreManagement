using DataLayer.Entities;
using JSMServices.ViewModels.ProductViewModel;

namespace JSMServices.IServices;

public interface IProductService
{
    public Task<ICollection<Product>> GetAllProducts();

    Task<Product> AddNewProductAsync(AddProductViewModel addProductViewModel);
}