namespace FinanceMan.Shared.Models;

public class Transaction
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public TransactionType TransactionType { get; set; }
    public decimal TransactionAmount { get; set; }
}