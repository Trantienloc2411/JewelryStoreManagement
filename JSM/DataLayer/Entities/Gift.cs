using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Gift
    {
        public Guid GiftId { get; set; }
        [NotNull]
        [MaxLength(100)]
        public string? GiftName { get; set; }
        public int PointRequired { get; set; }
        [JsonIgnore]
        public ICollection<Transactions> Transactions { get; set; }
    }
}

