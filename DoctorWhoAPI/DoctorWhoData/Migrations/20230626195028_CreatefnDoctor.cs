using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoData.Migrations
{
    public partial class CreatefnDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnDoctorName (@DoctorId INT)
                    RETURNS VARCHAR(100)
                    AS
                    BEGIN
                        DECLARE @Name VARCHAR(100);
    
                        SELECT @Name = STRING_AGG(Name , ', ')
                        FROM (
                            SELECT d.Name 
                            FROM Episodes e
                            INNER JOIN Doctors d ON e.DoctorId = d.DoctorId
                            WHERE d.DoctorId = @DoctorId
                        ) AS subquery;
    
                        RETURN @Name;
                    END;"
            );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnDoctorName;");
        }
    }
}