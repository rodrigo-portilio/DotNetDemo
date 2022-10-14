using DotNetDemo.Domain.Interfaces;
using DotNetDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetDemo.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _dbContext;
    
    public Task<bool> Commit() => _dbContext.Commit();

    public ProductRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _dbContext.Products.ToListAsync();
    }

    public async Task<Product> GetByIdAsync(Guid id)
    {
        return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public void Update(Product entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public async Task RemoveByIdAsync(Guid id)
    {
        var product = await GetByIdAsync(id);
        _dbContext.Remove(product);
    }

}