using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Armory.BL.Migrations
{
    /// <inheritdoc />
    public partial class AddAirports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ammunitions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammunitions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeaponTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SecurityOfficers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PositionID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityOfficers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SecurityOfficers_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    TypeID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "WeaponTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    AirportID = table.Column<int>(type: "INTEGER", nullable: false),
                    WeaponID = table.Column<int>(type: "INTEGER", nullable: false),
                    WeaponRegistrationNumber = table.Column<string>(type: "TEXT", nullable: true),
                    WeaponCharacteristics = table.Column<string>(type: "TEXT", nullable: true),
                    WeaponBaggageTagNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AmmunitionID = table.Column<int>(type: "INTEGER", nullable: false),
                    AmmunitionCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AmmunitionWeight = table.Column<double>(type: "REAL", nullable: false),
                    AmmunitionBaggageTagNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityOfficerID = table.Column<int>(type: "INTEGER", nullable: false),
                    CityID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    PlaneID = table.Column<int>(type: "INTEGER", nullable: false),
                    CrewMemberID = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acts_Airports_AirportID",
                        column: x => x.AirportID,
                        principalTable: "Airports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_Ammunitions_AmmunitionID",
                        column: x => x.AmmunitionID,
                        principalTable: "Ammunitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_CrewMembers_CrewMemberID",
                        column: x => x.CrewMemberID,
                        principalTable: "CrewMembers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_Flights_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_Planes_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Planes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_SecurityOfficers_SecurityOfficerID",
                        column: x => x.SecurityOfficerID,
                        principalTable: "SecurityOfficers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acts_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acts_AirportID",
                table: "Acts",
                column: "AirportID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_AmmunitionID",
                table: "Acts",
                column: "AmmunitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_CityID",
                table: "Acts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_CrewMemberID",
                table: "Acts",
                column: "CrewMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_FlightID",
                table: "Acts",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_PlaneID",
                table: "Acts",
                column: "PlaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_SecurityOfficerID",
                table: "Acts",
                column: "SecurityOfficerID");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_WeaponID",
                table: "Acts",
                column: "WeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityOfficers_PositionID",
                table: "SecurityOfficers",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_TypeID",
                table: "Weapons",
                column: "TypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acts");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Ammunitions");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CrewMembers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "SecurityOfficers");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "WeaponTypes");
        }
    }
}
