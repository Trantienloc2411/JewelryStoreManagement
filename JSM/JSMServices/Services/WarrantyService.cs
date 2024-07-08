using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.WarrantyViewModel;

namespace JSMServices.Services;

public class WarrantyService : IWarrantyService
{
    private readonly WarrantyRepository _warranty;
    private readonly IMapper _mapper;
    public WarrantyService(WarrantyRepository warranty, IMapper mapper)
    {
        _mapper = mapper;
        _warranty = warranty;
    }
    public async Task<ICollection<Warranty>> GetAllWarranty()
    {
        try
        {
            var warranties = await _warranty.GetAllWithAsync();
            return warranties;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Warranty> GetWarrantyById(Guid warrantyId)
    {
        try
        {
            var warranty = await _warranty.GetSingleWithAsync(c => c.WarrantyId == warrantyId);
            return warranty;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<string> UpdateWarrantyDate(UpdateWarrantyViewModel viewModel)
    {
        var existWarranty = await _warranty.GetSingleWithAsync(c => c.WarrantyId == viewModel.WarrantyId);
        if (existWarranty.Equals(null))
        {
            return "This warranty is not existed! Try refreshing";
        }
        else
        {
           var warranty = _mapper.Map(viewModel, existWarranty);
           _warranty.Update(warranty);
           _warranty.SaveChanges();
           return "";
        }
    }

    public async Task<string> CreateWarranty(CreateWarrantyViewModel viewModel)
    {
        try
        {
            var warranty = new Warranty();

            if (viewModel.StartDate < DateTime.Today)
            {
                return "StartDate can not in the past";
            }
            else if (viewModel.EndDate < viewModel.StartDate && viewModel.EndDate < DateTime.Today)
            {

                return "End Date can not in the past";
            }
            else
            {
                warranty = _mapper.Map(viewModel, warranty);
                _warranty.Add(warranty);
                await _warranty.SaveChangesAsync();
                return "";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}