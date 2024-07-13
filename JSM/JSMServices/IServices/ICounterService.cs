using DataLayer.Entities;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.EmployeeViewModel;

namespace JSMServices.IServices;

public interface ICounterService
{
    public Task<ICollection<Counter>> GetAllCounters();
    Task<ApiResponse> AddNewCounter(AddNewCounterViewModel addNewCounterViewModel);
    public Task<Counter> GetCounterById(int counterId);
    public Task<ApiResponse> AssignCounterToEmployee(AssignCounterToViewModel assignCounterToViewModel, Guid employeeId);
}