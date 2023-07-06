using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddForgotPasswordBG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.InsertData(
                table: "SectionHeaders",
                columns: new[] { "Id", "CreatedAt", "Key", "ModifiedAt", "SoftDelete", "Value" },
                values: new object[] { 13, new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020), "ForgotPasswordBG", new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8020), false, "Forgot Password BG.jpeg" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8300), new DateTime(2023, 7, 7, 3, 25, 13, 246, DateTimeKind.Local).AddTicks(8300) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Advantages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6530), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6530), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6420), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6980), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6980), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 7, 7, 0, 7, 57, 952, DateTimeKind.Local).AddTicks(7000) });
        }
    }
}
