using System;
using DataLayer.Entities;

namespace JSMServices.IServices
{
	public interface ITransactionService
	{
        Task<string> ExchangeGiftUser(Guid customerId, Guid giftId);
        Task<ICollection<Transactions>> GetAllTransactions();
        Task<Transactions> GetTransactionsByTransactionId(Guid transactionId);
        Task<ICollection<Transactions>> GetTransactionsByCustomerId(Guid customerId);
    }
}

