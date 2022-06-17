using Movies.Client.Models;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await Task.FromResult(new List<Movie>
            {
                //add 10 movies to list of movies to be seeded into DB with properties Id, Title, ReleaseDate, Genre, Rating, ImageUrl, Owner
                new Movie { Id = 1, Title = "The Shawshank Redemption", ReleaseDate = new System.DateTime(1994, 9, 14), Genre = "Drama", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg", Owner = "admin" },
                new Movie { Id = 2, Title = "The Godfather", ReleaseDate = new System.DateTime(1972, 3, 24), Genre = "Crime", Rating = "R", ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg", Owner = "admin" }
            });
        }

        public Task<Movie> GetMovie(int id)
        {
            throw new System.NotImplementedException();
        }
        
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
