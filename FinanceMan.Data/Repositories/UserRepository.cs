using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;

namespace FinanceMan.Data.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public void Add(User entity)
    {
        throw new NotImplementedException();
    }
}
