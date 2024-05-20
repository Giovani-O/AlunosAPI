using Microsoft.EntityFrameworkCore.Migrations;

namespace AlunosAPI.Migrations
{
    public partial class PopulaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Email", "Idade", "Nome" },
                values: new object[,]
                {
                    { 1, "nerevarine@gmail.com", 30, "Nerevarine" },
                    { 2, "miraak@gmail.com", 45, "Miraak" },
                    { 3, "martin@gmail.com", 32, "Martin Septim" },
                    { 4, "barenziah@gmail.com", 50, "Barenziah" },
                    { 5, "divayth@gmail.com", 4000, "Divayth Fyr" },
                    { 6, "jagar@gmail.com", 60, "Jagar Tharn" },
                    { 7, "nocturnal@gmail.com", 1000, "Nocturnal" },
                    { 8, "lucien@gmail.com", 45, "Lucien Lachance" },
                    { 9, "sheogorath@gmail.com", 1000, "Sheogorath" },
                    { 10, "almalexia@gmail.com", 3000, "Almalexia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
