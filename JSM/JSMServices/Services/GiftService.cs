using DataLayer.Entities;
using JSMServices.IServices;

namespace JSMServices.Services;

public class GiftService : IGiftService
{
    public async Task<ICollection<Gift>> GetAllGifts()
    {
        throw new NotImplementedException();
    }

    public async Task<Gift> GetGiftDetailsByGiftId(Guid giftId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> ExchangeGiftUser(Guid customerId, Guid giftId)
    {
        throw new NotImplementedException();
    }
}