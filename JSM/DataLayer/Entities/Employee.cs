using System.Diagnostics.CodeAnalysis;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [NotNull]
        public string? Name { get; set; }
        [NotNull]
        public string? Email {  get; set; }
        [NotNull]
        public string? Phone { get; set; }
        [NotNull]
        public Statuses Status { get; set; }
        public string? Password { get; set; }
        public Genders Gender { get; set; }
        public bool isLogin { get; set; }
        
        public int CounterId { get; set; }
        
        //Relationship
        public int RoleId { get; set; }
        
        public enum Genders
        {
            Male,
            Female
        }

        public enum Statuses
        {
            Active, 
            Inactive,
            Deleted,
        }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual Counter Counter { get; set; }
        public virtual Role Role { get; set; }
    }
}
