namespace DotNetDemo.Domain.Models;

public class ProductCategory : Entity
{
    public string Name { get; private set; }

    public IReadOnlyCollection<Product> Products;

    // EF
    protected ProductCategory() { }
    
    public ProductCategory(string name)
    {
        Name = name;
    }
}