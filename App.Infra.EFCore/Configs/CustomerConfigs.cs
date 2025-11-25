using App.Core.CustomerEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.EFCore.Configs;

public class CustomerConfigs : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(c => c.Id).UseIdentityColumn(10, 1);
        builder.Property(c => c.FullName).IsRequired().HasMaxLength(300);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(300);
        builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
        builder.HasData(
            new Customer("hasan", "hasan@gmail.com") { Id = 10, CreatedAt = new DateTime(2025, 11, 25) },
            new Customer("amir", "amir@gmail.com") { Id = 11, CreatedAt = new DateTime(2025, 11, 25) },
            new Customer("ali", "ali@gmail.com") { Id = 12, CreatedAt = new DateTime(2025, 11, 25) },
            new Customer("parsa", "parsa@gmail.com") { Id = 13, CreatedAt = new DateTime(2025, 11, 25) },
            new Customer("babak", "babak@gmail.com") { Id = 14, CreatedAt = new DateTime(2025, 11, 25) },
            new Customer("sara", "sara@gmail.com") { Id = 15, CreatedAt = new DateTime(2025, 11, 25) }
            );
    }
}
