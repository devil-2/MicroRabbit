using MicroServices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Transfer.Application.Interfaces
{
	public interface ITransferService
	{
		IEnumerable<TransferLog> GetTransferLogs();
	}
}
