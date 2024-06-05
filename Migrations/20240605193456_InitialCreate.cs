using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_entity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taasks",
                columns: table => new
                {
                    TaaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaaskDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taasks", x => x.TaaskId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taasks");
        }
    }
}
