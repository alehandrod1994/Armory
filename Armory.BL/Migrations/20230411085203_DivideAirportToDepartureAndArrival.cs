using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Armory.BL.Migrations
{
    /// <inheritdoc />
    public partial class DivideAirportToDepartureAndArrival : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acts_Airports_AirportID",
                table: "Acts");

            migrationBuilder.DropForeignKey(
                name: "FK_Acts_Cities_CityID",
                table: "Acts");

            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "Acts",
                newName: "DepartureAirportID");

            migrationBuilder.RenameColumn(
                name: "AirportID",
                table: "Acts",
                newName: "ArrivalAirportID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_CityID",
                table: "Acts",
                newName: "IX_Acts_DepartureAirportID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_AirportID",
                table: "Acts",
                newName: "IX_Acts_ArrivalAirportID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Airports",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CityID",
                table: "Airports",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_Airports_ArrivalAirportID",
                table: "Acts",
                column: "ArrivalAirportID",
                principalTable: "Airports",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_Airports_DepartureAirportID",
                table: "Acts",
                column: "DepartureAirportID",
                principalTable: "Airports",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_Cities_CityID",
                table: "Airports",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acts_Airports_ArrivalAirportID",
                table: "Acts");

            migrationBuilder.DropForeignKey(
                name: "FK_Acts_Airports_DepartureAirportID",
                table: "Acts");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_Cities_CityID",
                table: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Airports_CityID",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Airports");

            migrationBuilder.RenameColumn(
                name: "DepartureAirportID",
                table: "Acts",
                newName: "CityID");

            migrationBuilder.RenameColumn(
                name: "ArrivalAirportID",
                table: "Acts",
                newName: "AirportID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_DepartureAirportID",
                table: "Acts",
                newName: "IX_Acts_CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Acts_ArrivalAirportID",
                table: "Acts",
                newName: "IX_Acts_AirportID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_Airports_AirportID",
                table: "Acts",
                column: "AirportID",
                principalTable: "Airports",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_Cities_CityID",
                table: "Acts",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
