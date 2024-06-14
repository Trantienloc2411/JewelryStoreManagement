using System.ComponentModel.DataAnnotations;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Counter
    {
        public int CounterId { get; set; }
        [MaxLength(100)]
        
        public string? CounterName { get; set; }
        [MaxLength(20)]
        public string? Location { get;set; }
        
        public bool IsActive { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
