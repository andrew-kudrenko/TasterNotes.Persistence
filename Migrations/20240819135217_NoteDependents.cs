using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasterNotes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NoteDependents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    HashedPassword = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RemovedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Dishware",
                columns: table => new
                {
                    DishwareId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Kind = table.Column<string>(type: "TEXT", nullable: false),
                    Volume = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishware", x => x.DishwareId);
                    table.ForeignKey(
                        name: "FK_Dishware_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DishwareId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Kind = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Region = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    TastingDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    BrewingMethod = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    BrewingTemperature = table.Column<int>(type: "INTEGER", nullable: false),
                    BrewingVolume = table.Column<int>(type: "INTEGER", nullable: false),
                    BrewingAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    BrewingDishware = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    DryLeafAppearance = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    DryLeafAroma = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    InfusionAppearance = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    InfusionAroma = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    InfusionComment = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    InfusionBody = table.Column<int>(type: "INTEGER", nullable: false),
                    InfusionBalance = table.Column<int>(type: "INTEGER", nullable: false),
                    InfusionBouquet = table.Column<int>(type: "INTEGER", nullable: false),
                    InfusionExtractivity = table.Column<int>(type: "INTEGER", nullable: false),
                    AftertasteIntense = table.Column<int>(type: "INTEGER", nullable: false),
                    AftertasteDuration = table.Column<int>(type: "INTEGER", nullable: false),
                    AftertasteComment = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    ImpressionComment = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    ImpressionRate = table.Column<int>(type: "INTEGER", nullable: false),
                    WellCombinedWith = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    OtherComment = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Notes_Dishware_DishwareId",
                        column: x => x.DishwareId,
                        principalTable: "Dishware",
                        principalColumn: "DishwareId");
                    table.ForeignKey(
                        name: "FK_Notes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescriptorSet",
                columns: table => new
                {
                    NoteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Earthy = table.Column<int>(type: "INTEGER", nullable: false),
                    Animal = table.Column<int>(type: "INTEGER", nullable: false),
                    Mineral = table.Column<int>(type: "INTEGER", nullable: false),
                    Sea = table.Column<int>(type: "INTEGER", nullable: false),
                    Confectionary = table.Column<int>(type: "INTEGER", nullable: false),
                    Bread = table.Column<int>(type: "INTEGER", nullable: false),
                    Creamy = table.Column<int>(type: "INTEGER", nullable: false),
                    Herbaceous = table.Column<int>(type: "INTEGER", nullable: false),
                    Vegetable = table.Column<int>(type: "INTEGER", nullable: false),
                    Spicy = table.Column<int>(type: "INTEGER", nullable: false),
                    Floral = table.Column<int>(type: "INTEGER", nullable: false),
                    FreshFruity = table.Column<int>(type: "INTEGER", nullable: false),
                    Citrus = table.Column<int>(type: "INTEGER", nullable: false),
                    Tropical = table.Column<int>(type: "INTEGER", nullable: false),
                    Candied = table.Column<int>(type: "INTEGER", nullable: false),
                    Berry = table.Column<int>(type: "INTEGER", nullable: false),
                    DriedFrruity = table.Column<int>(type: "INTEGER", nullable: false),
                    Nutty = table.Column<int>(type: "INTEGER", nullable: false),
                    Woody = table.Column<int>(type: "INTEGER", nullable: false),
                    Yeast = table.Column<int>(type: "INTEGER", nullable: false),
                    Chemical = table.Column<int>(type: "INTEGER", nullable: false),
                    Mushroom = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptorSet", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_DescriptorSet_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taste",
                columns: table => new
                {
                    NoteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Sweety = table.Column<int>(type: "INTEGER", nullable: false),
                    Sour = table.Column<int>(type: "INTEGER", nullable: false),
                    Bitter = table.Column<int>(type: "INTEGER", nullable: false),
                    Salty = table.Column<int>(type: "INTEGER", nullable: false),
                    Umami = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taste", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Taste_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishware_UserId",
                table: "Dishware",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_DishwareId",
                table: "Notes",
                column: "DishwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptorSet");

            migrationBuilder.DropTable(
                name: "Taste");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Dishware");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
