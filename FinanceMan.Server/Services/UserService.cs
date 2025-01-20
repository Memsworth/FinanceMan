using Ardalis.Result;
using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Server.Services;

public class UserService(IUserRepository userRepository)
{
    public async Task<List<User>> GetUsersAsync() => 
        await userRepository.GetAll().ToListAsync();
}