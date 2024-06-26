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

    public Task<Promotion> DeletePromotion(string promotionCode)
    {
        try
        {
            var deletePromotion = _promotionRepository.GetAll().FirstOrDefault(c => c.PromotionCode.ToLower() == promotionCode);
            if (deletePromotion == null || deletePromotion.PromotionStatus == Promotion.PromotionStatuses.Deleted)
            {
                return null;
                throw new Exception("This Promotion is not available or was deleted");
            }
            else
            {
                deletePromotion.PromotionStatus = Promotion.PromotionStatuses.Deleted;
                _promotionRepository.SaveChanges();
                return Task.FromResult(deletePromotion);
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


    public Task<Promotion> GetSinglePromotion(string promotionCode)
    {
        try
        {
            // Materialize the query results immediately
            var promotions = _promotionRepository.GetAll();
            var singlePromotion = promotions
                .FirstOrDefault(c => c.PromotionCode == promotionCode && c.PromotionStatus != Promotion.PromotionStatuses.Deleted);

            if (singlePromotion == null)
            {
                return null;
            }
            else
            {
                return Task.FromResult(singlePromotion);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}