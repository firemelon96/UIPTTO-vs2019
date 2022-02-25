using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UIPTTO_DATABASE.Migrations
{
    public partial class usertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "u_type",
                table: "user_Table",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_Table",
                table: "user_Table");

            migrationBuilder.DropColumn(
                name: "u_type",
                table: "user_Table");
        }
    }
}
