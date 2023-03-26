using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class Insert_tblEnemy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblEnemy",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "It landed here way back in the 9th century. After a long; deadly battle; The Dalek was defeated. It’s casing was destroyed; the creature inside was cut into three pieces so it could never reform. Two were successfully transported away and guarded by the order of the custodians. But one piece was left behind. It stayed in Sheffield; where it was found 12 centuries later and was accidentally woken up. You would think a squiddy thing like that couldn’t get far. But turns out it could hitch a ride on humans. It built it’s own casing from spare parts and bits of it’s original outer shell.", "Daleks" },
                    { 2, "Krasko was released from prison and travelled back in time to change the past.", "Krasko" },
                    { 3, "A mythical Pictish Beast; discovered by the Doctor to be all too real…", "The Eaters of Light" },
                    { 4, "A malevolent cyborg known for ending battles by eating his enemies dead or alive. Don’t lose your head!", "Hydroflax" },
                    { 5, "A maitre d’ who can make any problem disappear. Even if he has to digest passengers himself.", "Flemming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblEnemy",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblEnemy",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblEnemy",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblEnemy",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblEnemy",
                keyColumn: "EnemyId",
                keyValue: 5);
        }
    }
}
