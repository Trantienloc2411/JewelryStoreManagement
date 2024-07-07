namespace JSMServices.ViewModels.WarrantyViewModel;

public class CreateWarrantyViewModel
{
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; }
    public string OrderDetailId { get; set; }
}