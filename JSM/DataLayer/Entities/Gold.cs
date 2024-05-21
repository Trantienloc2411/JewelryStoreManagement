using System;
namespace DataLayer.Entities
{
	public class Gold
	{
		public Guid GoldId { get; set; }
		public string? GoldName { get; set; }
		public string? GoldType { get; set; }
		public double SellingPrice { get; set; }
		public double BuyingPrice { get; set; }
		public GoldContents GoldContent { get; set; }

		public enum GoldContents
		{
			ThreeNine,
			FourNine
		}

	}
}

