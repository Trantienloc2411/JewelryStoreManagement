using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMRepositories;
using JSMServices.IServices;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System.Security.Claims;


#pragma warning disable
namespace JSMServices.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    public EmployeeService(EmployeeRepository employeeRepository, IMapper mapper, IConfiguration configuration)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _configuration = configuration;
    }

    #region AddAccountEmployee
    public async Task<string> AddAccountEmployee(RegisterEmployeeViewModel registerEmployeeViewModel, ClaimsPrincipal user)
    {
        try
        {
            var existedEmployeeList = _employeeRepository.GetAll();
            var employee = new Employee();

            if (existedEmployeeList.FirstOrDefault(e => e.Email.Equals(registerEmployeeViewModel.Email)) != null)
            {
                // employee.Email = registerEmployeeViewModel.Email;
                // return employee;
                return $"Email '{registerEmployeeViewModel.Email}' is already registered. Please use another email.";
            }
            else if (existedEmployeeList.FirstOrDefault(e => e.Phone.Equals(registerEmployeeViewModel.Phone)) != null)
            {
                // employee.Phone = registerEmployeeViewModel.Phone;
                // return employee;
                return $"Phone number '{registerEmployeeViewModel.Phone}' is already registered. Please use another phone number.";
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
                    return "You dont have permission to do this action";
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
                    SendEmail(employee.Email, employee.Name, employee.Password);
                    return "";
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
    #endregion

    #region Generate Random String
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
    #endregion

    #region GetAllEmployee
    public async Task<ICollection<Employee>> GetAllEmployee()
    {
        try
        {
            var listUser = await _employeeRepository.GetAllWithIncludeAsync(e => true, e => e.Counter);
            listUser = listUser.Where(c => c.EmployeeStatus != Employee.EmployeeStatuses.Deleted).ToList();
            return listUser;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }

    }
    #endregion

    #region GetEmployeeById
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
    #endregion

    public async Task<Employee> GetEmployeeByEmail(string email)
    {
        try
        {
            var employee = await _employeeRepository.GetSingleWithIncludeAsync(c => c.Email.ToUpper() == email.ToUpper(), e => e.Counter);
            return employee;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }



    public async Task<Employee> UpdatePasswordEmployeeAccount(string email, string oldPassword, string newPassword)
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
                    account.Password = "";
                    return account;
                }
                else
                {
                    account.Password = newPassword;
                    account.IsLogin = true;
                    await _employeeRepository.UpdateWithAsync(account);
                    return account;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public async Task<string> UpdateStatusEmployeeAccount(Guid uid)
    {
        try
        {
            var account = _employeeRepository.Get(c => c.EmployeeId.Equals(uid));
            if (account.Name == null || account.Name.Length == 0)
            {
                return "Something went wrong! Everything changes will not saving!";
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
            return "";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<string> DeleteEmployeeAccount(Guid uid)
    {
        try
        {
            var account = _employeeRepository.GetAll().FirstOrDefault(c => c.EmployeeId == uid);
            if (account == null)
            {
                return "This account is not exist or was deleted";
            }
            else
            {
                account.EmployeeStatus = Employee.EmployeeStatuses.Deleted;
                await _employeeRepository.SaveChangesAsync();
                return "";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public async Task<string> UpdateInformationEmployee(UpdateInformationViewModel updateInformationEmployeeViewModel)
    {
        try
        {
            var employee = _employeeRepository.GetAll()
                .FirstOrDefault(c => c.EmployeeId == updateInformationEmployeeViewModel.EmployeeId);

            if (employee == null)
            {
                return "Update not successful! Employee not found. Please reload the page.";
            }

            if (employee.EmployeeStatus == Employee.EmployeeStatuses.Deleted)
            {
                return "This account does not exist or has been deleted!";
            }

            // Check for existing email only if it has changed
            if (!string.Equals(employee.Email, updateInformationEmployeeViewModel.Email, StringComparison.OrdinalIgnoreCase))
            {
                var existingEmailEmployee = _employeeRepository.GetAll()
                    .FirstOrDefault(c => c.Email.Equals(updateInformationEmployeeViewModel.Email, StringComparison.OrdinalIgnoreCase)
                                         && c.EmployeeId != employee.EmployeeId);

                if (existingEmailEmployee != null)
                {
                    return "Email is already in use by another account";
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
                    return "Phone number is already in use by another account";
                }
            }

            // Update the employee
            var updatedEmployee = _mapper.Map(updateInformationEmployeeViewModel, employee);
            await _employeeRepository.UpdateWithAsync(updatedEmployee);
            return "";

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<string> ResetPasswordEmployee(Guid employeeId, ClaimsPrincipal user)
    {
        try
        {
            string roleUpdater = user.FindFirst("RoleId").Value;
            int roleUpdaterConvert = int.Parse(roleUpdater);

            if (roleUpdaterConvert <= 3)
            {
                return "You don't have any permission to do this action";
            }
            else
            {
                var employee = await _employeeRepository.GetSingleWithAsync(c => c.EmployeeId == employeeId);
                if (employee.EmployeeStatus == Employee.EmployeeStatuses.Deleted)
                {
                    return "This employee was deleted or not existed in our system";
                }
                else
                {
                    employee.IsLogin = false;
                    employee.Password = GenerateRandomString(8);
                    _employeeRepository.UpdateWithAsync(employee);
                    _employeeRepository.SaveChanges();
                    SendEmail(employee.Email, employee.Name, employee.Password);
                    return "";
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    //this will setup config to send email
    private void SendEmail(string emailTo, string username, string key)
    {

        try
        {
            string body =
                "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n    <style>\r\n        table, th, td{\r\n            border: 1px solid  ;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <h3>Hi,  " +
                username +
                "</h3>\r\nHere is the information using for login into our system.\r\n\r\n<table>\r\n    <tr>\r\n        <th>Email</th>\r\n        <th>Password</th>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n           " +
                emailTo + "\r\n        </th>\r\n        <th>\r\n            " + key +
                "\r\n        </th>\r\n    </tr>\r\n</table>\r\n</body>\r\n</html>";
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_configuration.GetSection("EmailUserName").Value));
            email.To.Add(MailboxAddress.Parse(emailTo));
            email.Subject = "Account use for login into JSS system";
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = body
            };


            using (var smtp = new SmtpClient())
            {
                smtp.Connect(_configuration.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(_configuration.GetSection("EmailUserName").Value,
                    _configuration.GetSection("EmailPassword").Value);
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public async Task<ICollection<Employee>> GetEmployeeByCounterId(int counterId)
    {
        try
        {
            var listEmployee = _employeeRepository.GetAll();
            var filteredEmployee = listEmployee.
                Where(c => c.CounterId.Equals(counterId))
                .ToList();
            if (!filteredEmployee.Any())
            {
                throw new Exception("The Employee does not existed or was deleted");
            }
            return filteredEmployee;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }


}
