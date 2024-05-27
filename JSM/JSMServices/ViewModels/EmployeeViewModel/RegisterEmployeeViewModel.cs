using DataLayer.Entities;

namespace JewelryStoreManagement.ViewModels;

public class RegisterEmployeeViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int CounterId { get; set; }
    public int RoleId { get; set; }
    public Employee.Genders Gender { get; set; }
    public Employee.Statuses Status { get; set; }
}