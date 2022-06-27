using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class spiekr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpeakerId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_SpeakerId",
                table: "Events",
                column: "SpeakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Speakers_SpeakerId",
                table: "Events",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Speakers_SpeakerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SpeakerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SpeakerId",
                table: "Events");
        }
    }
}
