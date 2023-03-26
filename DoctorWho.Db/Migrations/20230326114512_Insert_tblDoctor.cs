using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class Insert_tblDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblDoctor",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Hartnell", "1", new DateTime(1963, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1920, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick Troughton", "2", new DateTime(1966, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1919, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon Pertwee", "3", new DateTime(1970, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1934, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Baker", "4", new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1982, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodie Whittaker", "5", new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblDoctor",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblDoctor",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblDoctor",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblDoctor",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblDoctor",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
