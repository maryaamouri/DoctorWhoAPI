using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    /// <inheritdoc />
    public partial class AddORelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Enemies_EnemyId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_EnemyId",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "EnemyId",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "Authors");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episodes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episodes",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeEnemies_EnemyId",
                table: "EpisodeEnemies",
                column: "EnemyId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeEnemies_EpisodeId",
                table: "EpisodeEnemies",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeCompanions_CompanionId",
                table: "EpisodeCompanions",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeCompanions_EpisodeId",
                table: "EpisodeCompanions",
                column: "EpisodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions",
                column: "CompanionId",
                principalTable: "Companions",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies",
                column: "EnemyId",
                principalTable: "Enemies",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeEnemies_EnemyId",
                table: "EpisodeEnemies");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeEnemies_EpisodeId",
                table: "EpisodeEnemies");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeCompanions_CompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeCompanions_EpisodeId",
                table: "EpisodeCompanions");

            migrationBuilder.AddColumn<int>(
                name: "EnemyId",
                table: "Episodes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_EnemyId",
                table: "Episodes",
                column: "EnemyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Enemies_EnemyId",
                table: "Episodes",
                column: "EnemyId",
                principalTable: "Enemies",
                principalColumn: "EnemyId");
        }
    }
}
