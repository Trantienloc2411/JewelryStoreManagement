using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;

namespace JSMServices.Services;

public class GiftService : IGiftService
{
    private readonly GiftRepository _giftRepo;
    private readonly CustomerRepository _cusRepo;

    public GiftService(GiftRepository giftRepo, CustomerRepository customerRepository)
    {
        _giftRepo = giftRepo;
        _cusRepo = customerRepository;
    }

    public async Task<ICollection<Gift>> GetAllGifts()
    {
        try
        {
            return await _giftRepo.GetAllWithAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new Exception(ex.Message);
            
        }
    }

    public async Task<Gift> GetGiftDetailsByGiftId(Guid giftId)
    {
        try
        {
            var existGift = new Gift();
            existGift = await _giftRepo.GetSingleWithAsync(c => c.GiftId == giftId);
            return existGift;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    public async Task<string> ExchangeGiftUser(Guid customerId, Guid giftId)
    {
        throw new NotImplementedException();
    }

    //this function will automatically send email
    public Task NotifyGiftUser(Guid customerId)
    {
        throw new NotImplementedException();
    }
}