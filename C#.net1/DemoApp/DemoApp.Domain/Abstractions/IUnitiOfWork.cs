using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Abstractions
{
	public interface IUnitiOfWork
	{
		Task SaveChangeAsunc();
		Task<IDbContextTransaction> BeginTransactionAsync();
	}
}
