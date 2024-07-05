using DataLayer.Entities;
using JSMServices.ViewModels.ProductViewModel;

namespace JSMServices.IServices;

public interface IProductService
{
    public Task<ICollection<Product>> GetAllProducts();
    Task<Product> AddNewProductAsync(AddProductViewModel addProductViewModel);
    public Task DeleteProduct(Guid uid);
    public Task UpdateStatusProduct(Guid uid);
    public Task UpdateInformationProduct(UpdateProductViewModel updateProductViewModel, Guid productId);
    public Task<Product> GetProductByBarcode(string Barcode);
    public Task<ICollection<Product>> GetProductByCounterId(int counterId);
    public Task<Product> GetProductById(Guid productId);

}