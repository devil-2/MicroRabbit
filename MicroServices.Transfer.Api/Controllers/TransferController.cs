using System.Collections.Generic;
using MicroServices.Transfer.Application.Interfaces;
using MicroServices.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Transfer.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransferController : ControllerBase
	{
		private readonly ITransferService _transferRepository;
		public TransferController(ITransferService transferRepository)
		{
			_transferRepository = transferRepository;
		}
		// GET api/transfer
		[HttpGet]
		public ActionResult<IEnumerable<TransferLog>> Get()
		{
			return Ok(_transferRepository.GetTransferLogs());
		}

		
	}
}
