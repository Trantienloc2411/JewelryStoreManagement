using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSMServices.ViewModels.PromotionViewModel
{
    public class CreatePromotionViewModel
    {   
        public string PromotionCode { get; set; }   
        public double DiscountPercentage { get; set; }
        public double FixedDiscountAmount { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }   
    }
}
