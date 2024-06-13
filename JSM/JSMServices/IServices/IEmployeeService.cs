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
    public Task UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword);
    public Task UpdateStatusEmployeeAccount(Guid uid);
    public Task DeleteEmployeeAccount(Guid uid);
    public Task UpdateInformationEmployee(UpdateInformationViewModel updateInformationEmployeeViewModel);



}