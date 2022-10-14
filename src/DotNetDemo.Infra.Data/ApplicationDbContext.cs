using DotNetDemo.Domain.Interfaces;
using DotNetDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetDemo.Infra.Data;

public class ApplicationDbContext : DbContext, IUnityOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public async Task<bool> Commit()
    {

        await Database.BeginTransactionAsync();
        var expectedChangeCount = ChangeTracker.Entries().Count();
        var actualChangeCount = await SaveChangesAsync();
        
        if (actualChangeCount == expectedChangeCount)
        {
            await Database.CommitTransactionAsync();
            return true;
        }

        await Database.RollbackTransactionAsync();

        throw new DbUpdateException($"One or more updates don't was applied. Expected {expectedChangeCount} of {actualChangeCount}");

    }
}