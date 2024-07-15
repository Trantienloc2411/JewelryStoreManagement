using DataLayer.Entities;

namespace JSMServices.ViewModels.PromotionViewModel;

public class PromotionViewModel
{
    public string PromotionCode { get; set; }   
    public double DiscountPercentage { get; set; }
    public string Description { get; set; }
    public double FixedDiscountAmount { get; set; } 
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }   
    public Promotion.PromotionStatuses PromotionStatus { get; set; }
}