using Ardalis.Result;
using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Models;

namespace FinanceMan.Server.Services;

public class TransactionService(ITransactionRepository transactionRepository, IUserRepository userRepository)
{
    public async Task<Result> GetTransaction()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<Transaction>>> GetAllUserTransactions(int userId)
    {
        //NOTE: Should this even be here?
        var isUser = await userRepository.UserExistsAsync(userId);
        if (!isUser)
            return Result.NotFound();
        
        var transactions = await transactionRepository.GetAllByUserIdAsync(userId);
        return Result.Success(transactions);
    }
}
