using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurants_API.Migrations
{
    public partial class Restaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Restaurant_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Restaurant_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email_Id = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Restaurant_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
