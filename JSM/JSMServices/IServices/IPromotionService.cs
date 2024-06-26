using DataLayer.Entities;
using JSMServices.ViewModels.PromotionViewModel;

namespace JSMServices.IServices;

public interface IPromotionService
{
    Task<Promotion?> AddNewPromotion(CreatePromotionViewModel viewModel);
    Task<Promotion> DeletePromotion(string promotionCode);
    Task<ICollection<Promotion>> GetAllPromotion();
    Task<Promotion> GetSinglePromotion(string promotionCode);
}