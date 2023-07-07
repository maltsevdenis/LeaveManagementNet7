using LeaveManagement.Web.Constants;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = "7e3c62b6-4e83-4a13-834d-c5b0adf30c71",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "6699c205-39b2-4510-87bb-822c51f8fc41",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
            );


        }
    }
}