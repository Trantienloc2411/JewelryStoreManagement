using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        

        public virtual Order Order { get; set; }    
        public virtual Product Product { get; set; }
        public virtual Warranty Warranty { get; set; }



        

    }
}
