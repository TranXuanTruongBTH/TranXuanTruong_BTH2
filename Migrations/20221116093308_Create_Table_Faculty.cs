using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranXuanTruongBTH2.Migrations
{
    public partial class Create_Table_Faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Studentname",
                table: "Student",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "namsinh",
                table: "Person",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "tên",
                table: "Employee",
                newName: "Office");

            migrationBuilder.RenameColumn(
                name: "phongban",
                table: "Employee",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "MaNV",
                table: "Employee",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Student",
                newName: "Studentname");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Person",
                newName: "namsinh");

            migrationBuilder.RenameColumn(
                name: "Office",
                table: "Employee",
                newName: "tên");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Employee",
                newName: "phongban");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "MaNV");
        }
    }
}
