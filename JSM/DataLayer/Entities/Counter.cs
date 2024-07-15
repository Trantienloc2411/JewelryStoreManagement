using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
