using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.TypePriceViewModel;

namespace JSMServices.IServices;

public interface ITypePriceService
{
    Task<ApiResponse> CreateNewTypePrice(CreateTypePriceViewModel createTypePriceViewModel);

    public Task<ApiResponse> UpdateTypePriceInfo(UpdateTypePriceViewModel updateTypePriceViewModel, int typeId);

    public Task<TypePrice> GetTypePriceById(int typeId);

    public Task<ApiResponse> DeleteTypePrice(int typeId);

    Task<ICollection<TypePrice>> GetAllTypePrice();
    
    

}