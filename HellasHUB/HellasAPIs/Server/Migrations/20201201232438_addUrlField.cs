using Microsoft.EntityFrameworkCore.Migrations;

namespace HellasAPIs.Server.Migrations
{
    public partial class addUrlField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueURL",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueURL",
                table: "Accounts");
        }
    }
}
