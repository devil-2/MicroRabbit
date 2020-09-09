using MicroServices.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Banking.Domain.Interfaces
{
	public interface IAccountRepository
	{
		IEnumerable<Account> GetAccounts();
	}
}
