using System.Text.Json.Serialization;

#pragma warning disable
namespace DataLayer.Entities
{
    public class BuyBack
    {
        public Guid BuyBackId { get; set; }
        public Guid ProductId { get; set; }
        public string OrderId { get; set; }   
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public bool HaveInvoice { get; set; }
        public double ManufactureCost { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
        
        
    }
}
