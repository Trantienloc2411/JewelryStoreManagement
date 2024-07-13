namespace DataLayer.Entities;
#pragma warning disable
public class Transactions
{
    public Guid TransactionId { get; set; }
    public Guid GiftId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime TransactionDateTime { get; set; }
    public int PointMinus { get; set; }
    
    public virtual Gift Gift { get; set; }
    public virtual Customer Customer { get; set; }
}