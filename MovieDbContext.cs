using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDbContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public MovieDbContext() : base()
        {
        }
    }
}
