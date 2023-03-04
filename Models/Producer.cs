using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Producer : FilmWorker, IFilmWorker
    {
        public ICollection<Film> FilmsProduce { get; set; }
        public Producer()
        {
            FilmsProduce = new List<Film>();
        }
        public ICollection<Film> GetFilms()
        {
            return FilmsProduce;
        }
    }
}
