using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
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
            var listProduct = _productRepository.GetAll();
            listProduct = listProduct.Where(p => p.ProductStatus != Product.ProductStatuses.Deactive).ToList();
            return listProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task<Product> AddNewProductAsync(AddProductViewModel addProductViewModel)
    {
        try
        {
            var existedProductList = _productRepository.GetAll();
            var product = new Product();
            if (existedProductList.FirstOrDefault(e => e.Barcode.Equals(addProductViewModel.Barcode)) != null)
            {
                throw new Exception($"Barcode '{addProductViewModel.Barcode}' is already existed. Please use another Barcode.");
            }
            _mapper.Map(addProductViewModel, product);
            product.ProductId = new Guid();
            var entityEntry = await _productRepository.AddSingleWithAsync(product);

            if (entityEntry.State == EntityState.Added)
            {
                await _productRepository.SaveChangesAsync();
                return product;
            }

        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while adding the product: {ex.Message}");
        }

        throw new Exception("An error occurred while adding the product.");
    }

    public async Task DeleteProduct(Guid uid)
    {
        try
        {
            var product = _productRepository.GetAll().FirstOrDefault(c => c.ProductId == uid);
            if (product == null)
            {
                throw new Exception("The product is not exist or was deleted");
            }
            else
            {
                product.ProductStatus = Product.ProductStatuses.Deactive;
                await _productRepository.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task UpdateStatusProduct(Guid uid)
    {
        try
        {
            var product = _productRepository.Get(c => c.ProductId.Equals(uid));
            if (product.Name == null || product.Name.Length == 0)
            {
                throw new Exception("Something went wrong! Everything changes will not saving!");
            }
            else
            {
                product.ProductStatus = product.ProductStatus switch
                {
                    Product.ProductStatuses.Active => Product.ProductStatuses.Deactive,
                    Product.ProductStatuses.Deactive => Product.ProductStatuses.Active,
                    _ => throw new Exception("The product is not existed or was deleted!")
                };

                await _productRepository.SaveChangesAsync();
            }
            await _productRepository.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task UpdateInformationProduct(UpdateProductViewModel updateProductViewModel, Guid productId)
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
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
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
            var listProduct = _productRepository.GetAll();
            var filterProducts = listProduct
                .Where(p => p.CounterId.Equals(counterId) && p.ProductStatus == Product.ProductStatuses.Active)
                .ToList();
            if (!filterProducts.Any())
            {
                throw new Exception("The product does not existed or was deleted");
            }
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
            var listProduct = await _productRepository.GetSingleWithAsync(b => b.ProductId.Equals(productId));
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
}