using JSMServices.ViewModels.PromotionViewModel;

namespace JSMServices.IServices;

public interface IPromotionService
{
    Task AddNewPromotion(CreatePromotionViewModel viewModel);
    Task UpdatePromotion();
}