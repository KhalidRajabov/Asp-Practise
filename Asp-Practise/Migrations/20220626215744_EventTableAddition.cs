using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class EventTableAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info1",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info2",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info3",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Info2",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Info3",
                table: "Events");
        }
    }
}
