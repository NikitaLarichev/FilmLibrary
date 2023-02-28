using FilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
    //Этот класс просто добавляет в базу данных несколько фильмов, актёров и продюсеров, чтоб было с чем работать, в реальном приложении его бы не было!!!
    public class DbFill
    {
        DbService service;
        public DbFill()
        {
            service = DbService.Instance;
        }
        public async Task<bool> AddFilmsAndActorsAsync()
        {
            try
            {
                if (await AddActors() == false)
                    return false;
                if (await AddFilms() == false)
                    return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async Task<Country> GetCountry(string countryName)
        {
           return (await service.GetCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new Country() { Name = countryName };
        }
        private async Task<DemoCountry> GetDemoCountry(string countryName)
        {
            return (await service.GetDemoCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new DemoCountry() { Name = countryName };
        }
        private async Task<Genre> GetGenre(string genreName)
        {
            return (await service.GetGenresAsync()).FirstOrDefault(c => c.Name == genreName) ?? new Genre() { Name = genreName };
        }
        private async Task<Actor> GetActor(string firstName, string lastName)
        {
            return (await service.GetActorsAsync()).FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }
        private async Task<Producer> GetProducer(string firstName, string lastName)
        {
            return (await service.GetProducersAsync()).FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }
        private async Task<bool> ActorToProducer(Actor actor)
        {
            Producer producer = new Producer()
            {
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                Sex = actor.Sex,
                Birthday = actor.Birthday,
                Nation = actor.Nation,
                City = actor.City,
                FinState = actor.FinState
            };
            try
            {
                await service.InsertToDbAsync(producer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async Task<bool> AddActors()
        {
            try
            {
                Actor a1 = new Actor()
                {
                    FirstName = "Том",
                    LastName = "Круз",
                    Sex = "мужской",
                    Birthday = new DateTime(1962, 7, 3),
                    Nation = await GetCountry("США"),
                    City = "Нью-Йорк",
                    FinState = 480000000
                };               
                await service.InsertToDbAsync(a1);
                await ActorToProducer(a1);

                Actor a2 = new Actor()
                {
                    FirstName = "Джонни",
                    LastName = "Дэпп",
                    Sex = "мужской",
                    Birthday = new DateTime(1963, 6, 9),
                    Nation = await GetCountry("США"),
                    City = "Оунсборо",
                    FinState = 145000000
                };
                await service.InsertToDbAsync(a2);
                await ActorToProducer(a2);

                Producer p1 = new Producer()
                {
                    FirstName = "Гэйл",
                    LastName = "Бёрман",
                    Sex = "мужской",
                    Birthday = new DateTime(1956, 8, 17),
                    Nation = await GetCountry("США"),
                    City = "Бруклин",
                    FinState = 65000000
                };
                await service.InsertToDbAsync(p1);

                Actor a3 = new Actor()
                {
                    FirstName = "Мэл",
                    LastName = "Гибсон",
                    Sex = "мужской",
                    Birthday = new DateTime(1956, 1, 3),
                    Nation = await GetCountry("США"),
                    City = "Пикскил",
                    FinState = 425000000
                };
                await service.InsertToDbAsync(a3);
                await ActorToProducer(a3);

                Actor a4 = new Actor()
                {
                    FirstName = "Кира",
                    LastName = "Найтли",
                    Sex = "женский",
                    Birthday = new DateTime(1985, 3, 26),
                    Nation = await GetCountry("США"),
                    City = "Лондон",
                    FinState = 85000000
                };
                await service.InsertToDbAsync(a4);

                Actor a5 = new Actor
                {
                    FirstName = "Арнольд",
                    LastName = "Шварцнеггер",
                    Sex = "мужской",
                    Birthday = new DateTime(1947, 7, 30),
                    Nation = await GetCountry("Австрия"),
                    City = "Таль",
                    FinState = 400000000
                };
                await service.InsertToDbAsync(a5);

                Producer p2 = new Producer()
                {
                    FirstName = "Джеймс",
                    LastName = "Кэмерон",
                    Sex = "мужской",
                    Birthday = new DateTime(1954, 8, 16),
                    Nation = await GetCountry("Канада"),
                    City = "Капускасинг",
                    FinState = 700000000
                };
                await service.InsertToDbAsync(p2);

                Actor a6 = new Actor()
                {
                    FirstName = "Линда",
                    LastName = "Хамильтон",
                    Sex = "женский",
                    Birthday = new DateTime(1956, 9, 26),
                    Nation = await GetCountry("США"),
                    City = "Солсберри",
                    FinState = 70000000
                };
                await service.InsertToDbAsync(a6);

                Producer p3 = new Producer()
                {
                    FirstName = "Джерри",
                    LastName = "Брукхаймер",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 9, 21),
                    Nation = await GetCountry("США"),
                    City = "Детройт",
                    FinState = 350000000
                };
                await service.InsertToDbAsync(p3);

                Actor a7 = new Actor()
                {
                    FirstName = "Венсан",
                    LastName = "Кассель",
                    Sex = "мужской",
                    Birthday = new DateTime(1966, 11, 23),
                    Nation = await GetCountry("Франция"),
                    City = "Париж",
                    FinState = 77000000
                };
                await service.InsertToDbAsync(a7);
                await ActorToProducer(a7);

                Actor a8 = new Actor()
                {
                    FirstName = "Моника",
                    LastName = "Белуччи",
                    Sex = "женский",
                    Birthday = new DateTime(1966, 11, 23),
                    Nation = await GetCountry("Франция"),
                    City = "Париж",
                    FinState = 77000000
                };
                await service.InsertToDbAsync(a8);

                Producer p4 = new Producer()
                {
                    FirstName = "Дэвид",
                    LastName = "Гэффин",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 2, 21),
                    Nation = await GetCountry("США"),
                    City = "Бруклин",
                    FinState = 121000000
                };
                await service.InsertToDbAsync(p4);

                Actor a9 = new Actor()
                {
                    FirstName = "Кирстен",
                    LastName = "Данст",
                    Sex = "женский",
                    Birthday = new DateTime(1982, 4, 30),
                    Nation = await GetCountry("США"),
                    City = "Нью-Джерси",
                    FinState = 98000000
                };
                await service.InsertToDbAsync(a9);

                Actor a10 = new Actor()
                {
                    FirstName = "Брэд",
                    LastName = "Питт",
                    Sex = "мужской",
                    Birthday = new DateTime(1963, 12, 18),
                    Nation = await GetCountry("США"),
                    City = "Шони",
                    FinState = 234000000
                };
                await service.InsertToDbAsync(a10);

                Actor a11 = new Actor()
                {
                    FirstName = "Бэн",
                    LastName = "Кингсли",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 12, 31),
                    Nation = await GetCountry("Великобритания"),
                    City = "Скарборо",
                    FinState = 187000000
                };
                await service.InsertToDbAsync(a11);

                Actor a12 = new Actor()
                {
                    FirstName = "Кейт",
                    LastName = "Бекинсейл",
                    Sex = "женский",
                    Birthday = new DateTime(1973, 7, 26),
                    Nation = await GetCountry("Великобритания"),
                    City = "Лондон",
                    FinState = 95000000
                };
                await service.InsertToDbAsync(a12);

                Producer p5 = new Producer()
                {
                    FirstName = "Гэйл Энн",
                    LastName = "Хёрд",
                    Sex = "женский",
                    Birthday = new DateTime(1955, 10, 25),
                    Nation = await GetCountry("США"),
                    City = "Лос-Анжелес",
                    FinState = 98000000
                };
                await service.InsertToDbAsync(p5);

                Producer p6 = new Producer()
                {
                    FirstName = "Сергей",
                    LastName = "Сельянов",
                    Sex = "мужской",
                    Birthday = new DateTime(1955, 8, 21),
                    Nation = await GetCountry("Россия"),
                    City = "Москва",
                    FinState = 6000000
                };
                await service.InsertToDbAsync(p6);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async Task<bool> AddFilms()
        {
            try
            {
                Film film1 = new Film()
                {
                    Name = "Терминатор",
                    Year = new DateTime(1984, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.1f,
                    Budget = 6400000,
                    BoxOffice = 78371200,
                    Viewers = 2700000000,
                    FilmProducer = await GetProducer("Гэйл Энн", "Хёрд")
                };
                film1.Genres.Add(await GetGenre("Боевик"));
                film1.Genres.Add(await GetGenre("Фантастика"));

                film1.Actors.Add(await GetActor("Арнольд", "Шварцнеггер"));
                film1.Actors.Add(await GetActor("Линда", "Хамильтон"));

                film1.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Индия")));

                await service.InsertToDbAsync(film1);

                Film film2 = new Film()
                {
                    Name = "Пираты карибского моря",
                    Year = new DateTime(2003, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.3f,
                    Budget = 140000000,
                    BoxOffice = 654264015,
                    Viewers = 2700000000,
                    FilmProducer = await GetProducer("Джерри", "Брукхаймер"),
                };
                film2.Genres.Add(await GetGenre("Приключение"));
                film2.Genres.Add(await GetGenre("Фэнтези"));

                film2.Actors.Add(await GetActor("Джонни", "Дэпп"));
                film2.Actors.Add(await GetActor("Кира", "Найтли"));

                film2.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film2);

                Film film3 = new Film()
                {
                    Name = "Миссия невыполнима",
                    Year = new DateTime(1996, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 7.2f,
                    Budget = 80000000,
                    BoxOffice = 457696359,
                    Viewers = 2600000000,
                    FilmProducer = await GetProducer("Том", "Круз"),
                };
                film3.Genres.Add(await GetGenre("Боевик"));
                film3.Genres.Add(await GetGenre("Детектив"));

                film3.Actors.Add(await GetActor("Том", "Круз"));

                film3.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film3);

                Film film4 = new Film()
                {
                    Name = "Миссия невыполнима 2",
                    Year = new DateTime(2000, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 7.2f,
                    Budget = 125000000,
                    BoxOffice = 546388015,
                    Viewers = 2400000000,
                    FilmProducer = await GetProducer("Том", "Круз"),
                };
                film4.Genres.Add(await GetGenre("Боевик"));
                film4.Genres.Add(await GetGenre("Детектив"));

                film4.Actors.Add(await GetActor("Том", "Круз"));

                film4.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film4);

                Film film5 = new Film()
                {
                    Name = "Необратимость",
                    Year = new DateTime(2002, 1, 1),
                    CountryProduce = await GetCountry("Франция"),
                    Rating = 7.1f,
                    Budget = 75000,
                    BoxOffice = 792200,
                    Viewers = 120000000,
                    FilmProducer = await GetProducer("Венсан", "Кассель"),
                };
                film5.Genres.Add(await GetGenre("Драма"));
                film5.Genres.Add(await GetGenre("Триллер"));

                film5.Actors.Add(await GetActor("Венсан", "Кассель"));
                film5.Actors.Add(await GetActor("Моника", "Белуччи"));

                film5.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film5.CountriesDemonstration.Add((await GetDemoCountry("Франция")));


                await service.InsertToDbAsync(film5);

                Film film6 = new Film()
                {
                    Name = "Топ ган: Мэверик",
                    Year = new DateTime(2022, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.0f,
                    Budget = 170000000,
                    BoxOffice = 1488000000,
                    Viewers = 2250000000,
                    FilmProducer = await GetProducer("Джерри", "Брукхаймер"),
                };
                film6.Genres.Add(await GetGenre("Боевик"));
                film6.Genres.Add(await GetGenre("Драма"));

                film6.Actors.Add(await GetActor("Том", "Круз"));

                film6.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film6.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));


                await service.InsertToDbAsync(film6);

                Film film7 = new Film()
                {
                    Name = "Интервью с вампиром",
                    Year = new DateTime(1994, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 7.8f,
                    Budget = 60000000,
                    BoxOffice = 223664608,
                    Viewers = 2850000000,
                    FilmProducer = await GetProducer("Дэвид", "Гэффин"),
                };
                film7.Genres.Add(await GetGenre("Ужасы"));
                film7.Genres.Add(await GetGenre("Драма"));
                film7.Genres.Add(await GetGenre("Фэнтези"));

                film7.Actors.Add(await GetActor("Брэд", "Питт"));
                film7.Actors.Add(await GetActor("Том", "Круз"));
                film7.Actors.Add(await GetActor("Кирстен", "Данст"));

                film7.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film7.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));


                await service.InsertToDbAsync(film7);

                Film film8 = new Film()
                {
                    Name = "Обитель проклятых",
                    Year = new DateTime(2014, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 6.8f,
                    Budget = 1000000,
                    BoxOffice = 2467000,
                    Viewers = 2850000000,
                    FilmProducer = await GetProducer("Мэл", "Гибсон"),
                };
                film8.Genres.Add(await GetGenre("Триллер"));

                film8.Actors.Add(await GetActor("Бэн", "Кингсли"));
                film8.Actors.Add(await GetActor("Кейт", "Бекинсейл"));

                film8.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film8.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film8);

                Film film9 = new Film()
                {
                    Name = "Терминатор 2",
                    Year = new DateTime(1991, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.4f,
                    Budget = 102000000,
                    BoxOffice = 520881154,
                    Viewers = 3100000000,
                    FilmProducer = await GetProducer("Джеймс", "Кэмерон")
                };
                film9.Genres.Add(await GetGenre("Боевик"));
                film9.Genres.Add(await GetGenre("Фантастика"));

                film9.Actors.Add(await GetActor("Арнольд", "Шварцнеггер"));
                film9.Actors.Add(await GetActor("Линда", "Хамильтон"));

                film9.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film9.CountriesDemonstration.Add((await GetDemoCountry("Индия")));

                await service.InsertToDbAsync(film9);

                Film film10 = new Film()
                {
                    Name = "Тайна печати дракона",
                    Year = new DateTime(2019, 1, 1),
                    CountryProduce = await GetCountry("Россия"),
                    Rating = 8.4f,
                    Budget = 50000000,
                    BoxOffice = 14051279,
                    Viewers = 180000000,
                    FilmProducer = await GetProducer("Сергей", "Сельянов")
                };
                film10.Genres.Add(await GetGenre("Боевик"));
                film10.Genres.Add(await GetGenre("Фэнтези"));
                film10.Genres.Add(await GetGenre("Приключение"));

                film10.Actors.Add(await GetActor("Арнольд", "Шварцнеггер"));

                film10.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film10.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film10.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film10.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film10.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film10.CountriesDemonstration.Add((await GetDemoCountry("Индия")));

                await service.InsertToDbAsync(film10);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
