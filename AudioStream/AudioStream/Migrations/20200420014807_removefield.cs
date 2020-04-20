using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioStream.Migrations
{
    public partial class removefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PathVal",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathVal",
                table: "Song");
        }
    }
}
