using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static DataLayer.Entities.Employee;

namespace JSMServices.ViewModels.EmployeeViewModel
{
    public class ViewEmployeeByCounterId
    {
        public Guid EmployeeId { get; set; }
        [NotNull]
        [MaxLength(100)]
        public string? Name { get; set; }
        [NotNull]
        [MaxLength(150)]
        public string? Email { get; set; }
        [NotNull]
        [MaxLength(10)]
        public string? Phone { get; set; }
        [NotNull]
        public EmployeeStatuses EmployeeStatus { get; set; }
        [MaxLength(256)]
        [NotNull]
        public EmployeeGenders EmployeeGender { get; set; }
        [DefaultValue(false)]
        public bool IsLogin { get; set; }

        [AllowNull]
        public Guid ManagedBy { get; set; }
        [AllowNull]
        public int RoleId { get; set; }
    }
}
