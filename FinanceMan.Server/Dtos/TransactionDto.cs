using FinanceMan.Shared.Models;

namespace FinanceMan.Server.Dtos;

public class TransactionDto
{
    
}

public static class TransactionDtoExtensions
{ 
    public static TransactionDto ToDto(this Transaction transaction) => new TransactionDto();
}