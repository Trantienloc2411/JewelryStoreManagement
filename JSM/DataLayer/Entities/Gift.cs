using System;
namespace DataLayer.Entities
{
	public class Gift
	{
		public Guid GiftId { get; set; }
		public string? GiftName { get; set; }
		public int PointRequired { get; set; }
	}
}

