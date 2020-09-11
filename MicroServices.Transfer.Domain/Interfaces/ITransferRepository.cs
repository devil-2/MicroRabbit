using MicroServices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Transfer.Domain.Interfaces
{
	public interface ITransferRepository
	{
		IEnumerable<TransferLog> GetTransferLogs();

		int Add(TransferLog transferLog);
	}
}
