using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServices.Transfer.Data.Migrations
{
    public partial class InitialMigrationChangedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog");

            migrationBuilder.RenameTable(
                name: "TransferLog",
                newName: "TransferLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs");

            migrationBuilder.RenameTable(
                name: "TransferLogs",
                newName: "TransferLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog",
                column: "Id");
        }
    }
}
