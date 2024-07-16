using static DataLayer.Entities.Employee;

namespace JSMServices.ViewModels.EmployeeViewModel
{
    public class EmployeeByOrderViewModel
    {
        public Guid EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public EmployeeStatuses EmployeeStatus { get; set; }
        public string? Password { get; set; }
        public EmployeeGenders EmployeeGender { get; set; }
        public bool IsLogin { get; set; }
        public Guid ManagedBy { get; set; }
        public int CounterId { get; set; }
        public int RoleId { get; set; }
    }
}
