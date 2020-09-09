using MicroServices.Banking.Application.Models;
using MicroServices.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Banking.Application.Interfaces
{
	public interface IAccountService
	{
		IEnumerable<Account> GetAccounts();

		void Transfer(AccountTransfer accountTransfer);
	}
}
