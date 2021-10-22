using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Concrete.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Car_CarId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_CarId",
                table: "Location");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_LocationId",
                table: "Car",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_LocationId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Car");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CarId",
                table: "Location",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Car_CarId",
                table: "Location",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
