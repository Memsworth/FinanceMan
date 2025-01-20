using FinanceMan.Shared.Models;

namespace FinanceMan.Shared.Contracts;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    Task<List<Transaction>> GetAllByUserIdAsync(int id);
}
