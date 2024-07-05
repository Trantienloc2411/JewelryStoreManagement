using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMRepositories;
using JSMServices.IServices;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


#pragma warning disable
namespace JSMServices.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeService(EmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }


    public async Task<Employee> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel, ClaimsPrincipal user)
    {
        try
        {
            var existedEmployeeList = _employeeRepository.GetAll();
            var employee = new Employee();

            if (existedEmployeeList.FirstOrDefault(e => e.Email.Equals(registerEmployeeViewModel.Email)) != null)
            {
                // employee.Email = registerEmployeeViewModel.Email;
                // return employee;
                throw new Exception($"Email '{registerEmployeeViewModel.Email}' is already registered. Please use another email.");
            }
            else if (existedEmployeeList.FirstOrDefault(e => e.Phone.Equals(registerEmployeeViewModel.Phone)) != null)
            {
                // employee.Phone = registerEmployeeViewModel.Phone;
                // return employee;
                throw new Exception($"Phone number '{registerEmployeeViewModel.Phone}' is already registered. Please use another phone number.");
            }
            else
            {
                _mapper.Map(registerEmployeeViewModel, employee);
                employee.EmployeeId = new Guid();
                employee.IsLogin = false;
                employee.Password = GenerateRandomString(8);
                string roleCurrent = user.FindFirst("Role").Value;
                int roleWhoCreated = Int32.Parse(roleCurrent);
                if (roleWhoCreated == 1)
                {
                    throw new Exception("You dont have permission to do this action");
                }
                else if (roleWhoCreated == 2)
                {
                    employee.RoleId = 1;
                }
                else if (roleWhoCreated == 3)
                {
                    employee.RoleId = 2;
                }
                var guidCreated =
                employee.ManagedBy = Guid.Parse(user.FindFirst("EmployeeId").Value.ToString());
                var entityEntry = await _employeeRepository.AddSingleWithAsync(employee);

                if (entityEntry.State == EntityState.Added)
                {
                    await _employeeRepository.SaveChangesAsync();
                    return employee;
                }
            }
        }
        catch (Exception ex)
        {
            // Log the exception or handle it in some other way
            throw new Exception($"An error occurred while adding the employee: {ex.Message}");
        }

        // If we reach this point, something went wrong during the add operation
        throw new Exception("An error occurred while adding the employee.");
    }



    private static Random _random = new Random();

    private static string GenerateRandomString(int length)
    {
        const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=[]{}|\\;:,.<>/?";
        var chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = allowedChars[_random.Next(0, allowedChars.Length)];
        }
        return new string(chars);
    }


    public async Task<ICollection<Employee>> GetAllEmployee()
    {
        try
        {
            var listUser = _employeeRepository.GetAll();
            listUser = listUser.Where(c => c.EmployeeStatus != Employee.EmployeeStatuses.Deleted).ToList();
            return listUser;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }

    }

    public Employee GetEmployeeById(Guid employeeId)
    {
        try
        {
            var employeeList = _employeeRepository.GetAll();
            var employee = employeeList.FirstOrDefault(e => e.EmployeeId == employeeId);
            return employee;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public Employee GetEmployeeByEmail(string email)
    {
        try
        {
            var employeeList = _employeeRepository.GetAll();
            var employee = employeeList.FirstOrDefault(c => c.Email == email);
            return employee;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword)
    {
        try
        {
            var account = _employeeRepository.GetAll().FirstOrDefault(c => c.Email == email);
            if (account == null)
            {
                throw new Exception("Something unexpected error happen! Please re-login again");
            }
            else
            {
                if (account.Password != oldPassword)
                {
                    throw new Exception("Old password is wrong! Please re-enter again!");
                }
                else
                {
                    account.Password = newPassword;
                    account.IsLogin = true;
                    await _employeeRepository.UpdateWithAsync(account);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public async Task UpdateStatusEmployeeAccount(Guid uid)
    {
        try
        {
            var account = _employeeRepository.Get(c => c.EmployeeId.Equals(uid));
            if (account.Name == null || account.Name.Length == 0)
            {
                throw new Exception("Something went wrong! Everything changes will not saving!");
            }
            else
            {
                account.EmployeeStatus = account.EmployeeStatus switch
                {
                    Employee.EmployeeStatuses.Active => Employee.EmployeeStatuses.Inactive,
                    Employee.EmployeeStatuses.Inactive => Employee.EmployeeStatuses.Active,
                    _ => throw new Exception("This account is not existed or was deleted!")
                };

                await _employeeRepository.SaveChangesAsync();
            }
            await _employeeRepository.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteEmployeeAccount(Guid uid)
    {
        try
        {
            var account = _employeeRepository.GetAll().FirstOrDefault(c => c.EmployeeId == uid);
            if (account == null)
            {
                throw new Exception("This account is not exist or was deleted");
            }
            else
            {
                account.EmployeeStatus = Employee.EmployeeStatuses.Deleted;
                await _employeeRepository.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task UpdateInformationEmployee(UpdateInformationViewModel updateInformationEmployeeViewModel)
    {
        try
        {
            var employee = _employeeRepository.GetAll()
                .FirstOrDefault(c => c.EmployeeId == updateInformationEmployeeViewModel.EmployeeId);

            if (employee == null)
            {
                throw new Exception("Update not successful! Employee not found. Please reload the page.");
            }

            if (employee.EmployeeStatus == Employee.EmployeeStatuses.Deleted)
            {
                throw new Exception("This account does not exist or has been deleted!");
            }

            // Check for existing email only if it has changed
            if (!string.Equals(employee.Email, updateInformationEmployeeViewModel.Email, StringComparison.OrdinalIgnoreCase))
            {
                var existingEmailEmployee = _employeeRepository.GetAll()
                    .FirstOrDefault(c => c.Email.Equals(updateInformationEmployeeViewModel.Email, StringComparison.OrdinalIgnoreCase)
                                         && c.EmployeeId != employee.EmployeeId);

                if (existingEmailEmployee != null)
                {
                    throw new Exception("Email is already in use by another account");
                }
            }

            // Check for existing phone only if it has changed
            if (employee.Phone != updateInformationEmployeeViewModel.Phone)
            {
                var existingPhoneEmployee = _employeeRepository.GetAll()
                    .FirstOrDefault(c => c.Phone == updateInformationEmployeeViewModel.Phone
                                         && c.EmployeeId != employee.EmployeeId);

                if (existingPhoneEmployee != null)
                {
                    throw new Exception("Phone number is already in use by another account");
                }
            }

            // Update the employee
            var updatedEmployee = _mapper.Map(updateInformationEmployeeViewModel, employee);
            await _employeeRepository.UpdateWithAsync(updatedEmployee);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}