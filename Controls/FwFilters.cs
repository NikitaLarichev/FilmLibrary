using FilmsLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary.Controls
{
    public class FwFilters
    {
        public static FwFilters Instance { get => FwFiltersCreate.Create; }
        private FwFilters() { }
        private class FwFiltersCreate
        {
            internal static readonly FwFilters Create = new FwFilters();
        }

        public List<IFilmWorker> SexFilter(List<IFilmWorker> list, string sex)
        {
            return list.Where(f => f.Sex == sex).ToList();
        }
        public List<IFilmWorker> BirthdayFilter(List<IFilmWorker> list, DateTime firstValue, DateTime lastValue)
        {
            return list.Where(f => f.Birthday >= firstValue.Date && f.Birthday <= lastValue.Date).ToList();
        }
        public List<IFilmWorker> NationFilter(List<IFilmWorker> list, Country country)
        {
            return list.Where(f => f.Nation == country).ToList();
        }
        public List<IFilmWorker> CityFilter(List<IFilmWorker> list, string city)
        {
            return list.Where(f => f.City == city).ToList();
        }
        public List<IFilmWorker> FinFilter(List<IFilmWorker> list, decimal firstValue, decimal lastValue)
        {
            return list.Where(f => f.FinState >= firstValue && f.FinState <= lastValue).ToList();
        }
        public List<IFilmWorker> FilmFilter(List<IFilmWorker> list, Film film)
        {
            return list.Where(fw => fw.GetFilms().ToList().Any(f => f.Name == film.Name && f.Year == film.Year) == true).ToList();       
        }
    }
}
