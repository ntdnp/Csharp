using FirstDemo.Entities;

namespace FirstDemo.RepositoriesUOW
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly StudentDbContext _context;
        public UnitOfWork(StudentDbContext context) 
        {
            _context = context;

        }
        public async Task SaveChange() 
        {
            await _context.SaveChangesAsync();
        
        }

    }
}
