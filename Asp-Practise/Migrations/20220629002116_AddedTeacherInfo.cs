using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class AddedTeacherInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Skype",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Skype",
                table: "Teachers");
        }
    }
}
