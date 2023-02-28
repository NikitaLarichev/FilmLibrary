using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Actor : FilmWorker, IFilmWorker
    {
        public ICollection<Film> Filmography { get; set; }
        public Actor()
        {
            Filmography = new List<Film>();
        }
    }
}
