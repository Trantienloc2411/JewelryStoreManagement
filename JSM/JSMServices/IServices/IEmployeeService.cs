using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;

namespace JSMServices.IServices;

public interface IEmployeeService
{
    //your define interface right here
    public Task<Employee> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel);
    //public Task<Employee> LoginAccountEmployee(LoginEmployeeViewModel loginEmployeeViewModel);
    public Task<ICollection<Employee>> GetAllEmployee();
    public Employee GetEmployeeById(Guid employeeId);
    public Employee GetEmployeeByEmail(string email);


}