using System.Diagnostics.CodeAnalysis;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public double ManufactureCost { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int CounterId { get; set; }
        public int TypeId { get; set; }
        public string? Img { get; set; }
        [AllowNull] 
        public string? CertificateUrl { get; set; }
        public ProductStatuses ProductStatus { get; set; }
        public double Price { get; set; }
        public double MarkupRate { get; set; }
        public Units WeightUnit { get; set; }
        public double StonePrice { get; set; }
        public enum Units
        {
            g,
            ct,
        }
        public enum ProductStatuses
        {
            Active,
            Deactive
        }

        public virtual TypePrice TypePrice { get; set; }
        public virtual Counter Counter { get; set; }
        public ICollection<BuyBack> BuyBacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
