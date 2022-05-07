using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchStoreMvcDeneme.Migrations
{
    public partial class PriceImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Watches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Watches",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Watches");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Watches");
        }
    }
}
