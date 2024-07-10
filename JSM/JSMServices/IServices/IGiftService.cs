using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.GiftViewModel;

namespace JSMServices.IServices;

public interface IGiftService
{
    Task<ICollection<Gift>> GetAllGifts();
    Task<Gift> GetGiftDetailsByGiftId(Guid giftId);
    Task<ApiResponse> CreateGift(CreateGiftViewModel giftViewModel);

    Task NotifyGiftUser(Guid customerId);
}