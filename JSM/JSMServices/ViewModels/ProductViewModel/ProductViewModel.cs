using DataLayer.Entities;

namespace JSMServices.ViewModels.ProductViewModel
{
    public class ProductViewModel
    {
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public double ManufactureCost { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int CounterId { get; set; }
        public int TypeId { get; set; }
        public string? Img { get; set; }
        public Product.Statuses Status { get; set; }
        public double Price { get; set; }
        public double MarkupRate { get; set; }
    }
}
