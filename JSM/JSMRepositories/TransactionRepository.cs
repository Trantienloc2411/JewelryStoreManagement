using System;
using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories
{
	public class TransactionRepository : GenericRepositories<Transactions>
	{
		public TransactionRepository(JSMDbContext context) : base(context)
		{
		}
	}
}

