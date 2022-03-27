using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDb.DataAccess.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('Forrest Gump'," +
                "'The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.'," +
                "'55000000'," +
                "'678226133'," +
                "'tt0109830'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('John Cena'," +
                "'John Cena vs the World'," +
                "'1111'," +
                "'11111'," +
                "'11111'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
