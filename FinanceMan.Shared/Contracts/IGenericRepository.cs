namespace FinanceMan.Shared.Contracts;

public interface IGenericRepository<T>
{
    Task AddAsync(T entity);
    IQueryable<T> GetAll();
}
