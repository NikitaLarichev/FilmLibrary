using FilmsLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Controls
{
    public class FilmFilters
    {
        public static FilmFilters Instance { get => FilmFiltersCreate.Create; }
        private FilmFilters() { }
        private class FilmFiltersCreate
        {
            internal static readonly FilmFilters Create = new FilmFilters();
        }
        public List<Film> GenreFilters(List<Film> list,List<Genre> genres)
        {
             return list.Where(f => genres.All(gl => f.Genres.Any(g => g.Name == gl.Name))).ToList();
        }
        public List<Film> ActorFilters(List<Film> list, List<Actor> actors)
        {
            return list.Where(f => actors.All(a => f.Actors.Any(ac => ac.FirstName == a.FirstName && ac.LastName == a.LastName))).ToList();
        }
        public List<Film> CountryFilters(List<Film> list, Country country)
        {
            return list.Where(f => f.CountryProduce.Name == country.Name).ToList();
        }
        public List<Film> ProducerFilters(List<Film> list, Producer producer)
        {
            return list.Where(f => f.FilmProducer.FirstName == producer.FirstName && f.FilmProducer.LastName == producer.LastName && f.FilmProducer.Birthday == producer.Birthday).ToList();
        }
        public List<Film> RatingFilters(List<Film> list, float firstValue, float lastValue)
        { 
            return list.Where(f => f.Rating >= firstValue && f.Rating <= lastValue).ToList();
        }
        public List<Film> YearFilters(List<Film> list, int firstValue, int lastValue)
        {
            return list.Where(f => f.Year.Year >= firstValue && f.Rating <= lastValue).ToList();
        }
        public List<Film> BudgetFilters(List<Film> list, decimal firstValue, decimal lastValue)
        {
            return list.Where(f => f.Budget >= firstValue && f.Budget <= lastValue).ToList();
        }
        public List<Film> BoxOfficeFilters(List<Film> list, decimal firstValue, decimal lastValue)
        {
            return list.Where(f => f.BoxOffice >= firstValue && f.BoxOffice <= lastValue).ToList();
        }
        public List<Film> DemoCountriesFilters(List<Film> list, List<DemoCountry> demo)
        {
            return list.Where(f => demo.All(dc => f.CountriesDemonstration.Any(c => c.Name == dc.Name))).ToList();
        }
    }
}
