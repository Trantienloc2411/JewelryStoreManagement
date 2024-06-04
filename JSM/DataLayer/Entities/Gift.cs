using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataLayer.Entities
{
	public class Gift
	{
		public Guid GiftId { get; set; }
		[NotNull] 
		[MaxLength(100)]
		public string? GiftName { get; set; }
		public int PointRequired { get; set; }
		public ICollection<Transactions> Transactions { get; set; }
	}
}

