using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiceSimulationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddDicetablesToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiceRoll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfRolls = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiceRoll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiceResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultsDie1 = table.Column<int>(type: "int", nullable: false),
                    ResultsDie2 = table.Column<int>(type: "int", nullable: false),
                    DiceRollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiceResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiceResults_DiceRoll_DiceRollId",
                        column: x => x.DiceRollId,
                        principalTable: "DiceRoll",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiceResults_DiceRollId",
                table: "DiceResults",
                column: "DiceRollId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiceResults");

            migrationBuilder.DropTable(
                name: "DiceRoll");
        }
    }
}
