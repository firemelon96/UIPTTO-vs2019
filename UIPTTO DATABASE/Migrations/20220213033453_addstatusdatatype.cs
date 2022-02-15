using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UIPTTO_DATABASE.Migrations
{
    public partial class addstatusdatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "c_Status",
                table: "copyright_Table",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "c_Status",
                table: "copyright_Table");
        }
    }
}
