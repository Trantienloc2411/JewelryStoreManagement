using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.ProductViewModel;
using Microsoft.EntityFrameworkCore;
#pragma warning disable
namespace JSMServices.Services;

public class ProductService : IProductService
{
    private readonly ProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(ProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ICollection<Product>> GetAllProducts()
    {
        try
        {
            var listProduct = await _productRepository.GetAllWithIncludeAsync(e => true, e => e.Counter, e => e.TypePrice);
            listProduct = listProduct.ToList();
            return listProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task<ApiResponse> AddNewProductAsync(AddProductViewModel addProductViewModel)
    {
        try
        {
            var existedProductList = _productRepository.GetAll();
            var product = new Product();
            if (existedProductList.FirstOrDefault(e => e.Barcode.Equals(addProductViewModel.Barcode)) != null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Barcode '{addProductViewModel.Barcode}' is already existed. Please use another Barcode."
                };

            }
            _mapper.Map(addProductViewModel, product);
            product.ProductId = new Guid();
            var entityEntry = await _productRepository.AddSingleWithAsync(product);

            if (entityEntry.State == EntityState.Added)
            {
                await _productRepository.SaveChangesAsync();
                return new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = $"Update Successfully"
                };
            }

        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while adding the product: {ex.Message}");
        }

        throw new Exception("An error occurred while adding the product.");
    }

    public async Task<ApiResponse> DeleteProduct(Guid uid)
    {
        try
        {
            var product = _productRepository.GetAll().FirstOrDefault(c => c.ProductId == uid);
            if (product == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"The product is not exist or was deleted"
                };

            }
            else
            {
                product.ProductStatus = Product.ProductStatuses.Deactive;
                await _productRepository.SaveChangesAsync();
                return new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = $"Deleted Successfully"
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ApiResponse> UpdateStatusProduct(Guid uid)
    {
        try
        {
            var product = await _productRepository.GetSingleWithAsync(c => c.ProductId == uid);

            if (product == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "The product does not exist or was deleted!"
                };
            }

            if (string.IsNullOrEmpty(product.Name))
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Something went wrong! Changes will not be saved!"
                };
            }

            product.ProductStatus = product.ProductStatus switch
            {
                Product.ProductStatuses.Active => Product.ProductStatuses.Deactive,
                Product.ProductStatuses.Deactive => Product.ProductStatuses.Active,
                _ => throw new InvalidOperationException("Invalid product status")
            };

            await _productRepository.SaveChangesAsync();

            return new ApiResponse
            {
                IsSuccess = true,
                Data = null,
                Message = "Product status updated successfully"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = $"An error occurred: {e.Message}"
            };
        }
    }

    public async Task<ApiResponse> UpdateInformationProduct(UpdateProductViewModel updateProductViewModel, Guid productId)
    {
        try
        {
            var getListProducts = _productRepository.GetAll();
            var productUpdate = getListProducts.FirstOrDefault(c => c.ProductId == productId);
            if (productUpdate == null)
            {
                throw new Exception("Update not successfully! Reload Page again!");
            }

            else
            {
                if (productUpdate.ProductStatus == Product.ProductStatuses.Deactive)
                {
                    throw new Exception("The product does not existed or was deleted!");
                }
                else
                {
                    var productUpdated = _mapper.Map(updateProductViewModel, productUpdate);
                    await _productRepository.UpdateWithAsync(productUpdated);
                    return new ApiResponse
                    {
                        IsSuccess = true,
                        Data = null,
                        Message = $"Update Successfully"
                    };
                }
            }
        }
        catch (Exception e)
        {
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = e.Message
            };


        }
    }

    public async Task<Product> GetProductByBarcode(string Barcode)
    {
        try
        {
            var listProduct = await _productRepository.GetSingleWithAsync(b => b.Barcode.Equals(Barcode));
            if (listProduct == null || listProduct.ProductStatus == Product.ProductStatuses.Deactive)
            {
                throw new Exception("The product does not exist or was deleted");
            }
            return listProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ICollection<Product>> GetProductByCounterId(int counterId)
    {
        try
        {
            var listProduct = await _productRepository.GetAllWithIncludeAsync(e => true, e => e.Counter, e => e.TypePrice);
            var filterProducts = listProduct
                .Where(p => p.CounterId.Equals(counterId))
                .ToList();
            if (!filterProducts.Any())
            {
                throw new Exception("The product does not existed or was deleted");
            }
            filterProducts = filterProducts.ToList();
            return filterProducts;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Product> GetProductById(Guid productId)
    {
        try
        {
            var listProduct = await _productRepository.GetSingleWithIncludeAsync(e => e.ProductId == productId, e=>e.Counter);
            if (listProduct == null)
            {
                throw new Exception("The product does not exist or was deleted");
            }
            return listProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}