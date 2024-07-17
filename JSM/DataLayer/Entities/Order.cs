#pragma warning disable


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DataLayer.Entities
{
    public class Order
    {
        [MaxLength(32)]
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }  
        public DateTime OrderDate { get; set; }
        public double? Discount { get; set; }
        public Types Type { get; set; }
        [ForeignKey("Promotion")]
        public string? PromotionCode { get; set; }   
        public int? AccumulatedPoint { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }
        [AllowNull]
        public Guid? CPId { get; set; }
        public OrderStatuses OrderStatus { get; set; }

        public enum OrderStatuses
        {
            Created,
            Paying,
            Completed,
            Cancelled
        }

        public enum Types
        {
            BuyBack,
            Selling
        }
        [JsonIgnore]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [JsonIgnore]
        public virtual Promotion? Promotion { get; set; }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
        [JsonIgnore]
        public virtual BuyBack BuyBack { get; set; }
        [JsonIgnore]
        public virtual Counter Counter { get; set; }
        [JsonIgnore]
        public virtual CustomerPolicy? CustomerPolicy { get; set; }
        [JsonIgnore]
        public virtual PaymentMethod? PaymentMethod { get; set; }

    }
}
