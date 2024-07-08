using System;
namespace JSMServices.ViewModels.BuyBackViewModel
{
	public class CreateBuyBackViewModel
	{
		public Guid ProductId { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
		public bool HaveInvoice { get; set; }
		public double ManufactureCost { get; set; }
	}
}

