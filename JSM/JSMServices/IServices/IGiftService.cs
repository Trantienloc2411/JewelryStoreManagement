using DataLayer.Entities;
using JSMServices.ViewModels.GiftViewModel;

namespace JSMServices.IServices;

public interface IGiftService
{
    Task<ICollection<Gift>> GetAllGifts();
    Task<Gift> GetGiftDetailsByGiftId(Guid giftId);
    Task<Gift> CreateGift(CreateGiftViewModel giftViewModel);
    
    Task NotifyGiftUser(Guid customerId);
}