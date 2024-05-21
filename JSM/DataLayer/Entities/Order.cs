using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }  
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public Types Type { get; set; }
        public Guid PromotionCode { get; set; }   
        public int AccumulatedPoint { get; set; }
        public int CounterId { get; set; }

        public enum Types
        {
            BuyBack,
            Selling
        }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Promotion Promotion { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual BuyBack BuyBack { get; set; }
        public virtual Counter Counter { get; set; }

    }
}
