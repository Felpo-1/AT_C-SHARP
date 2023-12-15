using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT_C__Felipe.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "artista",
                table: "Carta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "artista",
                table: "Carta");
        }
    }
}
