using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data.ContextConfigurations
{
    public class MovieContextConfiguration : IEntityTypeConfiguration<Movie>
    {
        private Guid[] _ids;

        public MovieContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .HasData(
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Batman Begins",
                    Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2005, 06, 25),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id= Guid.NewGuid(),
                    Title = "The Dark Knight",
                    Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2008, 07, 18),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Dark Knight Rises",
                    Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2012, 07, 20),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode IV – A New Hope",
                    Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                    Instructor = "George Lucas",
                    ReleaseDate = new DateTime(1977, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode V – The Empire Strikes Back",
                    Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                    Instructor = "Irvin Kershner",
                    ReleaseDate = new DateTime(1980, 05, 21),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode VI – Return of the Jedi",
                    Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                    Instructor = "Richard Marquand",
                    ReleaseDate = new DateTime(1983, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Black Widow",
                    Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                    Instructor = "Cate Shortland",
                    ReleaseDate = new DateTime(2021, 06, 29),
                    SuperheroId= _ids[2]
                });
        }
    }
}
