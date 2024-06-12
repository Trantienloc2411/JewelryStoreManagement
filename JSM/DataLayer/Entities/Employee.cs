using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [NotNull]
        [MaxLength(100)]
        public string? Name { get; set; }
        [NotNull]
        [MaxLength(150)]
        public string? Email {  get; set; }
        [NotNull]
        [MaxLength(10)]
        public string? Phone { get; set; }
        [NotNull]
        public EmployeeStatuses EmployeeStatus { get; set; }
        [MaxLength(256)]
        [NotNull]
        public string? Password { get; set; }
        public Genders Gender { get; set; }
        [DefaultValue(false)]
        public bool IsLogin { get; set; }
        [AllowNull]
        public Guid ManagedBy { get; set; }
        [AllowNull]
        public int CounterId { get; set; }
        
        
        public int RoleId { get; set; }
        
        public enum Genders
        {
            Male,
            Female
        }

        public enum EmployeeStatuses
        {
            Active, 
            Inactive,
            Unassign,
            Deleted,
        }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual Counter Counter { get; set; }
        public virtual Role Role { get; set; }
    }
}
