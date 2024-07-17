namespace JSMServices.ViewModels.PaymentViewModel;

public class PaymentRequestLinkViewModel
{
    public string orderId { get; set; }
    public string description { get; set; }
    public int priceTotal { get; set; }
    public string returnUrl { get; set; }
    public string cancelUrl { get; set; }
    public List<ItemShowRequest> items { get; set; }
}

public class ItemShowRequest
{
    public string productName { get; set; }
    public int quantity { get; set; }
    public double priceSingle { get; set; }
}