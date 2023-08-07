using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWeb.Migrations
{
    public partial class ToDoPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoId",
                table: "ToDos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoId",
                table: "ToDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos",
                column: "Id");
        }
    }
}
