using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.ProductViewModel;

namespace JSMServices.IServices;

public interface IProductService
{
    public Task<ICollection<Product>> GetAllProducts();
    Task<ApiResponse> AddNewProductAsync(AddProductViewModel addProductViewModel);
    public Task<ApiResponse> DeleteProduct(Guid uid);
    public Task<ApiResponse> UpdateStatusProduct(Guid uid);
    public Task<ApiResponse> UpdateInformationProduct(UpdateProductViewModel updateProductViewModel, Guid productId);
    public Task<Product> GetProductByBarcode(string Barcode);
    public Task<ICollection<Product>> GetProductByCounterId(int counterId);
    public Task<Product> GetProductById(Guid productId);

}