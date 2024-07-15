using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}
