
using System;
using DataLayer.Entities;

namespace JSMServices.ViewModels.BuyBackViewModel
{
	public class CreateNewBuyBackViewModel
	{
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime OrderDate { get; set;}
        public DataLayer.Entities.Order.Types Type = DataLayer.Entities.Order.Types.BuyBack;
        public int CounterId { get; set; }
        public DataLayer.Entities.Order.OrderStatuses OrderStatus { get; set; } = DataLayer.Entities.Order.OrderStatuses.Created;
        public int PaymentId { get; set; }

        public BuyBack? BuyBack { get; set; }
        

    }
}

