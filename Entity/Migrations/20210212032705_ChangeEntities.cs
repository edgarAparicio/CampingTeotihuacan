using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Migrations
{
    public partial class ChangeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps");

            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks");

            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Speakers_SpeakerId",
                table: "Talks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Talks",
                table: "Talks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Camps",
                table: "Camps");

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Talks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Camps");

            migrationBuilder.AlterColumn<int>(
                name: "SpeakerId",
                table: "Talks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CampId",
                table: "Talks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TalkId",
                table: "Talks",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SpeakerId",
                table: "Speakers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Location",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Camps",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CampId",
                table: "Camps",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Talks",
                table: "Talks",
                column: "TalkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "SpeakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Camps",
                table: "Camps",
                column: "CampId");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Address1", "Address2", "Address3", "CityTown", "Country", "PostalCode", "StateProvince", "VenueName" },
                values: new object[] { 1, "123 Main Street", null, null, "Atlanta", "USA", "12345", "GA", "Atlanta Convention Center" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "BlogUrl", "Company", "CompanyUrl", "FirstName", "GitHub", "LastName", "MiddleName", "Twitter" },
                values: new object[] { 1, "http://wildermuth.com", "Wilder Minds LLC", "http://wilderminds.com", "Shawn", "shawnwildermuth", "Wildermuth", null, "shawnwildermuth" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "BlogUrl", "Company", "CompanyUrl", "FirstName", "GitHub", "LastName", "MiddleName", "Twitter" },
                values: new object[] { 2, "http://shawnandresa.com", "Wilder Minds LLC", "http://wilderminds.com", "Resa", "resawildermuth", "Wildermuth", null, "resawildermuth" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "CampId", "EventDate", "Length", "LocationId", "Moniker", "Name" },
                values: new object[] { 1, new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "ATL2018", "Atlanta Code Camp" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "TalkId", "Abstract", "CampId", "Level", "SpeakerId", "Title" },
                values: new object[] { 1, "Entity Framework from scratch in an hour. Probably cover it all", 1, 100, 1, "Entity Framework From Scratch" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "TalkId", "Abstract", "CampId", "Level", "SpeakerId", "Title" },
                values: new object[] { 2, "Thinking of good sample data examples is tiring.", 1, 200, 2, "Writing Sample Data Made Easy" });

            migrationBuilder.AddForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "CampId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Speakers_SpeakerId",
                table: "Talks",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "SpeakerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps");

            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks");

            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Speakers_SpeakerId",
                table: "Talks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Talks",
                table: "Talks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Camps",
                table: "Camps");

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumn: "TalkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumn: "TalkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "CampId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TalkId",
                table: "Talks");

            migrationBuilder.DropColumn(
                name: "SpeakerId",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CampId",
                table: "Camps");

            migrationBuilder.AlterColumn<int>(
                name: "SpeakerId",
                table: "Talks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CampId",
                table: "Talks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Talks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Speakers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Camps",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Camps",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Talks",
                table: "Talks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Camps",
                table: "Camps",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Speakers_SpeakerId",
                table: "Talks",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
