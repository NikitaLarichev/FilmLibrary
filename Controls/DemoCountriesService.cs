using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class DemoCountriesService
    {
        private DbService db;
        public static DemoCountriesService Instance { get => DemoCountriesServiceCreate.instance; }
        private DemoCountriesService()
        {
            db = DbService.Instance;
        }
        private class DemoCountriesServiceCreate
        {
            internal static readonly DemoCountriesService instance = new DemoCountriesService();
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
