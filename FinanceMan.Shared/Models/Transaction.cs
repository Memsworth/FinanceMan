namespace FinanceMan.Shared.Models;

public class Transaction
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public virtual Account Account { get; set; }
    public TransactionType TransactionType { get; set; }
    public decimal TransactionAmount { get; set; }
}
