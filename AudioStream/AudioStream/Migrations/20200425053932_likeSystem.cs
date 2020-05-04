using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioStream.Migrations
{
    public partial class likeSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "Song",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Song",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Song",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Song",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_UserId",
                table: "Song",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_UserId1",
                table: "Song",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_User_UserId",
                table: "Song",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_User_UserId1",
                table: "Song",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_User_UserId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_User_UserId1",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_UserId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_UserId1",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Song");
        }
    }
}
