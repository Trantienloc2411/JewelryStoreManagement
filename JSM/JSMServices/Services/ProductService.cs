using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;

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
}