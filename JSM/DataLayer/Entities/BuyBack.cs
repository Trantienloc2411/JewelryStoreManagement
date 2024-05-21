using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class BuyBack
    {
        public Guid BuyBackId { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }   
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public bool HaveInvoice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        
        
    }
}
