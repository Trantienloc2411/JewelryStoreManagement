using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int AccummulatedPoint { get; set; }  
        //public string? Password { get; set; }
        
        public Genders Gender { get; set; } 
        public enum Genders 
        {
            Male,
            Female,
        }

        public virtual ICollection<CustomerPolicy> CustomerPolicies { get; set;}
        public virtual ICollection<Order> Orders {get;set;}
    }
}
