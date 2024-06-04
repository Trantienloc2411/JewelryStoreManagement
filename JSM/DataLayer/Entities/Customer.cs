using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        //public string? Password { get; set; }
        
        public Genders Gender { get; set; } 
        public enum Genders 
        {
            Male,
            Female,
        }

        public virtual ICollection<CustomerPolicy> CustomerPolicies { get; set;}
        public virtual ICollection<Order> Orders {get;set;}
        public virtual ICollection<Transactions> Transactions { get; set; }
        
    }
}
