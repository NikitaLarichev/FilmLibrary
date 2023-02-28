using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public Country CountryProduce { get; set; }
        public decimal Budget { get; set; }
        public decimal BoxOffice { get; set; }
        public long Viewers { get; set; }
        public ICollection<DemoCountry> CountriesDemonstration { get; set; }
        public Producer FilmProducer { get; set; }
        public float Rating { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public Film()
        {
            Genres = new List<Genre>();
            CountriesDemonstration=new List<DemoCountry>();
            Actors = new List<Actor>();
        }
        public override string ToString()
        {
            return $"{Name}({Year.Year})";
        }
    }

}
