using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Migrations
{
    public partial class UpdateAppException : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InnerException",
                table: "appexception",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "appexception",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetSite",
                table: "appexception",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InnerException",
                table: "appexception");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "appexception");

            migrationBuilder.DropColumn(
                name: "TargetSite",
                table: "appexception");
        }
    }
}
