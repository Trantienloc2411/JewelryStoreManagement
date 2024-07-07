#pragma warning disable


using System.Diagnostics.CodeAnalysis;

namespace DataLayer.Entities
{
    public class Order
    {
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }  
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public Types Type { get; set; }
        [AllowNull]
        public string? PromotionCode { get; set; }   
        public int AccumulatedPoint { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }
        
        public OrderStatuses OrderStatus { get; set; }

        public enum OrderStatuses
        {
            Created,
            Paying,
            Completed
        }

        public enum Types
        {
            BuyBack,
            Selling
        }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Promotion? Promotion { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual BuyBack BuyBack { get; set; }
        public virtual Counter Counter { get; set; }
        
        public virtual PaymentMethod? PaymentMethod { get; set; }

    }
}
