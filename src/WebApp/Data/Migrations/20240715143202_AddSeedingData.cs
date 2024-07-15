using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Genre", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Genre1", 20m, new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book1" },
                    { 2, "Genre2", 30m, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
