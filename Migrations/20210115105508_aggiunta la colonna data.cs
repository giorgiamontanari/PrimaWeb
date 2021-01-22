using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Montanari.Giorgia._5H.PrimaWeb.Migrations
{
    public partial class aggiuntalacolonnadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Prenotazioni");
        }
    }
}
