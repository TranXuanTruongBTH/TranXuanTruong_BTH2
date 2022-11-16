using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranXuanTruongBTH2.Migrations
{
    public partial class Create_Foreignkey_Student​ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Student",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacultyID",
                table: "Student",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "Student");
        }
    }
}
