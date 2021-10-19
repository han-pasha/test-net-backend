using Microsoft.EntityFrameworkCore.Migrations;

namespace TestSigmatech.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_checkResult_checkResult_t_dukcapil_check_resultNIK",
                table: "checkResult");

            migrationBuilder.DropIndex(
                name: "IX_checkResult_t_dukcapil_check_resultNIK",
                table: "checkResult");

            migrationBuilder.DropColumn(
                name: "t_dukcapil_check_resultNIK",
                table: "checkResult");

            migrationBuilder.AddColumn<string>(
                name: "t_dukcapil_check_result",
                table: "checkResult",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "t_dukcapil_check_result",
                table: "checkResult");

            migrationBuilder.AddColumn<int>(
                name: "t_dukcapil_check_resultNIK",
                table: "checkResult",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_checkResult_t_dukcapil_check_resultNIK",
                table: "checkResult",
                column: "t_dukcapil_check_resultNIK");

            migrationBuilder.AddForeignKey(
                name: "FK_checkResult_checkResult_t_dukcapil_check_resultNIK",
                table: "checkResult",
                column: "t_dukcapil_check_resultNIK",
                principalTable: "checkResult",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
