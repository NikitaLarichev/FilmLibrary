using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class ExtraDataService
    {
        private DbService db;
        public static ExtraDataService Instance { get => ExtraDataServiceCreate.instance; }
        private ExtraDataService()
        {
            db = DbService.Instance;
        }
        private class ExtraDataServiceCreate
        {
            internal static readonly ExtraDataService instance = new ExtraDataService();
        }


        public async Task<Genre> GetGenreAsync(string genreName)
        {
            return (await db.GetGenresAsync()).FirstOrDefault(g => g.Name == genreName) ?? new Genre() { Name = genreName };
        }
        public async Task<List<Genre>> GetGenresAsync()
        {
            return await db.GetGenresAsync();
        }
        public async Task<Country> GetCountryAsync(string countryName)
        {
            return (await db.GetCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new Country() { Name = countryName };
        }
        public async Task<List<Country>> GetCountriesAsync()
        {
            return await db.GetCountriesAsync();
        }
        public async Task<DemoCountry> GetDemoCountryAsync(string countryName)
        {
            return (await db.GetDemoCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new DemoCountry() { Name = countryName };
        }
        public async Task<List<DemoCountry>> GetDemoCountriesAsync()
        {
            return await db.GetDemoCountriesAsync();
        }
    }
}
