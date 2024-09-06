using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasterNotes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshSessionUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshSessions",
                table: "RefreshSessions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RefreshSessions");

            migrationBuilder.RenameColumn(
                name: "RefreshToken",
                table: "RefreshSessions",
                newName: "RefreshSessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshSessions",
                table: "RefreshSessions",
                column: "RefreshSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshSessions_UserId",
                table: "RefreshSessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshSessions_Users_UserId",
                table: "RefreshSessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshSessions_Users_UserId",
                table: "RefreshSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshSessions",
                table: "RefreshSessions");

            migrationBuilder.DropIndex(
                name: "IX_RefreshSessions_UserId",
                table: "RefreshSessions");

            migrationBuilder.RenameColumn(
                name: "RefreshSessionId",
                table: "RefreshSessions",
                newName: "RefreshToken");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RefreshSessions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshSessions",
                table: "RefreshSessions",
                column: "Id");
        }
    }
}
