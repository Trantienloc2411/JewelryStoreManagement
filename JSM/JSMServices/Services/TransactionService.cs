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
	        try
	        {
		        var transaction = new Transactions();

		        var customerExchangeGift =
			        await _customerRepository.GetSingleWithAsync(c => c.CustomerId == customerId);
		        var giftExchange = await _giftRepository.GetSingleWithAsync(c => c.GiftId == giftId);

		        if (customerExchangeGift.AccumulatedPoint < giftExchange.PointRequired)
		        {
			        return "User does not meet requirement to received this gift.";
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
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }

        public async Task<ICollection<Transactions>> GetAllTransactions()
        {
	        try
	        {
		        return await _transactionRepository.GetAllWithAsync();
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }

        public async Task<Transactions> GetTransactionsByTransactionId(Guid transactionId)
        {
	        try
	        {
		        var transaction =
			        await _transactionRepository.GetSingleWithAsync(c => c.TransactionId == transactionId);
		        return transaction;
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }

        public async Task<ICollection<Transactions>> GetTransactionsByCustomerId(Guid customerId)
        {
	        try
	        {
		        var warranties = await _transactionRepository.GetListWithAsync(c => c.CustomerId == customerId);
		        return warranties;
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }
	}
}

