using System.Security.Claims;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;

namespace JSMServices.IServices;

public interface IEmployeeService
{
    //your define interface right here
    public Task<Employee> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel, ClaimsPrincipal user);
    //public Task<Employee> LoginAccountEmployee(LoginEmployeeViewModel loginEmployeeViewModel);
    public Task<ICollection<Employee>> GetAllEmployee();
    public Employee GetEmployeeById(Guid employeeId);
    public Employee GetEmployeeByEmail(string email);

    public Task<Employee> UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword);
    public Task<string> UpdateStatusEmployeeAccount(Guid uid);
    public Task<string> DeleteEmployeeAccount(Guid uid);
    public Task<string> UpdateInformationEmployee(UpdateInformationViewModel updateInformationEmployeeViewModel);

}