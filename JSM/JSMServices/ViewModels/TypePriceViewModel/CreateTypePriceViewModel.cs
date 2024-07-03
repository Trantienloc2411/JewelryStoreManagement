namespace JSMServices.ViewModels.TypePriceViewModel
{
    public class CreateTypePriceViewModel
    {
        public string? TypeName { get; set; }
        public double BuyPricePerGram { get; set; }
        public double SellPricePerGram { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
