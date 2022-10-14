using DotNetDemo.Domain.Interfaces;

namespace DotNetDemo.Domain.Models;

public class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Guid ProductCategoryId { get; private set; }
    public ProductCategory ProductCategory { get; private set; }

    // EF
    protected Product() { }

    public Product(string name, string description)
    {
        Name = name;
        Description = description;
    }
}