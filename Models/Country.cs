using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Producer> Producers { get; set; }
        public ICollection<Film> FilmProduce { get; set; }
        public Country()
        {
            Actors = new List<Actor>();
            Producers = new List<Producer>();
            FilmProduce = new List<Film>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
