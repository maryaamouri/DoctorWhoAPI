using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
   
    public partial class CreateViewEpisode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                CREATE VIEW viewEpisodes AS
                    SELECT
                        e.EpisodeId,
                        e.SeriesNumber,
                        e.Type,
                        e.Title,
                        e.EpisodeDate,
                        dbo.fnAuthorName(e.AuthorId) AS AuthorName,
                        dbo.fnDoctorName(e.DoctorId) AS DoctorName,
                        dbo.fnCompanions(e.EpisodeId) AS Companions,
                        dbo.fnEnemies(e.EpisodeId) AS Enemies
                    FROM
                        Episodes e;
                    ");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"IF EXISTS (SELECT 1 FROM sys.views WHERE name = 'viewEpisodes')
                                    DROP VIEW dbo.viewEpisodes;"
                );
        }
    }
}
