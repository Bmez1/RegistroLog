using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InformacionLogsBots.DataAccess.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "logs");

            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTransaccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DuracionTransaccion = table.Column<int>(type: "int", nullable: false),
                    Ambiente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tecnologia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Proceso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Proyecto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcesoInterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProceso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs",
                schema: "logs");
        }
    }
}
