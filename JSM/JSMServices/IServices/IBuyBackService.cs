using DataLayer.Entities;

namespace JSMServices.IServices;

public interface IBuyBackService
{
    Task<BuyBack> CreateBuyBackOrder();
    Task PrintInvoice();
    
    
}