using DemoApp.Domain.Abstractions;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence
{
	public class UnitOfWork : IUnitiOfWork
	{
		private readonly ApplicationDbContext _context;
		public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
		}

		public Task<IDbContextTransaction> BeginTransactionAsync()
		{
			throw new NotImplementedException();
		}

		public Task SaveChangeAsunc()
		{
			throw new NotImplementedException();
		}

		public async Task SaveChangeAsync()
		{
			await _context.SaveChangesAsync();
		}



	}
}
