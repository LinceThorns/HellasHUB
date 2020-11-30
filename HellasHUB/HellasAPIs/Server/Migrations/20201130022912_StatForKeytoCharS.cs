using Microsoft.EntityFrameworkCore.Migrations;

namespace HellasAPIs.Server.Migrations
{
    public partial class StatForKeytoCharS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Monies_MoneyID",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "MoneyID",
                table: "Characters",
                newName: "MoneyId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_MoneyID",
                table: "Characters",
                newName: "IX_Characters_MoneyId");

            migrationBuilder.AddColumn<int>(
                name: "StatId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StatId",
                table: "Characters",
                column: "StatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Monies_MoneyId",
                table: "Characters",
                column: "MoneyId",
                principalTable: "Monies",
                principalColumn: "MoneyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Stats_StatId",
                table: "Characters",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "StatsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Monies_MoneyId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Stats_StatId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_StatId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "MoneyId",
                table: "Characters",
                newName: "MoneyID");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_MoneyId",
                table: "Characters",
                newName: "IX_Characters_MoneyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Monies_MoneyID",
                table: "Characters",
                column: "MoneyID",
                principalTable: "Monies",
                principalColumn: "MoneyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
