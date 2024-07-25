using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class TodoItem_User_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TodoItem",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItem_UserId",
                table: "TodoItem",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_User_UserId",
                table: "TodoItem",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_User_UserId",
                table: "TodoItem");

            migrationBuilder.DropIndex(
                name: "IX_TodoItem_UserId",
                table: "TodoItem");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TodoItem");
        }
    }
}
