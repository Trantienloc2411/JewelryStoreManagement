using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class EmployeeRepository : GenericRepositories<Employee>
{
    public EmployeeRepository(JSMDbContext context) : base(context)
    {
       
    }
}