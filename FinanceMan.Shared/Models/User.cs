namespace FinanceMan.Shared.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public decimal Balance { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
}
