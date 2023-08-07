using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWeb.Migrations
{
    public partial class ToDoRenamedCreatedDatetoCompletionDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ToDos",
                newName: "CompletionDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompletionDate",
                table: "ToDos",
                newName: "CreatedDate");
        }
    }
}
