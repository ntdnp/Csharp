using FirstDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstDemo.RepositoriesUOW
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StudentDbContext _context;
        public GenericRepository(StudentDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> FindAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<TEntity> FindById(TKey id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}

