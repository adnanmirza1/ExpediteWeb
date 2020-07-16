using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpediteWeb.Migrations
{
    public partial class SignupMdelCreatede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "User",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "ID");
        }
    }
}
