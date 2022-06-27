using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class speakerimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Speaker2Image",
                table: "Speakers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpeakerImage",
                table: "Speakers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker2Image",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "SpeakerImage",
                table: "Speakers");
        }
    }
}
