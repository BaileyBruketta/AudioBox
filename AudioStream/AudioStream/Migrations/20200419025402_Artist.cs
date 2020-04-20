using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioStream.Migrations
{
    public partial class Artist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Song");
        }
    }
}
