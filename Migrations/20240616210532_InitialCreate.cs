using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace transformers_battle_sim.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transformer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Faction = table.Column<string>(nullable: true),
                    WinCount = table.Column<int>(nullable: false),
                    LossCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transformer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mode",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModeName = table.Column<string>(nullable: true),
                    MovementType = table.Column<int>(nullable: false),
                    MovementSpeed = table.Column<double>(nullable: false),
                    AttackPower = table.Column<double>(nullable: false),
                    TransformerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mode_Transformer_TransformerId",
                        column: x => x.TransformerId,
                        principalTable: "Transformer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mode_TransformerId",
                table: "Mode",
                column: "TransformerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mode");

            migrationBuilder.DropTable(
                name: "Transformer");
        }
    }
}
