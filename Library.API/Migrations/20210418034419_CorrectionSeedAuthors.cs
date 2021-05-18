using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class CorrectionSeedAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Axel", "Rauschmayer" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Eric", "Elliott" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Nicholas C", "Zakas" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kyle", "Simpson" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Richard E", "Silverman" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Glenn", "Block" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marijn", "Haverbeke" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Axel", "Rauschmayer" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Eric", "Elliott" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Nicholas C", "Zakas" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kyle", "Simpson" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Richard E", "Silverman" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "LastName", "NationalityId" },
                values: new object[] { 9, "Glenn", "Block", 1 });
        }
    }
}
