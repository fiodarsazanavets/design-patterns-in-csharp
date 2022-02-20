namespace Facade_Demo;

internal class AccountDataService
{
    private List<Account> accounts;

    public AccountDataService()
    {
        accounts = new();
        accounts.Add(new Account(1, "John Smith"));
        accounts.Add(new Account(2, "Jane Doe"));
        accounts.Add(new Account(3, "Laurence Newport"));
        accounts.Add(new Account(4, "David Fisher"));
    }

    public List<Account> GetAccounts()
    {
        return accounts;
    }
}

internal record Account
{
    public Account(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}