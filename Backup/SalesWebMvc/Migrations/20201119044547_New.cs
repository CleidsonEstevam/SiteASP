using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartamentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Seller",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
