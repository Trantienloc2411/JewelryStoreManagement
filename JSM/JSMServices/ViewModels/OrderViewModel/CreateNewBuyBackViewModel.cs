
using System;
using System.Diagnostics.CodeAnalysis;
using DataLayer.Entities;

namespace JSMServices.ViewModels.BuyBackViewModel
{
	public class CreateNewBuyBackViewModel
	{
        public string OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }
        
        public CreateBuyBackViewModel BuyBack { get; set; } 

    }
}

