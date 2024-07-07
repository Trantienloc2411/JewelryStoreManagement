using DataLayer.Entities;

namespace JSMServices.IServices;

public interface IGiftService
{
    Task<ICollection<Gift>> GetAllGifts();
    Task<Gift> GetGiftDetailsByGiftId(Guid giftId);
    
    Task NotifyGiftUser(Guid customerId);
}