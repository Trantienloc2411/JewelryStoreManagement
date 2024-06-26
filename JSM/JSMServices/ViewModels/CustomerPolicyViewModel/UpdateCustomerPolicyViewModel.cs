using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static DataLayer.Entities.CustomerPolicy;

namespace JSMServices.ViewModels.CustomerPolicyViewModel
{
    public class UpdateCustomerPolicyViewModel
    {
        public double DiscountRate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        [NotNull]
        public string ApprovedBy { get; set; }
        [DefaultValue(PublishingStatuses.Pending)]
        public PublishingStatuses PublishingStatus { get; set; }

        public DateTime ApprovedDate { get; set; }
        public bool IsApprovalRequired { get; set; }
    }
}
