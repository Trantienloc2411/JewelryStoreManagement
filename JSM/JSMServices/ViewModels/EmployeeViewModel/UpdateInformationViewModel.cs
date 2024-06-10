using DataLayer.Entities;

namespace JewelryStoreManagement.ViewModels;

public class UpdateInformationViewModel
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int CounterId { get; set; }
    public int RoleId { get; set; }
    public Employee.Genders Gender { get; set; }
    public Guid ManagedBy { get; set; }
}