using JSMServices.ViewModels.PaymentViewModel;
using Net.payOS.Types;

namespace JSMServices.IServices;

public interface IPaymentService
{
    Task<string> CreatePaymentLink(PaymentRequestLinkViewModel viewModel);
    Task<PaymentLinkInformation> GetOrderPayment(string orderId);

    Task<PaymentLinkInformation> CancelOrder(string orderId);


}