using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    public partial class createfnEnemies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnEnemies (@EpisodeId INT)
                    RETURNS VARCHAR(100)
                    AS
                    BEGIN
                        DECLARE @ConcatenatedValues VARCHAR(100);
    
                        SELECT @ConcatenatedValues = STRING_AGG(Name , ', ')
                        FROM (
                            SELECT en.Name 
                            FROM Episodes e
                            INNER JOIN EpisodeEnemies ee ON e.EpisodeId = ee.EpisodeId
                            INNER JOIN Enemies en ON ee.EnemyId = en.EnemyId
                            WHERE ee.EpisodeId = @EpisodeId
                        ) AS subquery;
    
                        RETURN @ConcatenatedValues;
                    END;"
            );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnEnemies;");
        }
    }
}