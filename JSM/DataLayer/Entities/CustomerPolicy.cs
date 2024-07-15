using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

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
        public string? ApprovedBy { get; set; }  
        [DefaultValue(PublishingStatuses.Pending)]
        public PublishingStatuses PublishingStatus { get; set; }

        public DateTime? ApprovedDate { get; set; }
        public bool IsApprovalRequired {  get; set; }
        //new 
        public PolicyStatuses PolicyStatus { get; set; }
        
        
        public enum PolicyStatuses
        {
            Active,
            Used
        }

        public enum PublishingStatuses
        {
            Pending,
            Approved,
            Denied
        }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }
        
    }
}
