using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class TeacherMistakeFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Teacher",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Teacher");
        }
    }
}
