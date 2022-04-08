using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDb.DataAccess.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // This migration has been used to create test data sued during the development of the apps

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

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('The Rock: Taking The World'," +
                "'How the rock became Chancellor of Earth'," +
                "'1111'," +
                "'11111'," +
                "'11111'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('Smith Slap'," +
                "'How the world was shocked by a simple slap.'," +
                "'1111'," +
                "'11111'," +
                "'11111'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('Lethal Weapon 9'," +
                "'He was too old for this s**t.'," +
                "'1111'," +
                "'11111'," +
                "'11111'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('Fast 29'," +
                "'Paul Walker never died, and now he wants to kill Dom.'," +
                "'1111'," +
                "'11111'," +
                "'11111'," +
                "'https://www.themoviedb.org/t/p/original/saHP97rTPS5eLmrLQEcANmKrsFl.jpg'," +
                "'1994'," +
                "'142' )"

                );

            migrationBuilder.Sql("INSERT INTO " +
                "Movies (Title, Overview, Budget, Revenue, ImdbId, PosterPath, ReleaseDate, Runtime) " +
                "VALUES ('Transformers: Little Prime'," +
                "'Little Optimus Prime Jr gets bullied by Chad the decepticon.'," +
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
            migrationBuilder.Sql("DELETE FROM [Movies]");
        }
    }
}
