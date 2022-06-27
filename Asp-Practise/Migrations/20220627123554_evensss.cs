using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise.Migrations
{
    public partial class evensss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventTeacher");

            migrationBuilder.DropIndex(
                name: "IX_Events_TeacherId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTeacher_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTeacher_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_TeacherId",
                table: "Events",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTeacher_EventId",
                table: "EventTeacher",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTeacher_TeacherId",
                table: "EventTeacher",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
