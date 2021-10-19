using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestSigmatech.Migrations
{
    public partial class CompleteDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mMaritalStatus",
                columns: table => new
                {
                    m_marital_status_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marital_status_desc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mMaritalStatus", x => x.m_marital_status_id);
                });

            migrationBuilder.CreateTable(
                name: "mReligion",
                columns: table => new
                {
                    religion_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    religion_name = table.Column<string>(type: "text", nullable: true),
                    usr_crt = table.Column<string>(type: "text", nullable: true),
                    dtm_crt = table.Column<string>(type: "text", nullable: true),
                    usr_upd = table.Column<string>(type: "text", nullable: true),
                    dtm_upd = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mReligion", x => x.religion_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mMaritalStatus");

            migrationBuilder.DropTable(
                name: "mReligion");
        }
    }
}
