using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkLesson2.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_StudentId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "S_Cards");

            migrationBuilder.AddColumn<int>(
                name: "S_CardId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_S_CardId",
                table: "Students",
                column: "S_CardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_S_Cards_S_CardId",
                table: "Students",
                column: "S_CardId",
                principalTable: "S_Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_S_Cards_S_CardId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_S_CardId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "S_CardId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_StudentId",
                table: "S_Cards",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
