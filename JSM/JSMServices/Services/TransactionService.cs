using System;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;

namespace JSMServices.Services
{
    public class TransactionService : ITransactionService
	{
		private readonly CustomerRepository _customerRepository;
		private readonly TransactionRepository _transactionRepository;
		private readonly GiftRepository _giftRepository;


		public TransactionService(CustomerRepository customerRepository, TransactionRepository transactionRepository,
			GiftRepository giftRepository)
		{
			_customerRepository = customerRepository;
			_giftRepository = giftRepository;
			_transactionRepository = transactionRepository;
		}

        public async Task<string> ExchangeGiftUser(Guid customerId, Guid giftId)
        {
            var customerExchangeGift = new Customer();
            var giftExchange = new Gift();
            var transaction = new Transactions();

            customerExchangeGift = await _customerRepository.GetSingleWithAsync(c => c.CustomerId == customerId);
            if (customerExchangeGift == null)
            {
                return "Customer not found";
            }
            giftExchange = await _giftRepository.GetSingleWithAsync(c => c.GiftId == giftId);
            if (giftExchange == null)
            {
                return "Gift not found";
            }

            if (customerExchangeGift.AccumulatedPoint < giftExchange.PointRequired)
            {
                return "User does not meet requirment to received this gift.";
            }
            else
            {
                customerExchangeGift.AccumulatedPoint -= giftExchange.PointRequired;
                _customerRepository.Update(customerExchangeGift);

                transaction.CustomerId = customerId;
                transaction.GiftId = giftId;
                transaction.TransactionDateTime = DateTime.Now;
                transaction.PointMinus = giftExchange.PointRequired;

                _transactionRepository.Add(transaction);
                _transactionRepository.SaveChanges();
            }
            return "";
        }

        public Task<ICollection<Transactions>> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Task<Transactions> GetTransactionsByTransactionId(Guid transactionId)
        {
            throw new NotImplementedException();
        }
    }
}

