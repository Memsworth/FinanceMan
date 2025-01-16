using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;

namespace FinanceMan.Data.Repositories;

public class AccountRepository(ApplicationDbContext dbContext) : IAccountRepository
{
    public void Add(Account entity)
    {
        throw new NotImplementedException();
    }
}
