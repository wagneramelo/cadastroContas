﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoAPI.Migrations
{
    public partial class trocanome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Conta",
                table: "Conta");

            migrationBuilder.RenameTable(
                name: "Conta",
                newName: "Contas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contas",
                table: "Contas",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contas",
                table: "Contas");

            migrationBuilder.RenameTable(
                name: "Contas",
                newName: "Conta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conta",
                table: "Conta",
                column: "ContaId");
        }
    }
}
