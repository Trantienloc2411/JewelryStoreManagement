#pragma warning disable
namespace DataLayer.Entities
{
    public class CustomerPolicy
    {
        public Guid CPId { get; set; }
        public Guid CustomerId { get; set; }
        public double DiscountRate { get; set; }
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; }
        public string? ApproveBy { get; set; }  
        public PublishingStatuses PublishingStatus { get; set; }
        public DateTime ApprovedDate { get;set; }
        public bool IsApprovalRequired {  get; set; }

        public enum PublishingStatuses
        {
            Pending,
            Approved,
            Denied
        }

        public virtual Customer Customer { get; set; }
        
    }
}
