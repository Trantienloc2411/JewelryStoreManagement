using DataLayer.Entities;

namespace JSMServices.ViewModels.CustomerPolicyViewModel;

public class CreateRequestCustomerPolicyViewModel
{
    public Guid CustomerId { get; set; }
    public double DiscountRate { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public CustomerPolicy.PublishingStatuses PublishingStatus { get; set; } = CustomerPolicy.PublishingStatuses.Pending;
    public bool IsApprovalRequired { get; set; } = true;
}