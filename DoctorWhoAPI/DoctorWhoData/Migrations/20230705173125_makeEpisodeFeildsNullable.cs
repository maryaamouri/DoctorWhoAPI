using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class makeEpisodeFeildsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(595), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(662), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(671), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(691), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(700), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 5, 20, 31, 25, 3, DateTimeKind.Local).AddTicks(774));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 6, 27, 1, 53, 15, 907, DateTimeKind.Local).AddTicks(6276));
        }
    }
}
