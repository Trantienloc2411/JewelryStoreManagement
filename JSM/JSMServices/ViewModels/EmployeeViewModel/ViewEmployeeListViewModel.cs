using DataLayer.Entities;
#pragma warning disable
namespace JewelryStoreManagement.ViewModels;

public class ViewEmployeeListViewModel
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int CounterId { get; set; }
    public int RoleId { get; set; }
    public Employee.EmployeeStatuses Gender { get; set; }
    public Guid ManagedBy { get; set; }
}