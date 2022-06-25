using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDb.AuthService.Migrations
{
    public partial class ChangeForeignKeyToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTitle_AspNetUsers_TMDbUserId1",
                table: "MovieTitle");

            migrationBuilder.DropIndex(
                name: "IX_MovieTitle_TMDbUserId1",
                table: "MovieTitle");

            migrationBuilder.DropColumn(
                name: "TMDbUserId1",
                table: "MovieTitle");

            migrationBuilder.AlterColumn<string>(
                name: "TMDbUserId",
                table: "MovieTitle",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTitle_TMDbUserId",
                table: "MovieTitle",
                column: "TMDbUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTitle_AspNetUsers_TMDbUserId",
                table: "MovieTitle",
                column: "TMDbUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTitle_AspNetUsers_TMDbUserId",
                table: "MovieTitle");

            migrationBuilder.DropIndex(
                name: "IX_MovieTitle_TMDbUserId",
                table: "MovieTitle");

            migrationBuilder.AlterColumn<int>(
                name: "TMDbUserId",
                table: "MovieTitle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TMDbUserId1",
                table: "MovieTitle",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieTitle_TMDbUserId1",
                table: "MovieTitle",
                column: "TMDbUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTitle_AspNetUsers_TMDbUserId1",
                table: "MovieTitle",
                column: "TMDbUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
