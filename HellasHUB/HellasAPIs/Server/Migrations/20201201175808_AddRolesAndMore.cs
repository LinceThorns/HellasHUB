using Microsoft.EntityFrameworkCore.Migrations;

namespace HellasAPIs.Server.Migrations
{
    public partial class AddRolesAndMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Monies_MoneyId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Monies");

            migrationBuilder.DropColumn(
                name: "IC_Name",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SL_ID",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "SL_Name",
                table: "Characters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MoneyId",
                table: "Characters",
                newName: "OriginId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_MoneyId",
                table: "Characters",
                newName: "IX_Characters_OriginId");

            migrationBuilder.AlterColumn<int>(
                name: "Wis",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Str",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Int",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dex",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Const",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cha",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Money",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccUUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "CharRoles",
                columns: table => new
                {
                    CharRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharRoles", x => x.CharRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Origins",
                columns: table => new
                {
                    OriginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.OriginID);
                });

            migrationBuilder.CreateTable(
                name: "OwnedRoles",
                columns: table => new
                {
                    OwnedRolesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharRoleId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedRoles", x => x.OwnedRolesID);
                    table.ForeignKey(
                        name: "FK_OwnedRoles_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnedRoles_CharRoles_CharRoleId",
                        column: x => x.CharRoleId,
                        principalTable: "CharRoles",
                        principalColumn: "CharRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AccountId",
                table: "Characters",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedRoles_CharacterId",
                table: "OwnedRoles",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedRoles_CharRoleId",
                table: "OwnedRoles",
                column: "CharRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Accounts_AccountId",
                table: "Characters",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Origins_OriginId",
                table: "Characters",
                column: "OriginId",
                principalTable: "Origins",
                principalColumn: "OriginID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Accounts_AccountId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Origins_OriginId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Origins");

            migrationBuilder.DropTable(
                name: "OwnedRoles");

            migrationBuilder.DropTable(
                name: "CharRoles");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AccountId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "OriginId",
                table: "Characters",
                newName: "MoneyId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Characters",
                newName: "SL_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_OriginId",
                table: "Characters",
                newName: "IX_Characters_MoneyId");

            migrationBuilder.AlterColumn<string>(
                name: "Wis",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Str",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Int",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Dex",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Const",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Cha",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IC_Name",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SL_ID",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Monies",
                columns: table => new
                {
                    MoneyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monies", x => x.MoneyID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Monies_MoneyId",
                table: "Characters",
                column: "MoneyId",
                principalTable: "Monies",
                principalColumn: "MoneyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
