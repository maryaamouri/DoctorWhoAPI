using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class addingKeylessEntityForView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7241), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7247), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7251), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7252), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7255), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7260), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7262), new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 0, 5, 24, 374, DateTimeKind.Local).AddTicks(7301));
        }
    }
}
