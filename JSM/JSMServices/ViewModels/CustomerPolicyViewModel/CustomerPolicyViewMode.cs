using static DataLayer.Entities.CustomerPolicy;

namespace JSMServices.ViewModels.CustomerPolicyViewModel
{
    public class CustomerPolicyViewMode
    {
        public Guid CPId { get; set; }
        public Guid CustomerId { get; set; }
        public double DiscountRate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string? ApprovedBy { get; set; }
        public PublishingStatuses PublishingStatus { get; set; }
        public PolicyStatuses PolicyStatus { get; set; }

        public DateTime ApprovedDate { get; set; }
        public bool IsApprovalRequired { get; set; }

        public string? CustomerName { get; set; }
    }
}
