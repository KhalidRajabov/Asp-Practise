using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class eventteachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_TeacherId",
                table: "Events",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_TeacherId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Events");


             }
    }
}
