using DataLayer.Entities;

namespace JewelryStoreManagement.ViewModels;

public class RegisterEmployeeViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int CounterId { get; set; }
    public int RoleId { get; set; }
    public Employee.EmployeeGenders EmployeeGender { get; set; }
    public Employee.EmployeeStatuses EmployeeStatus { get; set; }
}

