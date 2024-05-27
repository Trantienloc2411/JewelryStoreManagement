using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class CustomerPolicyRepository : GenericRepositories<CustomerPolicy>

{
    public CustomerPolicyRepository(JSMDbContext context) : base (context){}
}