using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{

    public partial class Createprocedure : Migration
    {
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE spSummariseEpisodes
                    AS
                    BEGIN

	                    SELECT TOP 3 c.CompanionId, c.Name, COUNT(ec.CompanionId) AS AppearanceCount
	                    FROM EpisodeCompanions ec
	                    JOIN Companions c ON c.CompanionId = ec.CompanionId
	                    GROUP BY c.CompanionId, c.CompanyName
	                    ORDER BY AppearanceCount DESC;

	                    SELECT TOP 3 en.EnemyId, en.Name, COUNT(*) AS AppearanceCount
	                    FROM EpisodeEnemies ee
	                    INNER JOIN Enemies en ON ee.EnemyId = en.EnemyId
	                    GROUP BY en.EnemyId, en.Name
	                    ORDER BY AppearanceCount DESC;

                    END;"
                );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE spSummariseEpisodes");
        }
    }
}
