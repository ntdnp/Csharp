namespace FirstDemo.RepositoriesUOW
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
