using DotNetDemo.Domain.Interfaces;
using DotNetDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetDemo.Infra.Data.Tests.Repositories;

public class ProductRepositoryTest : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        
        _context = new ApplicationDbContext(options);
    }
    
    public Task<bool> Commit()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}