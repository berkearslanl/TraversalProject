using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_rehber_rota_iliski1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VarisNoktalaris_Rehberlers_RehberlerRehberID",
                table: "VarisNoktalaris");

            migrationBuilder.DropIndex(
                name: "IX_VarisNoktalaris_RehberlerRehberID",
                table: "VarisNoktalaris");

            migrationBuilder.DropColumn(
                name: "RehberlerRehberID",
                table: "VarisNoktalaris");

            migrationBuilder.CreateIndex(
                name: "IX_VarisNoktalaris_RehberID",
                table: "VarisNoktalaris",
                column: "RehberID");

            migrationBuilder.AddForeignKey(
                name: "FK_VarisNoktalaris_Rehberlers_RehberID",
                table: "VarisNoktalaris",
                column: "RehberID",
                principalTable: "Rehberlers",
                principalColumn: "RehberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VarisNoktalaris_Rehberlers_RehberID",
                table: "VarisNoktalaris");

            migrationBuilder.DropIndex(
                name: "IX_VarisNoktalaris_RehberID",
                table: "VarisNoktalaris");

            migrationBuilder.AddColumn<int>(
                name: "RehberlerRehberID",
                table: "VarisNoktalaris",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VarisNoktalaris_RehberlerRehberID",
                table: "VarisNoktalaris",
                column: "RehberlerRehberID");

            migrationBuilder.AddForeignKey(
                name: "FK_VarisNoktalaris_Rehberlers_RehberlerRehberID",
                table: "VarisNoktalaris",
                column: "RehberlerRehberID",
                principalTable: "Rehberlers",
                principalColumn: "RehberID");
        }
    }
}
