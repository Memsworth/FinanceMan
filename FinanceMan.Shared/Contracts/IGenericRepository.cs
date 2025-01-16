namespace FinanceMan.Shared.Contracts;

public interface IGenericRepository<T>
{
    void Add(T entity);
}
