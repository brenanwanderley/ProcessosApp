using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessosApp.Migrations
{
    /// <inheritdoc />
    public partial class novasColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoSigla",
                table: "Processos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "MunicipioId",
                table: "Processos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoSigla",
                table: "Processos");

            migrationBuilder.DropColumn(
                name: "MunicipioId",
                table: "Processos");
        }
    }
}
