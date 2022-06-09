using Microsoft.EntityFrameworkCore;
using Movies.API.Model;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        //create seeding method
        public static void Seed(MoviesContext context)
        {
            if (context.Movies.Any())
                return; // DB has been seeded

            context.Movies.AddRange(new List<Movie>
            {
                //add 10 movies to list of movies to be seeded into DB with properties Id, Title, ReleaseDate, Genre, Rating, ImageUrl, Owner
                new Movie { Id = 1, Title = "The Shawshank Redemption", ReleaseDate = new System.DateTime(1994, 9, 14), Genre = "Drama", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg", Owner = "admin" },
                new Movie { Id = 2, Title = "The Godfather", ReleaseDate = new System.DateTime(1972, 3, 24), Genre = "Crime", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg", Owner = "admin" },
                new Movie { Id = 3, Title = "The Godfather: Part II", ReleaseDate = new System.DateTime(1974, 12, 20), Genre = "Crime", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg", Owner = "admin" },
                new Movie { Id = 4, Title = "The Dark Knight", ReleaseDate = new System.DateTime(2008, 7, 18), Genre = "Action", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg", Owner = "admin" }

            });
            context.SaveChanges();
        }
    }
}
