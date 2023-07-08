using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class addingKeylessEntityToDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3835), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 28, 12, 992, DateTimeKind.Local).AddTicks(4176));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2363), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 21, 36, 61, DateTimeKind.Local).AddTicks(2427));
        }
    }
}
