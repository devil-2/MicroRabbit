using MicroServices.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServices.Banking.Data.Context
{
	public class BankingDbContext:DbContext
	{
		public BankingDbContext(DbContextOptions options):base(options)
		{
		}

		public DbSet<Account> Accounts { get; set; }
	}
}
