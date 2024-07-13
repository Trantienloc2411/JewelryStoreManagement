using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using System.Security.Claims;

namespace JSMServices.IServices;

public interface IEmployeeService
{
    //your define interface right here
    public Task<string> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel, ClaimsPrincipal user);
    //public Task<Employee> LoginAccountEmployee(LoginEmployeeViewModel loginEmployeeViewModel);
    public Task<ICollection<Employee>> GetAllEmployee();
    public Employee GetEmployeeById(Guid employeeId);
    public Task<Employee> GetEmployeeByEmail(string email);
    public Task<ICollection<Employee>> GetEmployeeByCounterId(int counterId);

    public Task<Employee> UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword);
    public Task<string> UpdateStatusEmployeeAccount(Guid uid);
    public Task<string> DeleteEmployeeAccount(Guid uid);
    public Task<string> UpdateInformationEmployee(UpdateInformationViewModel updateInformationEmployeeViewModel);
    public Task<string> ResetPasswordEmployee(Guid employeeId, ClaimsPrincipal user);

}