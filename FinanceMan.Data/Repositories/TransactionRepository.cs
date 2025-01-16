using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;

namespace FinanceMan.Data.Repositories;

public class TransactionRepository(ApplicationDbContext dbContext) : ITransactionRepository
{
    public void Add(Transaction entity)
    {
        throw new NotImplementedException();
    }
}
