using FilmsLibrary.Controls;
using FilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Common;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
    //Этот класс просто добавляет в базу данных несколько фильмов, актёров и продюсеров, чтоб было с чем работать, в реальном приложении его бы не было!!!
    public class DbFill
    {
        FilmWorkersService fws;
        FilmsService fs;
        DemoCountriesService dcs;
        CountriesService cs;
        GenreService gs;
        public DbFill()
        {
            fws = FilmWorkersService.Instance;
            fs = FilmsService.Instance;
            dcs = DemoCountriesService.Instance;
            gs = GenreService.Instance;
            cs = CountriesService.Instance;
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
                await fws.AddFWAsync(producer);
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
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Нью-Йорк",
                    FinState = 480000000
                };               
                await fws.AddFWAsync(a1);
                await ActorToProducer(a1);

                Actor a2 = new Actor()
                {
                    FirstName = "Джонни",
                    LastName = "Дэпп",
                    Sex = "мужской",
                    Birthday = new DateTime(1963, 6, 9),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Оунсборо",
                    FinState = 145000000
                };

                await fws.AddFWAsync(a2);
                await ActorToProducer(a2);

                Producer p1 = new Producer()
                {
                    FirstName = "Гэйл",
                    LastName = "Бёрман",
                    Sex = "мужской",
                    Birthday = new DateTime(1956, 8, 17),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Бруклин",
                    FinState = 65000000
                };
                await fws.AddFWAsync(p1);

                Actor a3 = new Actor()
                {
                    FirstName = "Мэл",
                    LastName = "Гибсон",
                    Sex = "мужской",
                    Birthday = new DateTime(1956, 1, 3),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Пикскил",
                    FinState = 425000000
                };
                await fws.AddFWAsync(a3);
                await ActorToProducer(a3);

                Actor a4 = new Actor()
                {
                    FirstName = "Кира",
                    LastName = "Найтли",
                    Sex = "женский",
                    Birthday = new DateTime(1985, 3, 26),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Лондон",
                    FinState = 85000000
                };
                await fws.AddFWAsync(a4);

                Actor a5 = new Actor
                {
                    FirstName = "Арнольд",
                    LastName = "Шварцнеггер",
                    Sex = "мужской",
                    Birthday = new DateTime(1947, 7, 30),
                    Nation = await cs.GetCountryAsync("Австрия"),
                    City = "Таль",
                    FinState = 400000000
                };
                await fws.AddFWAsync(a5);

                Producer p2 = new Producer()
                {
                    FirstName = "Джеймс",
                    LastName = "Кэмерон",
                    Sex = "мужской",
                    Birthday = new DateTime(1954, 8, 16),
                    Nation = await cs.GetCountryAsync("Канада"),
                    City = "Капускасинг",
                    FinState = 700000000
                };
                await fws.AddFWAsync(p2);

                Actor a6 = new Actor()
                {
                    FirstName = "Линда",
                    LastName = "Хамильтон",
                    Sex = "женский",
                    Birthday = new DateTime(1956, 9, 26),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Солсберри",
                    FinState = 70000000
                };
                await fws.AddFWAsync(a6);

                Producer p3 = new Producer()
                {
                    FirstName = "Джерри",
                    LastName = "Брукхаймер",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 9, 21),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Детройт",
                    FinState = 350000000
                };
                await fws.AddFWAsync(p3);

                Actor a7 = new Actor()
                {
                    FirstName = "Венсан",
                    LastName = "Кассель",
                    Sex = "мужской",
                    Birthday = new DateTime(1966, 11, 23),
                    Nation = await cs.GetCountryAsync("Франция"),
                    City = "Париж",
                    FinState = 77000000
                };
                await fws.AddFWAsync(a7);
                await ActorToProducer(a7);

                Actor a8 = new Actor()
                {
                    FirstName = "Моника",
                    LastName = "Белуччи",
                    Sex = "женский",
                    Birthday = new DateTime(1966, 11, 23),
                    Nation = await cs.GetCountryAsync("Франция"),
                    City = "Париж",
                    FinState = 77000000
                };
                await fws.AddFWAsync(a8);

                Producer p4 = new Producer()
                {
                    FirstName = "Дэвид",
                    LastName = "Гэффин",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 2, 21),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Бруклин",
                    FinState = 121000000
                };
                await fws.AddFWAsync(p4);

                Actor a9 = new Actor()
                {
                    FirstName = "Кирстен",
                    LastName = "Данст",
                    Sex = "женский",
                    Birthday = new DateTime(1982, 4, 30),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Нью-Джерси",
                    FinState = 98000000
                };
                await fws.AddFWAsync(a9);

                Actor a10 = new Actor()
                {
                    FirstName = "Брэд",
                    LastName = "Питт",
                    Sex = "мужской",
                    Birthday = new DateTime(1963, 12, 18),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Шони",
                    FinState = 234000000
                };
                await fws.AddFWAsync(a10);

                Actor a11 = new Actor()
                {
                    FirstName = "Бэн",
                    LastName = "Кингсли",
                    Sex = "мужской",
                    Birthday = new DateTime(1943, 12, 31),
                    Nation = await cs.GetCountryAsync("Великобритания"),
                    City = "Скарборо",
                    FinState = 187000000
                };
                await fws.AddFWAsync(a11);

                Actor a12 = new Actor()
                {
                    FirstName = "Кейт",
                    LastName = "Бекинсейл",
                    Sex = "женский",
                    Birthday = new DateTime(1973, 7, 26),
                    Nation = await cs.GetCountryAsync("Великобритания"),
                    City = "Лондон",
                    FinState = 95000000
                };
                await fws.AddFWAsync(a12);

                Producer p5 = new Producer()
                {
                    FirstName = "Гэйл Энн",
                    LastName = "Хёрд",
                    Sex = "женский",
                    Birthday = new DateTime(1955, 10, 25),
                    Nation = await cs.GetCountryAsync("США"),
                    City = "Лос-Анжелес",
                    FinState = 98000000
                };
                await fws.AddFWAsync(p5);

                Producer p6 = new Producer()
                {
                    FirstName = "Сергей",
                    LastName = "Сельянов",
                    Sex = "мужской",
                    Birthday = new DateTime(1955, 8, 21),
                    Nation = await cs.GetCountryAsync("Россия"),
                    City = "Москва",
                    FinState = 6000000
                };
                await fws.AddFWAsync(p6);

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
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 8.1f,
                    Budget = 6400000,
                    BoxOffice = 78371200,
                    Viewers = 2700000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Гэйл Энн", "Хёрд")
                };
                film1.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film1.Genres.Add(await gs.GetGenreAsync("Фантастика"));

                film1.Actors.Add((Actor)await fws.GetActorAsync("Арнольд", "Шварцнеггер"));
                film1.Actors.Add((Actor)await fws.GetActorAsync("Линда", "Хамильтон"));

                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film1.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Индия")));

                await fs.AddFilmAsync(film1);

                Film film2 = new Film()
                {
                    Name = "Пираты карибского моря",
                    Year = new DateTime(2003, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 8.3f,
                    Budget = 140000000,
                    BoxOffice = 654264015,
                    Viewers = 2700000000,
                    FilmProducer =  (Producer)await fws.GetProducerAsync("Джерри", "Брукхаймер"),
                };
                film2.Genres.Add(await gs.GetGenreAsync("Приключение"));
                film2.Genres.Add(await gs.GetGenreAsync("Фэнтези"));

                film2.Actors.Add((Actor)await fws.GetActorAsync("Джонни", "Дэпп"));
                film2.Actors.Add((Actor)await fws.GetActorAsync("Кира", "Найтли"));

                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film2.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));

                await fs.AddFilmAsync(film2);

                Film film3 = new Film()
                {
                    Name = "Миссия невыполнима",
                    Year = new DateTime(1996, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 7.2f,
                    Budget = 80000000,
                    BoxOffice = 457696359,
                    Viewers = 2600000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Том", "Круз"),
                };
                film3.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film3.Genres.Add(await gs.GetGenreAsync("Детектив"));

                film3.Actors.Add((Actor)await fws.GetActorAsync("Том", "Круз"));

                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film3.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));

                await fs.AddFilmAsync(film3);

                Film film4 = new Film()
                {
                    Name = "Миссия невыполнима 2",
                    Year = new DateTime(2000, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 7.2f,
                    Budget = 125000000,
                    BoxOffice = 546388015,
                    Viewers = 2400000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Том", "Круз"),
                };
                film4.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film4.Genres.Add(await gs.GetGenreAsync("Детектив"));

                film4.Actors.Add((Actor)await fws.GetActorAsync("Том", "Круз"));

                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film4.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));

                await fs.AddFilmAsync(film4);

                Film film5 = new Film()
                {
                    Name = "Необратимость",
                    Year = new DateTime(2002, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("Франция"),
                    Rating = 7.1f,
                    Budget = 75000,
                    BoxOffice = 792200,
                    Viewers = 120000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Венсан", "Кассель"),
                };
                film5.Genres.Add(await gs.GetGenreAsync("Драма"));
                film5.Genres.Add(await gs.GetGenreAsync("Триллер"));

                film5.Actors.Add((Actor)await fws.GetActorAsync("Венсан", "Кассель"));
                film5.Actors.Add((Actor)await fws.GetActorAsync("Моника", "Белуччи"));

                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film5.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));


                await fs.AddFilmAsync(film5);

                Film film6 = new Film()
                {
                    Name = "Топ ган: Мэверик",
                    Year = new DateTime(2022, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 8.0f,
                    Budget = 170000000,
                    BoxOffice = 1488000000,
                    Viewers = 2250000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Джерри", "Брукхаймер"),
                };
                film6.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film6.Genres.Add(await gs.GetGenreAsync("Драма"));

                film6.Actors.Add((Actor)await fws.GetActorAsync("Том", "Круз"));

                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film6.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));


                await fs.AddFilmAsync(film6);

                Film film7 = new Film()
                {
                    Name = "Интервью с вампиром",
                    Year = new DateTime(1994, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 7.8f,
                    Budget = 60000000,
                    BoxOffice = 223664608,
                    Viewers = 2850000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Дэвид", "Гэффин"),
                };
                film7.Genres.Add(await gs.GetGenreAsync("Ужасы"));
                film7.Genres.Add(await gs.GetGenreAsync("Драма"));
                film7.Genres.Add(await gs.GetGenreAsync("Фэнтези"));

                film7.Actors.Add((Actor)await fws.GetActorAsync("Брэд", "Питт"));
                film7.Actors.Add((Actor)await fws.GetActorAsync("Том", "Круз"));
                film7.Actors.Add((Actor)await fws.GetActorAsync("Кирстен", "Данст"));

                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film7.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));


                await fs.AddFilmAsync(film7);

                Film film8 = new Film()
                {
                    Name = "Обитель проклятых",
                    Year = new DateTime(2014, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 6.8f,
                    Budget = 1000000,
                    BoxOffice = 2467000,
                    Viewers = 2850000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Мэл", "Гибсон"),
                };
                film8.Genres.Add(await gs.GetGenreAsync("Триллер"));

                film8.Actors.Add((Actor)await fws.GetActorAsync("Бэн", "Кингсли"));
                film8.Actors.Add((Actor)await fws.GetActorAsync("Кейт", "Бекинсейл"));

                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film8.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Сингапур")));

                await fs.AddFilmAsync(film8);

                Film film9 = new Film()
                {
                    Name = "Терминатор 2",
                    Year = new DateTime(1991, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("США"),
                    Rating = 8.4f,
                    Budget = 102000000,
                    BoxOffice = 520881154,
                    Viewers = 3100000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Джеймс", "Кэмерон")
                };
                film9.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film9.Genres.Add(await gs.GetGenreAsync("Фантастика"));

                film9.Actors.Add((Actor)await fws.GetActorAsync("Арнольд", "Шварцнеггер"));
                film9.Actors.Add((Actor)await fws.GetActorAsync("Линда", "Хамильтон"));

                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Аргентина")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Бразилия")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("США")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Канада")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Южная корея")));
                film9.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Индия")));

                await fs.AddFilmAsync(film9);

                Film film10 = new Film()
                {
                    Name = "Тайна печати дракона",
                    Year = new DateTime(2019, 1, 1),
                    CountryProduce = await cs.GetCountryAsync("Россия"),
                    Rating = 8.4f,
                    Budget = 50000000,
                    BoxOffice = 14051279,
                    Viewers = 180000000,
                    FilmProducer = (Producer)await fws.GetProducerAsync("Сергей", "Сельянов")
                };
                film10.Genres.Add(await gs.GetGenreAsync("Боевик"));
                film10.Genres.Add(await gs.GetGenreAsync("Фэнтези"));
                film10.Genres.Add(await gs.GetGenreAsync("Приключение"));

                film10.Actors.Add((Actor)await fws.GetActorAsync("Арнольд", "Шварцнеггер"));

                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Россия")));
                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Германия")));
                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Франция")));
                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Китай")));
                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Япония")));
                film10.CountriesDemonstration.Add((await dcs.GetDemoCountryAsync("Индия")));

                await fs.AddFilmAsync(film10);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
