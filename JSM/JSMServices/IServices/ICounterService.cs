using DataLayer.Entities;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.EmployeeViewModel;

namespace JSMServices.IServices;

public interface ICounterService
{
    public Task<ICollection<Counter>> GetAllCounters();
    Task<Counter> AddNewCounter(AddNewCounterViewModel addNewCounterViewModel);
    public Task<Counter> GetCounterById(int counterId);
    public Task AssignCounterToEmployee(AssignCounterToViewModel assignCounterToViewModel, Guid employeeId);
}