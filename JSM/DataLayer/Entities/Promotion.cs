﻿#pragma warning disable
namespace DataLayer.Entities
{
    public class Promotion
    {
        
        public Guid PromotionCode { get; set; }
        public string? Description { get; set; }
        public double? DiscountPercentage { get; set;}
        public double? FixedDiscountAmount { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }  
    }
}
