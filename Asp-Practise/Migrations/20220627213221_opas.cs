using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class opas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CourseId",
                table: "Categories",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Courses_CourseId",
                table: "Categories",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Courses_CourseId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CourseId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Categories");
        }
    }
}
