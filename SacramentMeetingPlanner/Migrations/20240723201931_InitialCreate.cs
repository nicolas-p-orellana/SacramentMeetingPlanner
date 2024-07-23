using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OpeningSong = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Speaker1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Speaker1Subject = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Speaker2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Speaker2Subject = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Speaker3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Speaker3Subject = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ClosingSong = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentProgram", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentProgram");
        }
    }
}
