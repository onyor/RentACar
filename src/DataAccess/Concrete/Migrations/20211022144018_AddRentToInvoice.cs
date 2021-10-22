using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Concrete.Migrations
{
    public partial class AddRentToInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Car_CarId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CarId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Invoice",
                newName: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_RentId",
                table: "Invoice",
                column: "RentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Rent_RentId",
                table: "Invoice",
                column: "RentId",
                principalTable: "Rent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Rent_RentId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_RentId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "RentId",
                table: "Invoice",
                newName: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CarId",
                table: "Invoice",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Car_CarId",
                table: "Invoice",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
