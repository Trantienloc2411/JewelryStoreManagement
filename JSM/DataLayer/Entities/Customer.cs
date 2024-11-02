using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(255)]
        public string? Address { get; set; }
        [MaxLength(10)]
        public string? Phone { get; set; }
        [DefaultValue(0)]
        public int AccumulatedPoint { get; set; } 
        [AllowNull]
        [MaxLength(255)]
        public string? Email { get; set; }
        [AllowNull]
        [MaxLength(150)]
        [JsonIgnore]
        public string? Password {get;set;}
        
        
        //public string? Password { get; set; }
        
        public CustomerGenders CustomerGender { get; set; } 
        public enum CustomerGenders 
        {
            Male,
            Female,
        }
        [JsonIgnore]

        public virtual ICollection<CustomerPolicy> CustomerPolicies { get; set;}
        [JsonIgnore]
        public virtual ICollection<Order> Orders {get;set;}
        [JsonIgnore]
        public virtual ICollection<Transactions> Transactions { get; set; }
        
    }
}
