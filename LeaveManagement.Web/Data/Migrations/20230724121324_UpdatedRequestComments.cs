using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1955f5cf-08fc-4f0d-b3e9-432bc309bfa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec848965-45f7-4d1a-8b33-72464398c529", "AQAAAAIAAYagAAAAEEJzbWBsDYedj0mwkn39Uu/VZsdQ+Z+FbVEJZnqfTzEuCRIWhhtV1fk0nA0oZBWFBw==", "8f1b44d2-e99b-4243-8285-867f3e4ece53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f603546f-0cca-46a4-88de-477c06fa33ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38208edc-6501-4bea-89bc-e01570512c50", "AQAAAAIAAYagAAAAELYb4IcHoubIajdDml8NxnThtAceVrXSt8Ms8e6cloYhjqIot54kuGtg9bBV9JQ08A==", "d52ec362-a148-4a4f-bd06-4d61b686e42b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
