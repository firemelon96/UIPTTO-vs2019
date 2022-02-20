using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UIPTTO_DATABASE.Migrations
{
    public partial class trademarkstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "t_Status",
                table: "trademark_Table",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "t_Status",
                table: "trademark_Table");
        }
    }
}
