using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public abstract class FilmWorker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public Country Nation { get; set; }
        public string City { get; set; }
        public Decimal FinState { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
