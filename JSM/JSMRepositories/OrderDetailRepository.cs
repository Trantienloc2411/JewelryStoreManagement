using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class OrderDetailRepository : GenericRepositories<OrderDetail>
{
    public OrderDetailRepository(JSMDbContext context) : base(context)
    {
    } 
}