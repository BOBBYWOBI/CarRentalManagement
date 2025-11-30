using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9684), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9686), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9687), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 19, 44, 26, 545, DateTimeKind.Local).AddTicks(70), new DateTime(2025, 11, 30, 19, 44, 26, 545, DateTimeKind.Local).AddTicks(70), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 19, 44, 26, 545, DateTimeKind.Local).AddTicks(72), new DateTime(2025, 11, 30, 19, 44, 26, 545, DateTimeKind.Local).AddTicks(73), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9890), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9890), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9892), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9893), "xX", "System" },
                    { 3, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9894), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9894), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9895), new DateTime(2025, 11, 30, 19, 44, 26, 544, DateTimeKind.Local).AddTicks(9896), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
