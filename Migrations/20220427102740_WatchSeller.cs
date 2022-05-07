using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchStoreMvcDeneme.Migrations
{
    public partial class WatchSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WatchSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchSellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchSellers_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WatchSellers_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchSellers_SellerId",
                table: "WatchSellers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchSellers_WatchId",
                table: "WatchSellers",
                column: "WatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchSellers");
        }
    }
}
