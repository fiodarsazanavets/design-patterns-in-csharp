namespace Facade_Demo;

internal class AccountCategoryService
{
    private Dictionary<int, AccountCategory> accountCategories;

    public AccountCategoryService()
    {
        accountCategories = new();
        accountCategories.Add(1, AccountCategory.Buyer);
        accountCategories.Add(2, AccountCategory.Buyer);
        accountCategories.Add(3, AccountCategory.Reseller);
        accountCategories.Add(4, AccountCategory.Reseller);
    }

    public AccountCategory GetCategory(int accountId)
    {
        return accountCategories[accountId];
    }
}

internal enum AccountCategory
{
    Buyer = 1,
    Reseller = 2
}