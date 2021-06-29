using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class DepartmentsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saller_Department_Departmentid",
                table: "Saller");

            migrationBuilder.RenameColumn(
                name: "Departmentid",
                table: "Saller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Saller_Departmentid",
                table: "Saller",
                newName: "IX_Saller_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Saller",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Saller",
                newName: "Departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_Saller_DepartmentId",
                table: "Saller",
                newName: "IX_Saller_Departmentid");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Saller",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Saller_Department_Departmentid",
                table: "Saller",
                column: "Departmentid",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
