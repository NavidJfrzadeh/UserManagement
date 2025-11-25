using App.Core.AdminEntity;
using App.Infra.Security;
using App.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.EFCore.Configs;

internal class AdminConfigs : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        IPasswordHasher passwordHasher = new PasswordHasher();

        builder.Property(a => a.Id).UseIdentityColumn(1, 1);
        builder.Property(a => a.UserName).IsRequired().HasMaxLength(300);
        builder.Property(a => a.Email).IsRequired().HasMaxLength(300);
        builder.Property(a => a.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
        builder.HasData(
            new Admin("navid", "navid@gmail.com", "ni2bSgiYmXE0/D7OTfP1g+IqrXZGKndFxnwxm4MFpqE=") { Id = 1, CreatedAt = new DateTime(2025, 11, 25) },
            new Admin("admin", "admin", "FYneDHnPc6gxbktrCumaF21Fn9iVrtuTg6+/74QWjtQ=") { Id = 2, CreatedAt = new DateTime(2025, 11, 25) }
            );
    }
}
