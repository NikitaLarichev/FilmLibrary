using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
        public Genre()
        {
            Films = new List<Film>();   
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
