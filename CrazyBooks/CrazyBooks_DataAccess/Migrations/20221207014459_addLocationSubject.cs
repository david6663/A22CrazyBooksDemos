using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrazyBooks_Web.Migrations
{
    public partial class addLocationSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Subject");
        }
    }
}
