using System.Text.Json.Serialization;

#pragma warning disable
namespace DataLayer.Entities
{
    public class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ManufactureCost { get; set; }
        public OrderDetailStatuses OrderDetailStatus { get; set; }

        public enum OrderDetailStatuses
        {
            Purchased,
            BuyBack
        }
        [JsonIgnore]
        public virtual Order Order { get; set; }  
        [JsonIgnore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Warranty Warranty { get; set; }



        

    }
}
