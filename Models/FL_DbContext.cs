using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class FL_DbContext : DbContext
    {
        public FL_DbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DemoCountry> DemoCountries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
