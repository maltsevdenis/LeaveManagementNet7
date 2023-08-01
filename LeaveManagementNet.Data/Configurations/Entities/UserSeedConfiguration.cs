using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities;

public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var hasher = new PasswordHasher<Employee>();

        builder.HasData(
            new Employee
            {
                Id = "f603546f-0cca-46a4-88de-477c06fa33ea",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                Firstname = "System",
                Lastname = "Admin",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },
            new Employee
            {
                Id = "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                NormalizedUserName = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                Firstname = "System",
                Lastname = "User",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
            );
    }
}