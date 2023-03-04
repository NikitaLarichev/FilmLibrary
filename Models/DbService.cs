using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary.Models
{

    namespace FilmsLibrary
    {
        public class DbService
        {
            private FL_DbContext _context;
            public static DbService Instance { get => DbServiceCreate.instance; }
            private DbService()
            {
                _context = new FL_DbContext();
            }
            private class DbServiceCreate
            {
                internal static readonly DbService instance = new DbService();
            }
            public async Task<List<Genre>> GetGenresAsync()
            {
                return await Task.Run(() => _context.Genres.Include("Films").ToList());
            }
            public async Task<List<Country>> GetCountriesAsync()
            {
                return await Task.Run(() => _context.Countries.Include("Actors").Include("Producers").Include("FilmProduce").ToList());
            }
            public async Task<List<DemoCountry>> GetDemoCountriesAsync()
            {
                return await Task.Run(() => _context.DemoCountries.Include("Films").ToList());
            }
            public async Task<List<Actor>> GetActorsAsync()
            {
                return await Task.Run(() => _context.Actors.Include("Filmography").Include("Nation").ToList());
            }
            public async Task<List<Producer>> GetProducersAsync()
            {
                return await Task.Run(() => _context.Producers.Include("FilmsProduce").Include("Nation").ToList());
            }
            public async Task<List<Film>> GetFilmsAsync()
            {
                return await Task.Run(() => _context.Films.Include("Genres").Include("CountryProduce").Include("CountriesDemonstration").Include("FilmProducer").Include("Actors").ToList());
            }
            public async Task<bool> InsertToDbAsync(Actor actor)
            {
                try
                {
                    if ((await GetActorsAsync()).Any(w => w.FirstName == actor.FirstName && w.LastName == actor.LastName && w.Birthday.Date == actor.Birthday.Date) == true)
                        return false;
                    _context.Actors.Add(actor);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            public async Task<bool> InsertToDbAsync(Producer producer)
            {
                try
                {
                    if ((await GetProducersAsync()).Any(w => w.FirstName == producer.FirstName && w.LastName == producer.LastName && w.Birthday.Date == producer.Birthday.Date) == true)
                        return false;
                    _context.Producers.Add(producer);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            public async Task<bool> InsertToDbAsync(Film film)
            {
                try
                {
                    if ((await GetFilmsAsync()).Any(f => f.Name == film.Name && f.Year.Year == film.Year.Year))
                        return false;
                    _context.Films.Add(film);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public async Task<bool> RemoveFromDbAsync(Film film)
            {
                try
                {
                    if (_context.Films.Any(f => f.Name == film.Name && f.Year == film.Year) == false)
                        return false;
                    _context.Films.Remove(film);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public async Task<bool> RemoveFromDbAsync(Actor actor)
            {
                try
                {
                    if (_context.Actors.Any(a => a.FirstName == actor.FirstName && a.LastName == actor.LastName && a.Birthday == actor.Birthday) == false)
                        return false;
                    _context.Actors.Remove(actor);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public async Task<bool> RemoveFromDbAsync(Producer producer)
            {
                try
                {
                    if (_context.Producers.Any(p => p.FirstName == producer.FirstName && p.LastName == producer.LastName && p.Birthday == producer.Birthday) == false)
                        return false;
                    _context.Producers.Remove(producer);
                    await Task.Run(() => _context.SaveChanges());
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            //public async Task<bool> RedactFilm(Film oldFilm, Film newFilm)
            //{
            //    try
            //    {

            //        Film temp = (await GetFilmsAsync()).FirstOrDefault(f => f.Id == oldFilm.Id);
            //        if (temp != null)
            //        {
            //            temp = newFilm;
            //            await _context.SaveChangesAsync();
            //        }
            //        return true;
            //    }
            //    catch (Exception)
            //    {
            //        return false;
            //    }

            public async Task<bool> SaveChangesDbAsync()
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
