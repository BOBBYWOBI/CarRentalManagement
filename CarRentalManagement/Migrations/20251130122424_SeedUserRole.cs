using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "817e5869-a0ce-4108-83a2-86d5ed96e606", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDFgmCVXD8LZqdLkrcKmqYysVKRQAaBAxTNzw9ZOlC1pg+rMfdHS9qCryZ9oBsgtkg==", null, false, "3add5ecd-0b6b-4dbc-93a5-dd7a6f5ff426", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1381), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1409), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1892), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1895), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1747), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1752), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1754), new DateTime(2025, 11, 30, 20, 24, 22, 635, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7306), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7325), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7728), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7608), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7611), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7613), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7615), new DateTime(2025, 11, 30, 20, 6, 36, 125, DateTimeKind.Local).AddTicks(7616) });
        }
    }
}
