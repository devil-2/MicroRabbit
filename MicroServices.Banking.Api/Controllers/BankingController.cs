using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServices.Banking.Application.Interfaces;
using MicroServices.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Banking.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BankingController : ControllerBase
	{
		private readonly IAccountService _accountService;

		public BankingController(IAccountService accountService )
		{
			_accountService = accountService;
		}

		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<Account>> Get()
		{
			return Ok(_accountService.GetAccounts());
		}

		//// GET api/values/5
		//[HttpGet("{id}")]
		//public ActionResult<string> Get(int id)
		//{
		//	return "value";
		//}

		//// POST api/values
		//[HttpPost]
		//public void Post([FromBody] string value)
		//{
		//}

		//// PUT api/values/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//// DELETE api/values/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
