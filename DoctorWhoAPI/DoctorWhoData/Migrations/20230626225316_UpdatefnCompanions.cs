using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    public partial class UpdatefnCompanions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnCompanions (@EpisodeId INT)
                    RETURNS VARCHAR(100)
                    AS
                    BEGIN
                        DECLARE @ConcatenatedValues VARCHAR(100);
    
                        SELECT @ConcatenatedValues = STRING_AGG(Name , ', ')
                        FROM (
                            SELECT c.Name 
                            FROM EpisodeCompanions ec INNER JOIN Companions c 
                            ON c.CompanionId = ec.CompanionId
                            WHERE ec.EpisodeId = @EpisodeId
                        ) AS subquery;
    
                        RETURN @ConcatenatedValues;
                    END;"
                );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnCompanions;");
        }
    }
}
