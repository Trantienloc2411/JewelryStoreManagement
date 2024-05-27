using DataLayer.Entities;

namespace JSMServices.IServices;

public interface IRefreshHandlerService
{
    public void GenerateRefreshToken(RefreshToken refreshToken);
    public void ResetRefreshToken();
    public RefreshToken GetRefreshToken(string refreshToken);
    public RefreshToken GetRefreshTokenByEmployeeId(string employeeId);
    public void UpdateRefreshToken(RefreshToken refreshToken);
    public void RemoveAllRefreshToken();
}