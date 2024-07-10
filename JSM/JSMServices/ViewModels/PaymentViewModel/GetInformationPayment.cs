namespace JSMServices.ViewModels.PaymentViewModel;

public class GetInformationPayment
{
    public string id { get; set; }
    public string orderCode { get; set; }
    public int amount { get; set; }
    public string status { get; set; }
    public DateTime createAt { get; set; }
    public List<Transactions> transactions { get; set; } 
}

public class Transactions
{
    public string reference { get; set; }
    public string counterAccountName { get; set; }
    public string counterAccountNumber { get; set; }
}