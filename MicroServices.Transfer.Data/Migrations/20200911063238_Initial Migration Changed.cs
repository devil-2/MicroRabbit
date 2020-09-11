using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServices.Transfer.Data.Migrations
{
    public partial class InitialMigrationChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "TransferLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog");

            migrationBuilder.RenameTable(
                name: "TransferLog",
                newName: "Accounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");
        }
    }
}
