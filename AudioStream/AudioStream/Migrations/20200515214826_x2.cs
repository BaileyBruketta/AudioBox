using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioStream.Migrations
{
    public partial class x2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UserId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "Song",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SongId2",
                table: "Song",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_SongId",
                table: "Song",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_SongId2",
                table: "Song",
                column: "SongId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_User_SongId",
                table: "Song",
                column: "SongId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_User_SongId2",
                table: "Song",
                column: "SongId2",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_User_SongId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_User_SongId2",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_SongId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_SongId2",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "SongId2",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Song",
                type: "int",
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
    }
}
