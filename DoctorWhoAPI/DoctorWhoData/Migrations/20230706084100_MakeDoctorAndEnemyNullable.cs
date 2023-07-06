using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class MakeDoctorAndEnemyNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

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
                values: new object[] { new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7489), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7492), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7501), new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeDate",
                value: new DateTime(2023, 7, 6, 11, 41, 0, 226, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
