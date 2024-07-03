using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement;
using JSMServices.IServices;
using JSMServices.ViewModels.TypePriceViewModel;
using Microsoft.EntityFrameworkCore;

namespace JSMServices.Services;

public class TypePriceService : ITypePriceService
{
    private readonly TypePriceRepository _typePriceRepository;
    private readonly IMapper _mapper;

    public TypePriceService(TypePriceRepository typePriceRepository, IMapper mapper)
    {
        _typePriceRepository = typePriceRepository;
        _mapper = mapper;
    }

    public async Task<TypePrice> CreateNewTypePrice(CreateTypePriceViewModel createTypePriceViewModel)
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
                return typePrice;
            }

        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while adding the typePrice: {ex.Message}");
        }

        throw new Exception("An error occurred while adding the typePrice.");
    }

    public async Task DeleteTypePrice(int typeId)
    {
        try
        {
            var typePrice = _typePriceRepository.GetAll().FirstOrDefault(e => e.TypeId == typeId);
            if (typePrice == null)
            {
                throw new Exception("The TypePrice does not exist or was deleted");
            }
            else
            {
                _typePriceRepository.Remove(typePrice);
                _typePriceRepository.SaveChanges();
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

    public async Task UpdateTypePriceInfo(UpdateTypePriceViewModel updateTypePriceViewModel, int typeId)
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
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}