using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddGameCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameComments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5790), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5790), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 7, 5, 0, 40, 9, 465, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.CreateIndex(
                name: "IX_GameComments_GameId",
                table: "GameComments",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameComments_UserId",
                table: "GameComments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameComments");

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2420), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2880), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 7, 4, 21, 47, 57, 497, DateTimeKind.Local).AddTicks(3040) });
        }
    }
}
