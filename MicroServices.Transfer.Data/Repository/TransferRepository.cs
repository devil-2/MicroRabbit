using MicroServices.Transfer.Data.Context;
using MicroServices.Transfer.Domain.Interfaces;
using MicroServices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServices.Transfer.Data.Repository
{
	public class TransferRepository : ITransferRepository
	{
		private readonly TransferDbContext _ctx;
		public TransferRepository(TransferDbContext ctx)
		{
			_ctx = ctx;
		}

		public int Add(TransferLog transferLog)
		{
			_ctx.TransferLogs.Add(transferLog);
			return _ctx.SaveChanges();
		}

		public IEnumerable<TransferLog> GetTransferLogs()
		{
			return _ctx.TransferLogs;
		}
	}
}
