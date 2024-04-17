using DemoApp.Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
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

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
