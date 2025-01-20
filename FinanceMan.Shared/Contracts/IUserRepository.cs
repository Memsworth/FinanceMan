using FinanceMan.Shared.Models;

namespace FinanceMan.Shared.Contracts;

public interface IUserRepository : IGenericRepository<User>
{
    Task<bool> UserExistsAsync(int userId);
}
