using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class TypePrice
    {
        public int TypeId { get; set; }
        public string? TypeName { get; set; }   
        public double BuyPricePerGram { get; set; } 
        public double SellPricePerGram { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
