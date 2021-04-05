using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

    public class razorcrudMovieContext : DbContext
    {
        public razorcrudMovieContext (DbContextOptions<razorcrudMovieContext> options)
            : base(options)
        {
        }

        public DbSet<razor_crud.Models.Movie> Movie { get; set; }
    }
