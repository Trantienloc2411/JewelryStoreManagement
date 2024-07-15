using System.Globalization;
using System.Xml.Linq;
using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.TypePriceViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JSMServices.Services;

public class TypePriceService : ITypePriceService
{
    private readonly TypePriceRepository _typePriceRepository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    public TypePriceService(TypePriceRepository typePriceRepository, IMapper mapper, IConfiguration configuration)
    {
        _typePriceRepository = typePriceRepository;
        _mapper = mapper;
        _configuration = configuration;
    }

    public async Task<ApiResponse> CreateNewTypePrice(CreateTypePriceViewModel createTypePriceViewModel)
    {
        try
        {
            var existedTypePriceList = _typePriceRepository.GetAll();
            var typePrice = new TypePrice();
            if (existedTypePriceList.FirstOrDefault(e => e.TypeName.Equals(createTypePriceViewModel.TypeName)) != null)
            {
                throw new Exception($"TypeName '{createTypePriceViewModel.TypeName}' is already existed. Please use another Name.");
            }
            _mapper.Map(createTypePriceViewModel, typePrice);
            typePrice.TypeId = new int();
            var entityEntry = await _typePriceRepository.AddSingleWithAsync(typePrice);

            if (entityEntry.State == EntityState.Added)
            {
                await _typePriceRepository.SaveChangesAsync();
                return new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = $"Create Successfully"
                };
            }

        }
        catch (Exception ex)
        {
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = ex.Message
            };
            
        }

        throw new Exception("An error occurred while adding the typePrice.");
    }

    public async Task<ApiResponse> DeleteTypePrice(int typeId)
    {
        try
        {
            var typePrice = await _typePriceRepository.GetSingleWithAsync(c => c.TypeId == typeId);
            _typePriceRepository.Remove(typePrice);
            _typePriceRepository.SaveChanges();
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = $"Delete Successfully"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = e.Message
            };
        }
    }

    public async Task<ICollection<TypePrice>> GetAllTypePrice()
    {
        try
        {
            var typePriceList = await _typePriceRepository.GetAllWithAsync();
            return typePriceList;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }   
        
    }

    public async Task fetchDataType()
    {
        try
        {
            var listTypePrice = await _typePriceRepository.GetAllWithAsync();
            string url = _configuration["UrlGoldPrice"];

            using (var client = new HttpClient())
            {
                try
                {
                    string xmlContent = await client.GetStringAsync(url);
                    XDocument doc = XDocument.Parse(xmlContent);

                    var updateDateString = doc.Descendants("ratelist").First().Attribute("updated").Value;
                    DateTime updateDate = DateTime.ParseExact(updateDateString, "hh:mm:ss tt dd/MM/yyyy",
                        CultureInfo.InvariantCulture);

                    var hoChiMinhData = doc.Descendants("city")
                        .Where(c => c.Attribute("name").Value == "Hồ Chí Minh")
                        .First()
                        .Elements("item");

                    foreach (var item in hoChiMinhData)
                    {
                        string typeName = item.Attribute("type").Value;
                        double buyPrice = double.Parse(item.Attribute("buy").Value, CultureInfo.InvariantCulture) *
                                          1000; // Convert to price per gram
                        double sellPrice = double.Parse(item.Attribute("sell").Value, CultureInfo.InvariantCulture) *
                                           1000; // Convert to price per gram

                        var typePrice = listTypePrice.FirstOrDefault(c => c.TypeName.ToLower() == typeName.ToLower());
                        if (typePrice != null)
                        {
                            typePrice.BuyPricePerGram = buyPrice;
                            typePrice.SellPricePerGram = sellPrice;
                            typePrice.DateUpdated = updateDate;
                            await _typePriceRepository.UpdateWithAsync(typePrice);
                            _typePriceRepository.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<TypePrice> GetTypePriceById(int typeId)
    {
        try
        {
            var listTypePrice = await _typePriceRepository.GetSingleWithAsync(t => t.TypeId.Equals(typeId));
            if (listTypePrice == null)
            {
                throw new Exception("The TypePrice does not exist or was deleted");
            }
            return listTypePrice;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ApiResponse> UpdateTypePriceInfo(UpdateTypePriceViewModel updateTypePriceViewModel, int typeId)
    {
        try
        {
            var getListTypePrice = _typePriceRepository.GetAll();
            var updateTypePrice = getListTypePrice.FirstOrDefault(e => e.TypeId == typeId);
            if (updateTypePrice == null)
            {
                throw new Exception("Update not successfully! Reload Page again!");
            }
            else
            {
                var updated = _mapper.Map(updateTypePriceViewModel, updateTypePrice);
                await _typePriceRepository.UpdateWithAsync(updated);
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Update Successfully"
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = $"Delete failed ! {e.Message}"
            };
        }
    }
}