using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class Insert_tblCompanion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblCompanion",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Susan Foreman", "Carole Ann Ford" },
                    { 2, "Barbara Wright", "Jacqueline Hill" },
                    { 3, "Ian Chesterton", "William Russell" },
                    { 4, "Vicki", "Maureen O'Brien" },
                    { 5, "Steven Taylor", "Peter Purves" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblCompanion",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblCompanion",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblCompanion",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblCompanion",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblCompanion",
                keyColumn: "CompanionId",
                keyValue: 5);
        }
    }
}
