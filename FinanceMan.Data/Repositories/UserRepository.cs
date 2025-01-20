using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Data.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User entity)
    {
        await dbContext.AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }

    public IQueryable<User> GetAll() => dbContext.Users;

    public async Task<bool> UserExistsAsync(int userId) 
        => await dbContext.Users.AnyAsync(u => u.Id == userId);
}
