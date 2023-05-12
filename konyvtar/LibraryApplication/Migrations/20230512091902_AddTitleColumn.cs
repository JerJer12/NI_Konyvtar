using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApplication.Migrations
{
    public partial class AddTitleColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Borrows",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Borrows");
        }
    }
}
