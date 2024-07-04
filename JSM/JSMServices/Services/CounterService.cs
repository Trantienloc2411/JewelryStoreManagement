using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.EmployeeViewModel;
using Microsoft.EntityFrameworkCore;

namespace JSMServices.Services;

public class CounterService : ICounterService
{
    private readonly CounterRepository _counterRepository;
    private readonly EmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    public CounterService(CounterRepository counterRepository, EmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _counterRepository = counterRepository;
        _mapper = mapper;
    }

    public async Task<Counter> AddNewCounter(AddNewCounterViewModel addNewCounterViewModel)
    {
        try
        {
            var existedCounterList = _counterRepository.GetAll();
            var counter = new Counter();
            if (existedCounterList.FirstOrDefault(e => e.CounterName.Equals(addNewCounterViewModel.CounterName)) != null)
            {
                throw new Exception($"CounterName '{addNewCounterViewModel.CounterName}' " +
                    $"is already existed. Please use another Name.");
            }
            _mapper.Map(addNewCounterViewModel, counter);
            counter.CounterId = new int();
            var entityEntry = await _counterRepository.AddSingleWithAsync(counter);
            if (entityEntry.State == EntityState.Added)
            {
                await _counterRepository.SaveChangesAsync();
                return counter;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while adding the counter: {ex.Message}");
        }
        throw new Exception("An error occurred while adding the counter.");
    }

    public async Task AssignCounterToEmployee(AssignCounterToViewModel assignCounterToViewModel, Guid employeeId)
    {
        try
        {
            var getlistEmployee = _employeeRepository.GetAll();
            var getlistCounter = _counterRepository.GetAll().FirstOrDefault(c => c.CounterId.Equals(assignCounterToViewModel.CounterId));
            var employeeUpdate = getlistEmployee.FirstOrDefault(e => e.EmployeeId.Equals(employeeId));
            if (employeeUpdate == null)
            {
                throw new Exception("Assign not successfully! Reload Page again!");
            }
            if (getlistCounter == null)
            {
                throw new Exception("The CounterId does not existed or was deleted!");
            }
            else
            {
                if (employeeUpdate.EmployeeStatus == Employee.EmployeeStatuses.Deleted)
                {
                    throw new Exception("The Employee does not existed or was deleted!");
                }
                var employeeUpdated = _mapper.Map(assignCounterToViewModel, employeeUpdate);
                await _employeeRepository.UpdateWithAsync(employeeUpdated);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }

    public async Task<Counter> GetCounterById(int counterId)
    {
        try
        {
            var listCounter = await _counterRepository.GetSingleWithAsync(i => i.CounterId.Equals(counterId));
            if (listCounter == null)
            {
                throw new Exception("The counter does not exist or was deleted");
            }
            return listCounter;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}