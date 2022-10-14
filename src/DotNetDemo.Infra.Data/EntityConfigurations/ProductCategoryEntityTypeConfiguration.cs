using DotNetDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetDemo.Infra.Data.EntityConfigurations;

public class ProductCategoryEntityTypeConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");
        builder.HasKey(pc => pc.Id);

        builder.Property(pc => pc.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}