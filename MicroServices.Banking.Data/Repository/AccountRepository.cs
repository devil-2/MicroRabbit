using MicroServices.Banking.Data.Context;
using MicroServices.Banking.Domain.Interfaces;
using MicroServices.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Banking.Data.Repository
{
	public class AccountRepository : IAccountRepository
	{
		private readonly BankingDbContext _ctx;

		public AccountRepository(BankingDbContext ctx)
		{
			_ctx = ctx;
		}
		public IEnumerable<Account> GetAccounts()
		{
			return _ctx.Accounts;
		}
	}
}
