using System.Collections.Generic;
using MicroServices.Banking.Application.Interfaces;
using MicroServices.Banking.Domain.Interfaces;
using MicroServices.Banking.Domain.Models;

namespace MicroServices.Banking.Application.Services
{
	public class AccountService : IAccountService
	{
		private readonly IAccountRepository _accountRepository;

		public AccountService(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}
		public IEnumerable<Account> GetAccounts()
		{
			return _accountRepository.GetAccounts();
		}
	}
}
