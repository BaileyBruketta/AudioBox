using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioStream.Migrations
{
    public partial class addartistname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Song");
        }
    }
}
