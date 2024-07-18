using DataLayer.Entities;

namespace JSMServices.ViewModels.TransactionViewModel;

public class GetAllTransaction
{
    public Guid TransactionId { get; set; }
    public Guid GiftId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime TransactionDateTime { get; set; }
    public int PointMinus { get; set; }
    
    public Customer? Customer { get; set; }
    public Gift? Gift { get; set; }
}