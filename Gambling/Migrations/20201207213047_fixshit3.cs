using Microsoft.EntityFrameworkCore.Migrations;

namespace Gambling.Migrations
{
    public partial class fixshit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestantVotes_Players_PlayerID",
                table: "ContestantVotes");

            migrationBuilder.DropIndex(
                name: "IX_ContestantVotes_PlayerID",
                table: "ContestantVotes");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerID",
                table: "ContestantVotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlayerID",
                table: "ContestantVotes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_ContestantVotes_PlayerID",
                table: "ContestantVotes",
                column: "PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestantVotes_Players_PlayerID",
                table: "ContestantVotes",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
