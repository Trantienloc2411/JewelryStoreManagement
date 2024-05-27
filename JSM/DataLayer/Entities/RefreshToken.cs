using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public class RefreshToken
{
    [Key]
    public Guid EmployeeId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? TokenId { get; set; }

    [Required]
    public string? RefreshTokenString { get; set; }

    [Required]
    public DateTime ExpireAt { get; set; }

    [Required]
    public ReStatuses Statuses { get; set; }
}
public enum ReStatuses
{
    Enable,
    Disable
}