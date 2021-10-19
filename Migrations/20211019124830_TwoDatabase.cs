using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestSigmatech.Migrations
{
    public partial class TwoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "checkResult",
                columns: table => new
                {
                    NIK = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    t_dukcapil_check_resultNIK = table.Column<int>(type: "integer", nullable: true),
                    check_dtm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    check_status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checkResult", x => x.NIK);
                    table.ForeignKey(
                        name: "FK_checkResult_checkResult_t_dukcapil_check_resultNIK",
                        column: x => x.t_dukcapil_check_resultNIK,
                        principalTable: "checkResult",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_checkResult_t_dukcapil_check_resultNIK",
                table: "checkResult",
                column: "t_dukcapil_check_resultNIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checkResult");
        }
    }
}
