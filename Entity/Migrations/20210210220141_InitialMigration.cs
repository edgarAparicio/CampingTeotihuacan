﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueName = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Address3 = table.Column<string>(nullable: true),
                    CityTown = table.Column<string>(nullable: true),
                    StateProvince = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    CompanyUrl = table.Column<string>(nullable: true),
                    BlogUrl = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    GitHub = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Camps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Moniker = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camps_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Abstract = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    CampId = table.Column<int>(nullable: false),
                    SpeakerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talks_Camps_CampId",
                        column: x => x.CampId,
                        principalTable: "Camps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talks_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "CityTown", "Country", "PostalCode", "StateProvince", "VenueName" },
                values: new object[] { 1, "123 Main Street", null, null, "Atlanta", "USA", "12345", "GA", "Atlanta Convention Center" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "BlogUrl", "Company", "CompanyUrl", "FirstName", "GitHub", "LastName", "MiddleName", "Twitter" },
                values: new object[] { 1, "http://wildermuth.com", "Wilder Minds LLC", "http://wilderminds.com", "Shawn", "shawnwildermuth", "Wildermuth", null, "shawnwildermuth" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "BlogUrl", "Company", "CompanyUrl", "FirstName", "GitHub", "LastName", "MiddleName", "Twitter" },
                values: new object[] { 2, "http://shawnandresa.com", "Wilder Minds LLC", "http://wilderminds.com", "Resa", "resawildermuth", "Wildermuth", null, "resawildermuth" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "EventDate", "Length", "LocationId", "Moniker", "Name" },
                values: new object[] { 1, new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "ATL2018", "Atlanta Code Camp" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "Id", "Abstract", "CampId", "Level", "SpeakerId", "Title" },
                values: new object[] { 1, "Entity Framework from scratch in an hour. Probably cover it all", 1, 100, 1, "Entity Framework From Scratch" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "Id", "Abstract", "CampId", "Level", "SpeakerId", "Title" },
                values: new object[] { 2, "Thinking of good sample data examples is tiring.", 1, 200, 2, "Writing Sample Data Made Easy" });

            migrationBuilder.CreateIndex(
                name: "IX_Camps_LocationId",
                table: "Camps",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Talks_CampId",
                table: "Talks",
                column: "CampId");

            migrationBuilder.CreateIndex(
                name: "IX_Talks_SpeakerId",
                table: "Talks",
                column: "SpeakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talks");

            migrationBuilder.DropTable(
                name: "Camps");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
