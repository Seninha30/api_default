using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Default.Infra.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<byte>(nullable: false, defaultValue: (byte)0),
                    PrimeiroNome = table.Column<string>(maxLength: 50, nullable: true),
                    Ultimonome = table.Column<string>(maxLength: 50, nullable: true),
                    EnderecoEmail = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
