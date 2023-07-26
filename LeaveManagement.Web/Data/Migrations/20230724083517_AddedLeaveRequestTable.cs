using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b023fc0f-a633-456e-a2ab-02fe9eb1e82c", "AQAAAAIAAYagAAAAENBr5HcsRGbdbuOIGe9gNVB9IqE99Hc8rFCgSS6RAvovBznXhXgMpZZOpLMoKxqeXQ==", "d81325ba-6fc5-4b87-a383-32a4001aa239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f603546f-0cca-46a4-88de-477c06fa33ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52310ce7-08ab-45b1-b27f-f5b2c926a430", "AQAAAAIAAYagAAAAELOc1lcwZMNhUDYTMi4NhZHUvUTOS1bRwmDDe+3h+580bLqRRpoyFSYgUGkcLVYSsg==", "376e179a-25d7-45a4-9998-2442af0197cf" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
