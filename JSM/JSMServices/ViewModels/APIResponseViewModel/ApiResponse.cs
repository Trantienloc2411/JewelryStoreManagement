namespace JSMServices.ViewModels.APIResponseViewModel;

public class ApiResponse
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public ICollection<object>? Data { get; set; }
}