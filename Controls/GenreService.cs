using FilmsLibrary.Models;
using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Controls
{
    public class GenreService
    {
        private DbService db;
        public static GenreService Instance { get => GenreServiceCreate.instance; }
        private GenreService()
        {
            db = DbService.Instance;
        }
        private class GenreServiceCreate
        {
            internal static readonly GenreService instance = new GenreService();
        }
        public async Task<Genre> GetGenreAsync(string genreName)
        {
            return (await db.GetGenresAsync()).FirstOrDefault(g => g.Name == genreName) ?? new Genre() { Name = genreName };
        }
        public async Task<List<Genre>> GetGenresAsync()
        {
            return await db.GetGenresAsync();
        }
    }
}
