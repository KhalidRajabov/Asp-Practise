using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class spiekrid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Speakers_SpeakerId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "SpeakerId",
                table: "Events",
                newName: "SpeakeriD");

            migrationBuilder.RenameIndex(
                name: "IX_Events_SpeakerId",
                table: "Events",
                newName: "IX_Events_SpeakeriD");

            migrationBuilder.AlterColumn<int>(
                name: "SpeakeriD",
                table: "Events",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Speakers_SpeakeriD",
                table: "Events",
                column: "SpeakeriD",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Speakers_SpeakeriD",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "SpeakeriD",
                table: "Events",
                newName: "SpeakerId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_SpeakeriD",
                table: "Events",
                newName: "IX_Events_SpeakerId");

            migrationBuilder.AlterColumn<int>(
                name: "SpeakerId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Speakers_SpeakerId",
                table: "Events",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
