using System.ComponentModel.Design;
using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMRepositories;
using JSMServices.IServices;
using Microsoft.EntityFrameworkCore;
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
    
    public async Task<Employee> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel)
    {
        try
        {
            var existedEmployeeList =  _employeeRepository.GetAll();
            var employee = new Employee();

            if (existedEmployeeList.FirstOrDefault(e => e.Email.Equals(registerEmployeeViewModel.Email)) != null)
            {
                throw new Exception($"Email '{registerEmployeeViewModel.Email}' is already registered. Please use another email.");
            }
            else if (existedEmployeeList.FirstOrDefault(e => e.Phone.Equals(registerEmployeeViewModel.Phone)) != null)
            {
                throw new Exception($"Phone number '{registerEmployeeViewModel.Phone}' is already registered. Please use another phone number.");
            }
            else
            {
                _mapper.Map(registerEmployeeViewModel, employee);
                employee.EmployeeId = new Guid();
                employee.isLogin = false;
                employee.Password = GenerateRandomString(8);
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
    


        private static Random random = new Random();

        public static string GenerateRandomString(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=[]{}|\\;:,.<>/?";
            var chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }
            return new string(chars);
        }
     /*   
    public async Task<Employee> LoginAccountEmployee(LoginEmployeeViewModel loginEmployeeViewModel)
    {
        try
        {
            var existedEmployee = await _employeeRepository.GetSingleWithAsync(e => e.Email.Equals(loginEmployeeViewModel.Email));
    
            if (existedEmployee == null)
            {
                throw new Exception("This account is not existed in the system.");
            }
            else
            {
                // Verify the password
                if (loginEmployeeViewModel.Password != existedEmployee.Password)
                {
                    throw new Exception("Invalid email or password.");
                }
    
                return existedEmployee;
            }
        }
        catch (Exception ex)
        {
            
            throw new Exception($"An error occurred during the login process: {ex.Message}");
        }
    }
    */
    
    public async Task<ICollection<Employee>> GetAllEmployee()
    {
        try
        {
            var listUser = await _employeeRepository.GetAllWithAsync();
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
}