using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1280bbb4-cc08-4365-9cd4-2a80f1660c73", "AQAAAAIAAYagAAAAEOKWODuFbiB1sfgW8hQilnAE1c1GzQnFm2IJjYQuTuVelrKsyq9Yc2BCT250j1QnHg==", "67f0d706-2f1a-4672-a1ca-37baae6fc23e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f603546f-0cca-46a4-88de-477c06fa33ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c61bb39d-90ce-4304-9330-534f403ba3f3", "AQAAAAIAAYagAAAAEEm+hphtdRl0fYlq1FtmIuGLyB8rh2YSE3BChQlsH4r6KqmzITD3SJBg+oFqYGtfdQ==", "6fed6b37-0356-4142-b25f-18f65034cc9c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebdbd820-84ff-47af-9808-56060d75632e", "AQAAAAIAAYagAAAAEG/sEM4LErWeN3LZ1fJn8LAMPmDA+SxIk5YzDbmCZYXdiuKf+o/mUPWEYPcML2aBuw==", "57c43032-1917-4030-b230-91711f7c4bb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f603546f-0cca-46a4-88de-477c06fa33ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa9cf7fc-b4c4-40ce-b48a-777c91fae440", "AQAAAAIAAYagAAAAEBsz4N5uf8k6c7eVoIOpF/nJ1gvCcmG//FRLAQgYJOji/itB37J/YV8Tbp9AHSexDg==", "583eb3a0-63ca-45da-84ea-01c7058c4a8e" });
        }
    }
}
