using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable
namespace DataLayer.Entities
{
	public class Gold
	{
		public Guid GoldId { get; set; }
		[NotNull]
		[MaxLength(100)]
		public string GoldName { get; set; }
		public double SellingPrice { get; set; }
		public double BuyingPrice { get; set; }
		public DateOnly DateUpdate { get; set; }
		public GoldContents GoldContent { get; set; }

		public enum GoldContents
		{
			ThreeNine,
			FourNine
		}

	}
}

