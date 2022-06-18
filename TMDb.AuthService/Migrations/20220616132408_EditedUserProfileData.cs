using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDb.AuthService.Migrations
{
    public partial class EditedUserProfileData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MovieTitle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieTitle");
        }
    }
}
