namespace JSMServices.ViewModels.AuthorizeViewModel;
#pragma warning disable
public class TokenViewModel
{
    public string AccessTokenToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTime ExpiredAt {  get; set; }  
}