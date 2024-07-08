using DataLayer.Entities;
using JSMServices.ViewModels.TypePriceViewModel;

namespace JSMServices.IServices;

public interface ITypePriceService
{
    Task<TypePrice> CreateNewTypePrice(CreateTypePriceViewModel createTypePriceViewModel);

    public Task UpdateTypePriceInfo(UpdateTypePriceViewModel updateTypePriceViewModel, int typeId);

    public Task<TypePrice> GetTypePriceById(int typeId);

    public Task DeleteTypePrice(int typeId);


}