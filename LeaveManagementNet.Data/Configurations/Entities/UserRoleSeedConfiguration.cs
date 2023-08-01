using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities;

internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(new IdentityUserRole<string>
        {
            RoleId = "7e3c62b6-4e83-4a13-834d-c5b0adf30c71",
            UserId = "f603546f-0cca-46a4-88de-477c06fa33ea"
        },
        new IdentityUserRole<string>
        {
            RoleId = "6699c205-39b2-4510-87bb-822c51f8fc41",
            UserId = "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8"
        });
    }
}