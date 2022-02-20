namespace Facade_Demo;

internal class ProductsFacade
{
    private readonly AccountCategoryService accountCategoryService;
    private readonly AccountDataService accountDataService;
    private readonly ProductsDataService productDataService;

    public ProductsFacade()
    {
        accountCategoryService = new();
        accountDataService = new();
        productDataService = new();
    }

    public List<Product> GetProductListForAccount(string name)
    {
        var accountId = accountDataService
                        .GetAccounts()
                        .Where(a => a.Name == name)
                        .Select(a => a.Id)
                        .FirstOrDefault();

        if (accountId == default)
            return new List<Product>();

        var accountCategory = accountCategoryService.GetCategory(accountId);

        return productDataService.GetProductsForCategory((int)accountCategory);
    }
}