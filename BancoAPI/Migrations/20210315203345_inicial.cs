using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoAPI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    ContaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBanco = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NumeroConta = table.Column<string>(type: "varchar(16)", nullable: false),
                    NumeroAgencia = table.Column<string>(type: "varchar(15)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(15)", nullable: false),
                    NomeTitular = table.Column<string>(type: "varchar(30)", nullable: false),
                    dataAbertura = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.ContaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conta");
        }
    }
}
