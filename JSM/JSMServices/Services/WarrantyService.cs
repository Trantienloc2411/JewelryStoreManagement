using DataLayer.Entities;
using JSMServices.IServices;
using JSMServices.ViewModels.WarrantyViewModel;

namespace JSMServices.Services;

public class WarrantyService : IWarrantyService
{
    public async Task<ICollection<Warranty>> GetAllWarranty()
    {
        throw new NotImplementedException();
    }

    public async Task<Warranty> GetWarrantyById(Guid warrantyId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> UpdateWarrantyDate(UpdateWarrantyViewModel viewModel)
    {
        throw new NotImplementedException();
    }
}