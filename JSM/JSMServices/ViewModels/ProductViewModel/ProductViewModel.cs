using DataLayer.Entities;
using static DataLayer.Entities.Product;

namespace JSMServices.ViewModels.ProductViewModel
{
    public class ProductViewModel
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
        public string? CertificateUrl { get; set; }
        public ProductStatuses Status { get; set; }
        public double Price { get; set; }
        public double MarkupRate { get; set; }
        public Product.Units WeightUnit { get; set; }
        public double StonePrice { get; set; }
        
        public string? CounterName { get; set; }
        public string? TypeName { get; set; }
    }
}
