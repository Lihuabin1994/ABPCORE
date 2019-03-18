using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VueCore.Migrations
{
    public partial class mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNo = table.Column<string>(maxLength: 20, nullable: false),
                    ProductCode = table.Column<string>(maxLength: 50, nullable: false),
                    SecType = table.Column<string>(maxLength: 5, nullable: false),
                    MMY = table.Column<string>(maxLength: 4, nullable: false),
                    PutCall = table.Column<string>(maxLength: 1, nullable: true),
                    StrikePx = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    TradeID = table.Column<string>(maxLength: 50, nullable: true),
                    OrderID = table.Column<string>(maxLength: 50, nullable: true),
                    TradeVenue = table.Column<int>(nullable: false),
                    Side = table.Column<string>(maxLength: 1, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    EventType = table.Column<string>(maxLength: 10, nullable: true),
                    TradeDate = table.Column<DateTime>(nullable: false),
                    TradePrice = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    Ccy = table.Column<string>(maxLength: 10, nullable: true),
                    BizDate = table.Column<DateTime>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    Exchange = table.Column<string>(maxLength: 10, nullable: true),
                    ClearingMember = table.Column<string>(maxLength: 50, nullable: true),
                    AccountType = table.Column<string>(maxLength: 5, nullable: true),
                    ContractSize = table.Column<int>(nullable: false),
                    AllocateFlag = table.Column<string>(maxLength: 1, nullable: true),
                    BizUnit = table.Column<string>(maxLength: 50, nullable: true),
                    MarketID = table.Column<string>(maxLength: 50, nullable: true),
                    GroupID = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClosingID = table.Column<int>(nullable: false),
                    ClosedID = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    CloseProfit = table.Column<decimal>(nullable: true),
                    CloseFlag = table.Column<string>(maxLength: 1, nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    LastUpadteDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TradeDetail_Trade_ClosedID",
                        column: x => x.ClosedID,
                        principalTable: "Trade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TradeDetail_ClosedID",
                table: "TradeDetail",
                column: "ClosedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradeDetail");

            migrationBuilder.DropTable(
                name: "Trade");
        }
    }
}
