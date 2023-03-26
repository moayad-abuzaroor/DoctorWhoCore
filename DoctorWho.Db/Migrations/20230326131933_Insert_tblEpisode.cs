using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class Insert_tblEpisode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblEpisode",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 1, "An Unearthly Child (An Unearthly Child - Part One)" },
                    { 2, 1, 1, new DateTime(1963, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 1, "The Cave of Skulls (An Unearthly Child - Part Two)" },
                    { 3, 2, 2, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 2, "The Timeless Children" },
                    { 4, 2, 2, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 2, "Ascension of the Cybermen" },
                    { 5, 2, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 3, "Revolution of the Daleks" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblEpisode",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblEpisode",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblEpisode",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblEpisode",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblEpisode",
                keyColumn: "EpisodeId",
                keyValue: 5);
        }
    }
}
