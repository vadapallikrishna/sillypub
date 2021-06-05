using Microsoft.EntityFrameworkCore.Migrations;

namespace sillypub.Migrations
{
    public partial class CreatePlaceSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new {
                    Id = table.Column<string>(type: "TEXT",nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("Place_PK", x => x.Id);
                }
    
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Place");
        }
    }
}
