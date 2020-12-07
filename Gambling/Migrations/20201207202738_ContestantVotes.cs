using Microsoft.EntityFrameworkCore.Migrations;

namespace Gambling.Migrations
{
    public partial class ContestantVotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestantVotes_Players_PlayerId",
                table: "ContestantVotes");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "ContestantVotes",
                newName: "PlayerID");

            migrationBuilder.RenameIndex(
                name: "IX_ContestantVotes_PlayerId",
                table: "ContestantVotes",
                newName: "IX_ContestantVotes_PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestantVotes_Players_PlayerID",
                table: "ContestantVotes",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestantVotes_Players_PlayerID",
                table: "ContestantVotes");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "ContestantVotes",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_ContestantVotes_PlayerID",
                table: "ContestantVotes",
                newName: "IX_ContestantVotes_PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestantVotes_Players_PlayerId",
                table: "ContestantVotes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
