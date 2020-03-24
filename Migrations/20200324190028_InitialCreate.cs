using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonMasterTools.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    PlayerName = table.Column<string>(nullable: true),
                    CharacterName = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Wisdom = table.Column<int>(nullable: false),
                    Charisma = table.Column<int>(nullable: false),
                    StrMod = table.Column<int>(nullable: false),
                    DexMod = table.Column<int>(nullable: false),
                    ConMod = table.Column<int>(nullable: false),
                    IntMod = table.Column<int>(nullable: false),
                    WisMod = table.Column<int>(nullable: false),
                    ChaMod = table.Column<int>(nullable: false),
                    InitiativeScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    GroupID = table.Column<Guid>(nullable: false),
                    PlayerID = table.Column<Guid>(nullable: false),
                    CharacterID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Groups_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CharacterID",
                table: "Groups",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
