using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Events_EventsId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_EventsId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "EventsId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventsId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_EventsId",
                table: "Teachers",
                column: "EventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Events_EventsId",
                table: "Teachers",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
