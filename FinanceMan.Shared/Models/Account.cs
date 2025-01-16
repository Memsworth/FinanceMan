namespace FinanceMan.Shared.Models;

public class Account
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public decimal Balance { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
}
