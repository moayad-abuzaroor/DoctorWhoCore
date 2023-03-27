using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class spSummariseEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE spSummariseEpisodes AS
                    SELECT TOP 3 CompanionName, COUNT(CompanionName) AS NumberOfAppearence
                    FROM viewEpisodes
                    GROUP BY CompanionName
                    ORDER BY COUNT(CompanionName) DESC
                    SELECT TOP 3 EnemyName, COUNT(EnemyName) AS NumberOfAppearence
                    FROM viewEpisodes 
                    GROUP BY EnemyName
                    ORDER BY COUNT(EnemyName) DESC";

            migrationBuilder.Sql(sp);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
