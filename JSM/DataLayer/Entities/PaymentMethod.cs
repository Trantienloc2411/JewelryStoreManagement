using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataLayer.Entities;
#pragma warning disable
public class PaymentMethod
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PaymentId { get; set; }
    public string PaymentType { get; set; }
    [JsonIgnore]
    
    public virtual ICollection<Order> Orders { get; set; }
}