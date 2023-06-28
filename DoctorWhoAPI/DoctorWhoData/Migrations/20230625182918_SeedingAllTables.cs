using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpisodeNumber",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "EpisodeType",
                table: "Episodes",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Doctors",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Doctors",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "SeriesNumber",
                table: "Episodes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "Name", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Companion 1", "Actor 1" },
                    { 2, "Companion 2", "Actor 2" },
                    { 3, "Companion 3", "Actor 3" },
                    { 4, "Companion 4", "Actor 4" },
                    { 5, "Companion 5", "Actor 5" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "FirstEpisodeDate", "LastEpisodeDate", "Name", "Number" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4316), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4363), "Doctor Name 1", "Doctor 1" },
                    { 2, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4371), "Doctor Name 2", "Doctor 2" },
                    { 3, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4373), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4377), "Doctor Name 3", "Doctor 3" },
                    { 4, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4384), "Doctor Name 4", "Doctor 4" },
                    { 5, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4400), "Doctor Name 5", "Doctor 5" }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description 1", "Enemy 1" },
                    { 2, "Description 2", "Enemy 2" },
                    { 3, "Description 3", "Enemy 3" },
                    { 4, "Description 4", "Enemy 4" },
                    { 5, "Description 5", "Enemy 5" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "Notes", "Number", "SeriesNumber", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4431), "Note 1", 1, 1, "Episode 1", "Type 1" },
                    { 2, 2, 2, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4436), "Note 2", 2, 1, "Episode 2", "Type 1" },
                    { 3, 3, 3, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4440), "Note 3", 3, 1, "Episode 3", "Type 1" },
                    { 4, 4, 4, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4443), "Note 4", 4, 1, "Episode 4", "Type 1" },
                    { 5, 5, 5, new DateTime(2023, 6, 25, 21, 29, 18, 152, DateTimeKind.Local).AddTicks(4447), "Note 5", 5, 1, "Episode 5", "Type 1" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Episodes",
                newName: "EpisodeType");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Doctors",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctors",
                newName: "name");

            migrationBuilder.AlterColumn<string>(
                name: "SeriesNumber",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EpisodeNumber",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
