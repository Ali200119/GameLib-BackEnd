using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "ModifiedAt", "SoftDelete", "Title" },
                values: new object[] { 1, new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4050), "At GameLib, we are passionate about video games and committed to bringing you the ultimate gaming experience. Our website is a haven for all gaming enthusiasts, offering a wide selection of the latest and greatest video games across multiple platforms.Discover a vast library of games covering various genres, from action-packed adventures to immersive role-playing worlds. Whether you're a casual gamer or a hardcore enthusiast, GameLib has something for everyone. Dive into captivating storylines, engage in intense multiplayer battles, or challenge yourself with mind-bending puzzles – the possibilities are endless.We pride ourselves on curating a diverse collection of games from renowned publishers and independent developers alike. Our team meticulously selects each title to ensure that only the highest quality and most exciting games make it to your fingertips.", "Ninja Cyberpunk.jpg", new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4080), false, "Welcome to GameLib!" });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4520), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4320), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4850), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 7, 5, 15, 52, 30, 401, DateTimeKind.Local).AddTicks(4980) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

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
        }
    }
}
