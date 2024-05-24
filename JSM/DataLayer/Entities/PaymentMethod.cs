using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public class PaymentMethod
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PaymentId { get; set; }
    public string? PaymentType { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
}