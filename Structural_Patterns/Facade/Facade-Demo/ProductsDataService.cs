namespace Facade_Demo;

internal class ProductsDataService
{
    private readonly Dictionary<int, List<Product>> productLists;

    public ProductsDataService()
    {
        productLists = new()
        {
            [1] =
            [
                new Product("Product 1", 9.99),
                new Product("Product 2", 19.99)
            ],
            [2] =
            [
                new Product("Bundle 1", 99.99),
                new Product("Bundle 2", 199.99)
            ]
        };
    }

    public List<Product> GetProductsForCategory(int categoryId)
    {
        return productLists[categoryId];
    }
}

internal record Product
{
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; }
    public double Price { get; }
}