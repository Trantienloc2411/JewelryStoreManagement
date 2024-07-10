using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.GiftViewModel;
using Microsoft.EntityFrameworkCore;

namespace JSMServices.Services;

public class GiftService : IGiftService
{
    private readonly GiftRepository _giftRepo;
    private readonly CustomerRepository _cusRepo;
    private readonly IMapper _mapper;

    public GiftService(GiftRepository giftRepo, CustomerRepository customerRepository, IMapper mapper)
    {
        _giftRepo = giftRepo;
        _cusRepo = customerRepository;
        _mapper = mapper;
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

    public async Task<ApiResponse> CreateGift(CreateGiftViewModel giftViewModel)
    {
        try
        {
            var existedGiftList = _giftRepo.GetAll();
            var gift = new Gift();
            if (existedGiftList.FirstOrDefault(e => e.GiftName.Equals(giftViewModel.GiftName)) != null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Message = $"GiftName '{giftViewModel.GiftName}' is already existed. Please use another GiftName."
                };
            }
            _mapper.Map(giftViewModel, gift);
            gift.GiftId = new Guid();
            var entityEntry = await _giftRepo.AddSingleWithAsync(gift);

            if (entityEntry.State == EntityState.Added)
            {
                await _giftRepo.SaveChangesAsync();
            }
            return new ApiResponse { IsSuccess = true, Data = new List<object> { gift } };
        }
        catch (Exception ex)
        {
            return new ApiResponse { IsSuccess = false, Message = ex.InnerException?.Message ?? ex.Message };
        }
    }

    //this function will automatically send email
    public Task NotifyGiftUser(Guid customerId)
    {
        throw new NotImplementedException();
    }
}