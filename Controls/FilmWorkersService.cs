using FilmsLibrary.Models.FilmsLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class FilmWorkersService
    {
        private DbService db;
        public static FilmWorkersService Instance { get => FilmWorkersServiceCreate.instance; }
        private FilmWorkersService()
        {
            db = DbService.Instance;
        }
        private class FilmWorkersServiceCreate
        {
            internal static readonly FilmWorkersService instance = new FilmWorkersService();
        }
        public async Task<List<IFilmWorker>> GetFilmWorkersAsync(Type returnType)
        {
            List<IFilmWorker> list = null;
            if (returnType == typeof(List<Actor>))
                list = (await db.GetActorsAsync()).ToList<IFilmWorker>();
            else if (returnType == typeof(List<Producer>))
                list = (await db.GetProducersAsync()).ToList<IFilmWorker>();
            return list;
        }
        public async Task<IFilmWorker> GetActorAsync(string FirstName, string LastName)
        {
            return (await db.GetActorsAsync()).FirstOrDefault(a => a.FirstName == FirstName && a.LastName == LastName);
        }
        public async Task<IFilmWorker> GetActorAsync(string AllName)
        {
            return (await db.GetActorsAsync()).FirstOrDefault(a => a.ToString() == AllName);
        }
        public async Task<IFilmWorker> GetActorAsync(IFilmWorker worker)
        {
            return (await db.GetActorsAsync()).FirstOrDefault(a => a.FirstName == worker.FirstName && a.LastName == worker.LastName);
        }
        public async Task<IFilmWorker> GetProducerAsync(string FirstName, string LastName)
        {
            return (await db.GetProducersAsync()).FirstOrDefault(a => a.FirstName == FirstName && a.LastName == LastName);
        }
        public async Task<IFilmWorker> GetProducerAsync(string AllName)
        {
            return (await db.GetProducersAsync()).FirstOrDefault(a => a.ToString() == AllName);
        }
        public async Task<IFilmWorker> GetProducerAsync(IFilmWorker worker)
        {
            return (await db.GetProducersAsync()).FirstOrDefault(a => a.FirstName == worker.FirstName && a.LastName == worker.LastName);
        }
        public async Task<bool> FwIsActor(IFilmWorker worker)
        {
            return (await db.GetActorsAsync()).Any(f => f.FirstName == worker.FirstName && f.LastName == worker.LastName && f.Birthday == worker.Birthday);
        }
        public async Task<bool> FwIsProducer(IFilmWorker worker)
        {
            return (await db.GetProducersAsync()).Any(f => f.FirstName == worker.FirstName && f.LastName == worker.LastName && f.Birthday == worker.Birthday);
        }
        public async Task<bool> IsExistAsync(IFilmWorker worker)
        {
            if (worker is Actor)
                return (await db.GetActorsAsync()).Any(a => a.FirstName == worker.FirstName && a.LastName == worker.LastName);
            else if (worker is Producer)
                return (await db.GetProducersAsync()).Any(a => a.FirstName == worker.FirstName && a.LastName == worker.LastName);
            return false;
        }
        public async Task<bool> RemoveFWAsync(IFilmWorker worker)
        {
            try
            {
                if(await IsExistAsync(worker) == true)
                {
                    if (worker is Actor)
                        await db.RemoveFromDbAsync((Actor)worker);
                    else if (worker is Producer)
                        await db.RemoveFromDbAsync((Producer)worker);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }       
        }
        public async Task<bool> AddFWAsync(IFilmWorker worker)
        {
            try
            {
                if (await IsExistAsync(worker) == false)
                {
                    if (worker is Actor)
                        await db.InsertToDbAsync((Actor)worker);
                    else if (worker is Producer)
                        await db.InsertToDbAsync((Producer)worker);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
