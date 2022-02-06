using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UIPTTO_DATABASE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profile_Table",
                columns: table => new
                {
                    p_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    p_Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    p_Lname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    p_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    p_College = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    p_Gender = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    p_DOB = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profile_Table", x => x.p_Id);
                });

            migrationBuilder.CreateTable(
                name: "trademark_Table",
                columns: table => new
                {
                    t_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    t_DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    t_RegNo = table.Column<int>(type: "int", nullable: true),
                    t_ApprDate = table.Column<DateTime>(type: "date", nullable: true),
                    t_DAUFiling = table.Column<DateTime>(type: "date", nullable: true),
                    t_ExpiryDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trademark_Table", x => x.t_Id);
                });

            migrationBuilder.CreateTable(
                name: "user_Table",
                columns: table => new
                {
                    u_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    u_Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_Lname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_College = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    u_DOB = table.Column<DateTime>(type: "date", nullable: true),
                    u_Gender = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "copyright_Table",
                columns: table => new
                {
                    c_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    c_DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    c_RegNo = table.Column<int>(type: "int", nullable: true),
                    c_ApprDate = table.Column<DateTime>(type: "date", nullable: true),
                    p_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_copyright_Table", x => x.c_Id);
                    table.ForeignKey(
                        name: "FK_copyright_Table_profile_Table",
                        column: x => x.p_Id,
                        principalTable: "profile_Table",
                        principalColumn: "p_Id");
                });

            migrationBuilder.CreateTable(
                name: "isbn_Table",
                columns: table => new
                {
                    is_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    is_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    is_DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    is_IssuedNo = table.Column<int>(type: "int", nullable: true),
                    is_ApprDate = table.Column<DateTime>(type: "date", nullable: true),
                    p_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_isbn_Table", x => x.is_Id);
                    table.ForeignKey(
                        name: "FK_isbn_Table_profile_Table",
                        column: x => x.p_Id,
                        principalTable: "profile_Table",
                        principalColumn: "p_Id");
                });

            migrationBuilder.CreateTable(
                name: "issn_Table",
                columns: table => new
                {
                    i_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    i_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    i_DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    i_IssuedNo = table.Column<int>(type: "int", nullable: true),
                    i_ApprDate = table.Column<DateTime>(type: "date", nullable: true),
                    p_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issn_Table", x => x.i_Id);
                    table.ForeignKey(
                        name: "FK_issn_Table_profile_Table",
                        column: x => x.p_Id,
                        principalTable: "profile_Table",
                        principalColumn: "p_Id");
                });

            migrationBuilder.CreateTable(
                name: "patent_Table",
                columns: table => new
                {
                    pt_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pt_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pt_DateFiled = table.Column<DateTime>(type: "date", nullable: true),
                    pt_RegNo = table.Column<int>(type: "int", nullable: true),
                    pr_ApprDate = table.Column<DateTime>(type: "date", nullable: true),
                    p_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patent_Table", x => x.pt_Id);
                    table.ForeignKey(
                        name: "FK_patent_Table_profile_Table",
                        column: x => x.p_Id,
                        principalTable: "profile_Table",
                        principalColumn: "p_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_copyright_Table_p_Id",
                table: "copyright_Table",
                column: "p_Id");

            migrationBuilder.CreateIndex(
                name: "IX_isbn_Table_p_Id",
                table: "isbn_Table",
                column: "p_Id");

            migrationBuilder.CreateIndex(
                name: "IX_issn_Table_p_Id",
                table: "issn_Table",
                column: "p_Id");

            migrationBuilder.CreateIndex(
                name: "IX_patent_Table_p_Id",
                table: "patent_Table",
                column: "p_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "copyright_Table");

            migrationBuilder.DropTable(
                name: "isbn_Table");

            migrationBuilder.DropTable(
                name: "issn_Table");

            migrationBuilder.DropTable(
                name: "patent_Table");

            migrationBuilder.DropTable(
                name: "trademark_Table");

            migrationBuilder.DropTable(
                name: "user_Table");

            migrationBuilder.DropTable(
                name: "profile_Table");
        }
    }
}
