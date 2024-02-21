using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserRolesDemo.Migrations
{
    /// <inheritdoc />
    public partial class SeondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44d0cdbb-c7bb-4e00-989f-59cdc5b1bfcd", null, "client", "client" },
                    { "e7b50288-f2db-4f1d-970d-8e7ea92d7b85", null, "seller", null },
                    { "fbfa36a0-355e-468d-a1e3-4e1e4f5aa952", null, "admin", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44d0cdbb-c7bb-4e00-989f-59cdc5b1bfcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b50288-f2db-4f1d-970d-8e7ea92d7b85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbfa36a0-355e-468d-a1e3-4e1e4f5aa952");
        }
    }
}
