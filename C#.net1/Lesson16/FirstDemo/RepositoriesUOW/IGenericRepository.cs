using FirstDemo.Entities;

namespace FirstDemo.RepositoriesUOW
{
    public interface IGenericRepository <TEntity,TKey> where TEntity : BaseEntity<TKey>
    {
        IQueryable<TEntity> FindAll();
        Task<TEntity> FindById(TKey id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
