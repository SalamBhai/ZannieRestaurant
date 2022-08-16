using Microsoft.EntityFrameworkCore.Migrations;

namespace Cakes_N_Treats_By_Zannie.Migrations
{
    public partial class migratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TreatDescription",
                table: "Treats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress",
                table: "Orders",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TreatDescription",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "DeliveryAddress",
                table: "Orders");
        }
    }
}
