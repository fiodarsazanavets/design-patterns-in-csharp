namespace Facade_Demo;

internal class AccountDataService
{
    private readonly List<Account> accounts;

    public AccountDataService()
    {
        accounts =
        [
            new Account(1, "John Smith"),
            new Account(2, "Jane Doe"),
            new Account(3, "Laurence Newport"),
            new Account(4, "David Fisher"),
        ];
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