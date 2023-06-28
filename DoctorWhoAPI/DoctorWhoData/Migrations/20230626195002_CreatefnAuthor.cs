using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    public partial class CreatefnAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnAuthorName (@AuthorId INT)
                    RETURNS VARCHAR(100)
                    AS
                    BEGIN
                        DECLARE @Name VARCHAR(100);
    
                        SELECT @Name = STRING_AGG(Name , ', ')
                        FROM (
                            SELECT a.Name 
                            FROM Authors a
                            INNER JOIN Episodes e ON a.AuthorId = e.AuthorId
                            WHERE a.AuthorId = @AuthorId
                        ) AS subquery;

                        RETURN @Name;
                    END;"
            );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnAuthorName;");
        }
    }
}