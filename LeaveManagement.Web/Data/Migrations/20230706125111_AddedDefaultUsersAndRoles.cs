using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6699c205-39b2-4510-87bb-822c51f8fc41", null, "User", "USER" },
                    { "7e3c62b6-4e83-4a13-834d-c5b0adf30c71", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8", 0, "ebdbd820-84ff-47af-9808-56060d75632e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEG/sEM4LErWeN3LZ1fJn8LAMPmDA+SxIk5YzDbmCZYXdiuKf+o/mUPWEYPcML2aBuw==", null, false, "57c43032-1917-4030-b230-91711f7c4bb6", null, false, "user@localhost.com" },
                    { "f603546f-0cca-46a4-88de-477c06fa33ea", 0, "fa9cf7fc-b4c4-40ce-b48a-777c91fae440", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBsz4N5uf8k6c7eVoIOpF/nJ1gvCcmG//FRLAQgYJOji/itB37J/YV8Tbp9AHSexDg==", null, false, "583eb3a0-63ca-45da-84ea-01c7058c4a8e", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6699c205-39b2-4510-87bb-822c51f8fc41", "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8" },
                    { "7e3c62b6-4e83-4a13-834d-c5b0adf30c71", "f603546f-0cca-46a4-88de-477c06fa33ea" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6699c205-39b2-4510-87bb-822c51f8fc41", "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e3c62b6-4e83-4a13-834d-c5b0adf30c71", "f603546f-0cca-46a4-88de-477c06fa33ea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6699c205-39b2-4510-87bb-822c51f8fc41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e3c62b6-4e83-4a13-834d-c5b0adf30c71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f603546f-0cca-46a4-88de-477c06fa33ea");
        }
    }
}
