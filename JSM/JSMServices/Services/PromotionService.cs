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
    public async Task<Promotion> AddNewPromotion(CreatePromotionViewModel viewModel)
    {
        try
        {
            var listPromotionCurrent = await _promotionRepository.GetAllWithAsync();
            if (listPromotionCurrent.FirstOrDefault(c =>
                    string.Equals(c.PromotionCode, viewModel.PromotionCode, StringComparison.CurrentCultureIgnoreCase)) != null)
            {
                throw new Exception("This code is existed! Please use other code");

            }
            
            else if(viewModel.DiscountPercentage.Equals(0) && viewModel.FixedDiscountAmount.Equals(0))
            {
                throw new Exception("The discount percentage and fix discount is empty");
            } else if (viewModel.EndDate < DateTime.Today)
            {
                throw new Exception("The end of discount must not in the past");
            } else if (viewModel.StartDate < DateTime.Today)
            {
                throw new Exception("The start of discount must not in the past");
            }
            else
            {
                var p = new Promotion();
                var newPromotion = _mapper.Map(viewModel, p);
                newPromotion.PromotionStatus = Promotion.PromotionStatuses.Active;
                await _promotionRepository.AddSingleWithAsync(newPromotion); 
                _promotionRepository.SaveChanges();
                return newPromotion;
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