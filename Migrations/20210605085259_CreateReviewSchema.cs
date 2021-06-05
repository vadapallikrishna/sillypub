using Microsoft.EntityFrameworkCore.Migrations;

namespace sillypub.Migrations
{
    public partial class CreateReviewSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("Review_PK", x => x.Id);
                    table.ForeignKey("Review_User", column: x=>x.UserId, principalColumn: "Id", principalTable: "User", onDelete: ReferentialAction.Cascade);
                }

            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Review");
        }
    }
}
