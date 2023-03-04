using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class FilmsService
    {
        private DbService db;
        public static FilmsService Instance { get => FilmsServiceCreate.instance; }
        private FilmsService()
        {
            db = DbService.Instance;
        }
        private class FilmsServiceCreate
        {
            internal static readonly FilmsService instance = new FilmsService();
        }
        public async Task<List<Film>> GetFilmsAsync()
        {
            return await db.GetFilmsAsync();
        }
        public async Task<Film> GetFilmAsync(string name, int year)
        {
            return (await db.GetFilmsAsync()).FirstOrDefault(f => f.Name == name && f.Year.Year == year);
        }
        private async Task<bool> IsExists(Film film)
        {
            return (await db.GetFilmsAsync()).Any(f => f.Name == film.Name && f.Year == film.Year);
        }
        public async Task<bool> RemoveFilmAsync(Film film)
        {
            try
            {
                if (await IsExists(film) == true)
                {
                    await db.RemoveFromDbAsync(film);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        public async Task<bool> AddFilmAsync(Film film)
        {
            try
            {
                if (await IsExists(film) == false) 
                {
                    await db.InsertToDbAsync(film);
                    return true; 
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        public async Task<bool> SaveChangesDbAsync()
        {
            return await db.SaveChangesDbAsync();
        }

    }
}
