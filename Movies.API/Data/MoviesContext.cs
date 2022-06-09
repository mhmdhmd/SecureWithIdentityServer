﻿using Microsoft.EntityFrameworkCore;
using Movies.API.Model;

namespace Movies.API.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
            MoviesContextSeed.Seed(this);
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
