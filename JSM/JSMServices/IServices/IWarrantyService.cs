using DataLayer.Entities;
using JSMServices.ViewModels.WarrantyViewModel;

namespace JSMServices.IServices;

public interface IWarrantyService
{
    Task<ICollection<Warranty>> GetAllWarranty();
    Task<Warranty> GetWarrantyById(Guid warrantyId);
    Task<string> UpdateWarrantyDate(UpdateWarrantyViewModel viewModel);

    Task<string> CreateWarranty(CreateWarrantyViewModel viewModel);
}