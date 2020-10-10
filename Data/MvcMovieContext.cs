using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MySql.Data.Entity;
using System;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        //public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
         : base(options)
        //: base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        private class DbConfigurationTypeAttribute : Attribute
        {
        }
    }
}
