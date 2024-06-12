using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.ProductViewModel;
using Microsoft.EntityFrameworkCore;

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
            var listProduct = await _productRepository.GetAllWithAsync();
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
            var existedEmployeeList = _productRepository.GetAll();
            var product = new Product();

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
            // Log the exception or handle it in some other way
            throw new Exception($"An error occurred while adding the product: {ex.Message}");
        }

        // If we reach this point, something went wrong during the add operation
        throw new Exception("An error occurred while adding the product.");
    }
}