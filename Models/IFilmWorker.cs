using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public interface IFilmWorker
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Sex { get; set; }
        DateTime Birthday { get; set; }
        Country Nation { get; set; }
        string City { get; set; }
        Decimal FinState { get; set; }

        ICollection<Film> GetFilms();
    }
}
