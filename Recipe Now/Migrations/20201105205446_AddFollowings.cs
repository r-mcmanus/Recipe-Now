using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_Now.Migrations
{
    public partial class AddFollowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Followings",
                columns: table => new
                {
                    Follower = table.Column<string>(nullable: false),
                    Followed = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followings", x => new { x.Follower, x.Followed });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Followings");
        }
    }
}
