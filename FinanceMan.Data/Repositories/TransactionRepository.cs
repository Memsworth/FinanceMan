using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Data.Repositories;

public class TransactionRepository(ApplicationDbContext dbContext) : ITransactionRepository
{
    public Task AddAsync(Transaction entity)
    {
        throw new NotImplementedException();
    }

    //TODO: I am not sure how to write it. Should this me IQueryable in the first place? Check other repositories as well
    public IQueryable<Transaction> GetAll() => dbContext.Transactions;


    public async Task<List<Transaction>> GetAllByUserIdAsync(int id) => 
        await dbContext.Transactions.Where(x => x.UserId == id).ToListAsync();
}
