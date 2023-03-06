using FilmsLibrary.Models;
using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Controls
{
    public class CountriesService
    {
        private DbService db;
        public static CountriesService Instance { get => CountriesServiceCreate.instance; }
        private CountriesService()
        {
            db = DbService.Instance;
        }
        private class CountriesServiceCreate
        {
            internal static readonly CountriesService instance = new CountriesService();
        }
        public async Task<Country> GetCountryAsync(string countryName)
        {
            return (await db.GetCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new Country() { Name = countryName };
        }
        public async Task<List<Country>> GetCountriesAsync()
        {
            return await db.GetCountriesAsync();
        }
    }
}
