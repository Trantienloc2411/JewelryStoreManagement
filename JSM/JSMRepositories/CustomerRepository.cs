using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class CustomerRepository : GenericRepositories<Customer>
{
    public CustomerRepository(JSMDbContext context) : base (context){}
}