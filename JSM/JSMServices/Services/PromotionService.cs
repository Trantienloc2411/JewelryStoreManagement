using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.PromotionViewModel;

namespace JSMServices.Services;

public class PromotionService : IPromotionService
{
    private readonly PromotionRepository _promotionRepository;
    private readonly IMapper _mapper;
    

    public PromotionService(PromotionRepository promotionRepository, IMapper mapper)
    {
        _promotionRepository = promotionRepository;
        _mapper = mapper;
    }
    public async Task<Promotion?> AddNewPromotion(CreatePromotionViewModel viewModel)
    {
        try
        {
            var listPromotionCurrent = _promotionRepository.GetAll();
            var existedPromotion =
                listPromotionCurrent.FirstOrDefault(c => c.PromotionCode.Equals(viewModel.PromotionCode));
            if (existedPromotion != null)
            {
                return null;

            }
            else
            {
                var p = new Promotion();
                var newPromotion = _mapper.Map(viewModel, p);
                newPromotion.PromotionStatus = Promotion.PromotionStatuses.Active;
                newPromotion.PromotionCode = newPromotion.PromotionCode.ToLower();
                 _promotionRepository.Add(newPromotion); 
                 await _promotionRepository.SaveChangesAsync();
                return (newPromotion);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        
    }

    public Task DeletePromotion(string promotionCode)
    {
        try
        {
            var deletePromotion = _promotionRepository.GetAll().FirstOrDefault(c => c.PromotionCode.ToLower() == promotionCode);
            if (deletePromotion is { PromotionStatus: Promotion.PromotionStatuses.Deleted })
            {
                throw new Exception("This Promotion is not available or was deleted");
            }
            else
            {
                deletePromotion.PromotionStatus = Promotion.PromotionStatuses.Deleted;
                _promotionRepository.SaveChanges();
                return Task.CompletedTask;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public async Task<ICollection<Promotion>> GetAllPromotion()
    {
        
        try
        {
            var promotions = await _promotionRepository.GetAllWithAsync();

            var listPromotion = promotions
                .Where(c => c.PromotionStatus != Promotion.PromotionStatuses.Deleted)
                .ToList(); // Convert to List<Promotion> which implements ICollection<Promotion>

            return listPromotion;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public async Task<Promotion> GetSinglePromotion(string promotionCode)
    {
        try
        {
            var promotions = await _promotionRepository.GetAllWithAsync();

            var singlePromotion = promotions
                .FirstOrDefault(c => c.PromotionStatus != Promotion.PromotionStatuses.Deleted);
                 // Convert to List<Promotion> which implements ICollection<Promotion>
                 if (singlePromotion == null)
                 {
                     throw new Exception("This promotion is not existed");
                 }
                 else if (singlePromotion.PromotionStatus == Promotion.PromotionStatuses.Deleted)
                 {
                     throw new Exception("This promotion was deleted");
                 }
                 return singlePromotion;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}