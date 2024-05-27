using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class OrderRepository : GenericRepositories<Order>
{
    public OrderRepository(JSMDbContext context) : base(context){}
}