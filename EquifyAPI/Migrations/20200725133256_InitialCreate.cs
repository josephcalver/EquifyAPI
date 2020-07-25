using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquifyAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(nullable: true),
                    FoundedDate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    EnterpriseValue = table.Column<string>(nullable: true),
                    DealType = table.Column<string>(nullable: true),
                    DealOriginationDate = table.Column<DateTime>(nullable: false),
                    DealStatus = table.Column<string>(nullable: true),
                    FundInvesting = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    EquityRequired = table.Column<decimal>(nullable: false),
                    DealTeamLead = table.Column<string>(nullable: true),
                    InvestorRelationsLead = table.Column<string>(nullable: true),
                    ESGLead = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal");
        }
    }
}
