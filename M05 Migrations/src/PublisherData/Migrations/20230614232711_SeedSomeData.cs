using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class SeedSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 1, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhoda", "Lerman" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 2, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruth", "Ozeki" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 3, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofia", "Segovia" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 4, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ursula K.", "LeGuin" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 5, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hugh", "Howey" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 6, "123 Main St", new DateTime(1956, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabelle", "Allende" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);
        }
    }
}
