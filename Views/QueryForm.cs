﻿using FilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary.Views
{
    public partial class QueryForm : Form
    {
        DbService service;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet data;
        SqlCommand command;
        public QueryForm()
        {
            InitializeComponent();
            service = DbService.Instance;
            connection = new SqlConnection();
            adapter = new SqlDataAdapter();
            command = new SqlCommand();
            command.Connection = connection;
            this.Load += QueryForm_Load;
        }

        private async void QueryForm_Load(object sender, EventArgs e)
        {
            (await service.GetGenresAsync()).ForEach(g => Genre_comboBox1.Items.Add(g));
            (await service.GetGenresAsync()).ForEach(g => Genre_comboBox2.Items.Add(g));
            (await service.GetGenresAsync()).ForEach(g => Genre_comboBox3.Items.Add(g));

            (await service.GetCountriesAsync()).ForEach(c => Country_comboBox1.Items.Add(c));
            (await service.GetCountriesAsync()).ForEach(c => Country_comboBox2.Items.Add(c));

            //(await service.GetFilmsAsync()).ForEach(f => Film_comboBox1.Items.Add(f));

            (await service.GetActorsAsync()).ForEach(a => Actor_comboBox6.Items.Add(a));
            (await service.GetActorsAsync()).ForEach(a => Actor_comboBox7.Items.Add(a));

            Year_numericUpDown6.Maximum = DateTime.Now.Year;
            Year_numericUpDown6.Minimum = 1920;

            Genre_comboBox1.SelectedIndex = 0;
            Genre_comboBox2.SelectedIndex = 0;
            Genre_comboBox3.SelectedIndex = 0;
            Country_comboBox1.SelectedIndex = 0;
            Country_comboBox2.SelectedIndex = 0;
            Actor_comboBox6.SelectedIndex = 0;
            Actor_comboBox7.SelectedIndex = 0;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = (await service.GetFilmsAsync()).Where(f => f.Budget < ((Film)Film_comboBox1.SelectedItem).Budget && f.Genres.Any(g => g == (Genre)Genre_comboBox1.SelectedItem) == true).ToList();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void Country_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_comboBox1.Items.Clear();
            (await service.GetCountriesAsync()).FirstOrDefault(c => c == (Country)Country_comboBox1.SelectedItem).FilmProduce.ToList().ForEach(f => Film_comboBox1.Items.Add(f));
            if(Film_comboBox1.Items.Count > 0)
                Film_comboBox1.SelectedIndex = 0;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            float chip = (await service.GetFilmsAsync()).Where(f => f.CountryProduce == (Country)Country_comboBox2.SelectedItem && f.Genres.Any(g => g == (Genre)Genre_comboBox2.SelectedItem) == true && f.Budget <= 10000000).Count();
            float expensive = (await service.GetFilmsAsync()).Where(f => f.CountryProduce == (Country)Country_comboBox2.SelectedItem && f.Genres.Any(g => g == (Genre)Genre_comboBox2.SelectedItem) == true && f.Budget > 10000000).Count();
            float all = chip + expensive;
            float chipPart = chip / (all / 100);
            float expensivePart = expensive / (all / 100);
            listBox1.Items.Add("Дешёвые фильмы "  + chipPart + " %");
            listBox1.Items.Add("Дорогие фильмы " + expensivePart + " %");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int max = (await service.GetDemoCountriesAsync()).Max(c => c.Films.ToList().Where(f => f.Genres.Any(g => g == (Genre)Genre_comboBox3.SelectedItem) == true).Count());
            var list = (await service.GetDemoCountriesAsync()).Where(c => c.Films.ToList().Where(f => f.Genres.Any(g => g == (Genre)Genre_comboBox3.SelectedItem) == true).Count() == max).ToList();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = (await service.GetActorsAsync()).Where(a => a.Sex == "мужской" || a.City == "Париж").ToList();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<IFilmWorker> list1 = (await service.GetActorsAsync()).Where(a => a.Sex == "женский" || a.FinState > 100000000).ToList<IFilmWorker>();
            List<IFilmWorker> list = (await service.GetProducersAsync()).Where(a => list1.Any(a1 => a1.FirstName == a.FirstName && a1.LastName == a.LastName && a1.Birthday == a.Birthday) == true).ToList<IFilmWorker>();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = (await service.GetFilmsAsync()).Where(f => f.Actors.Any(a => a == (Actor)Actor_comboBox6.SelectedItem) == true && f.Year.Year == Year_numericUpDown6.Value).ToList();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = (await service.GetProducersAsync()).ToList<IFilmWorker>().Where(p => p.FinState > ((IFilmWorker)Actor_comboBox7.SelectedItem).FinState).ToList();
            list.ForEach(o => listBox1.Items.Add(o));
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<IFilmWorker> list1 = (await service.GetActorsAsync()).ToList<IFilmWorker>();
            List<IFilmWorker> list = (await service.GetProducersAsync()).Where(a => list1.Any(a1 => a1.FirstName == a.FirstName && a1.LastName == a.LastName && a1.Birthday == a.Birthday) == true).ToList<IFilmWorker>();
            list.ForEach(o => listBox1.Items.Add(o));
        }
    }
}
