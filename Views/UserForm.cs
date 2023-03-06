using FilmsLibrary.Controls;
using FilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary.Views
{
    public partial class UserForm : Form
    {
        FilmInfoForm filmInfoForm;
        FilmworkersFiltersForm extraFilters;
        List<Film> filmList;
        string userStatus = null;
        public UserForm(string userStatus)
        {
            InitializeComponent();
            this.userStatus = userStatus;
            if (userStatus == "Администратор")
                ExtraButtonLoad();
            filmList = new List<Film>();
            this.Load += UserForm_LoadAsync;
            Films_listBox.DoubleClick += Films_listBox_DoubleClick;
            Genre_listBox.DoubleClick += Genre_listBox_DoubleClick;
            Actor_listBox.DoubleClick += Actor_listBox_DoubleClick;

            Genre_comboBox.SelectedIndex = 0;
            Actor_comboBox.SelectedIndex = 0;
            Producer_comboBox.SelectedIndex = 0;
            Country_comboBox.SelectedIndex = 0;
            Sorting_comboBox.SelectedIndex = 0;
            DemoCountry_comboBox.SelectedIndex = 0;

            DemoCountries_listBox.DoubleClick += DemoCountries_listBox_DoubleClick;
            Genre_comboBox.SelectedIndexChanged += Genre_comboBox_SelectedIndexChanged;
            Actor_comboBox.SelectedIndexChanged += Actor_comboBox_SelectedIndexChanged;
            Producer_comboBox.SelectedIndexChanged += Producer_comboBox_SelectedIndexChanged;
            Country_comboBox.SelectedIndexChanged += Country_comboBox_SelectedIndexChanged;
            Sorting_comboBox.SelectedIndexChanged += Sorting_comboBox_SelectedIndexChanged;
            DemoCountry_comboBox.SelectedIndexChanged += DemoCountry_comboBox_SelectedIndexChanged;

        }
        private void ExtraButtonLoad()
        {
            DeleteFilm_button.Enabled = true;
            DeleteFilm_button.Visible = true;
        }
        private void DemoCountries_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (DemoCountries_listBox.SelectedItem != null)
            {
                DemoCountries_listBox.Items.Remove(DemoCountries_listBox.SelectedItem);
                UpdateListBox(AllLimits(filmList));
            }
        }

        private void Films_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Films_listBox.SelectedItem != null)
            {
                filmInfoForm = new FilmInfoForm((Film)Films_listBox.SelectedItem);
                filmInfoForm.ShowDialog();
            }
        }

        private void Actor_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Actor_listBox.SelectedItem != null)
            {
                Actor_listBox.Items.Remove(Actor_listBox.SelectedItem);
                UpdateListBox(AllLimits(filmList));
            }
        }

        private void Genre_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Genre_listBox.SelectedItem != null)
            {
                Genre_listBox.Items.Remove(Genre_listBox.SelectedItem);
                UpdateListBox(AllLimits(filmList));
            }
        }
        private async void UserForm_LoadAsync(object sender, EventArgs e)
        {
            (await FilmsService.Instance.GetFilmsAsync()).ForEach(f => filmList.Add(f));

            (await GenreService.Instance.GetGenresAsync()).ForEach(g => Genre_comboBox.Items.Add(g));
            (await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Actor>))).ToList().ForEach(f => Actor_comboBox.Items.Add(f));
            (await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Producer>))).ToList().ForEach(f => Producer_comboBox.Items.Add(f));
            (await CountriesService.Instance.GetCountriesAsync()).ForEach(c => Country_comboBox.Items.Add(c));
            (await DemoCountriesService.Instance.GetDemoCountriesAsync()).ForEach(c => DemoCountry_comboBox.Items.Add(c));

            UpdateListBox(filmList);
        }

        private void DemoCountry_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DemoCountry_comboBox.SelectedIndex == 0)
            {
                DemoCountries_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            DemoCountries_listBox.Items.Add(DemoCountry_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }

        private void UpdateListBox(List<Film> films)
        {
            Films_listBox.Items.Clear();
            films.ForEach(f => Films_listBox.Items.Add(f));
        }

        public List<Film> SortingFilms(int sortingTypeIndex)
        {
            switch (sortingTypeIndex)
            {
                case 0: return filmList.OrderBy(f => f.Name).ToList();
                case 1: return filmList.OrderBy(f => f.Year).ToList();
                case 2: return filmList.OrderBy(f => f.Budget).ToList();
                case 3: return filmList.OrderBy(f => f.BoxOffice).ToList();
                case 4: return filmList.OrderBy(f => f.CountryProduce.Name).ToList();
                default: return filmList.OrderBy(f => f.Name).ToList();
            }
        }
        private void Sorting_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Film> films = SortingFilms(Sorting_comboBox.SelectedIndex);
            UpdateListBox(AllLimits(films));
            Reverse_button.Text = "↑";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reverse_button.Text = Reverse_button.Text == "↑" ? "↓" : "↑";
            List<Film> films = new List<Film>();
            foreach(Film item in Films_listBox.Items)
            {
                films.Add(item);
            }
            films.Reverse();
            UpdateListBox(AllLimits(films));
        }
        private void Genre_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Genre_comboBox.SelectedIndex == 0)
            {
                Genre_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            Genre_listBox.Items.Add(Genre_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }
        private void Actor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Actor_comboBox.SelectedIndex == 0)
            {
                Actor_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            Actor_listBox.Items.Add(Actor_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }
        private void Country_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Producer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }
        private void Rating1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Rating2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Year1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Year2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }
        private void Budget1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Budget2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Box1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Box2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private List<Film> AllLimits(List<Film> filmList)
        {
            List<Genre> genres = new List<Genre>();
            foreach(Genre g in Genre_listBox.Items)
                genres.Add(g);

            List<Actor> actors = new List<Actor>();
            foreach (Actor w in Actor_listBox.Items)
                actors.Add(w);

            List<DemoCountry> demo = new List<DemoCountry>();
            foreach (DemoCountry d in DemoCountries_listBox.Items)
                demo.Add(d);

            List<Film> list = null;
            list = genres.Count == 0 ? filmList : FilmFilters.Instance.GenreFilters(filmList, genres);
            List<Film> list1 = null;
            list1 = actors.Count == 0 ? list : FilmFilters.Instance.ActorFilters(list, actors);
            List<Film> list2 = null;
            list2 = Country_comboBox.SelectedIndex == 0 ? list1 : FilmFilters.Instance.CountryFilters(list1, (Country)Country_comboBox.SelectedItem);
            List<Film> list3 = null;
            list3 = Producer_comboBox.SelectedIndex == 0 ? list2 : FilmFilters.Instance.ProducerFilters(list2, (Producer)Producer_comboBox.SelectedItem);
            List<Film> list4 = null;
            list4 = FilmFilters.Instance.RatingFilters(list3, (float)Rating1_numericUpDown.Value, (float)Rating2_numericUpDown.Value);
            List<Film> list5 = null;
            list5 = FilmFilters.Instance.YearFilters(list4, (int)Year1_numericUpDown.Value, (int)Year2_numericUpDown.Value);
            List<Film> list6 = null;
            list6 = FilmFilters.Instance.BudgetFilters(list5, Budget1_numericUpDown.Value, Budget2_numericUpDown.Value);
            List<Film> list7 = null;
            list7 = FilmFilters.Instance.BoxOfficeFilters(list6, Box1_numericUpDown.Value, Box2_numericUpDown.Value);
            List<Film> list8 = null;
            list8 = demo.Count == 0 ? list7 : FilmFilters.Instance.DemoCountriesFilters(list7, demo);

            return list8;
        }
        private async void ActorsFilters_button_ClickAsync(object sender, EventArgs e)
        {
            extraFilters = new FilmworkersFiltersForm(userStatus, (await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Actor>))), Actor_listBox);
            DialogResult res = extraFilters.ShowDialog();
            if (res == DialogResult.Cancel || res == DialogResult.OK)
            {
                UpdateListBox(AllLimits(filmList));
            }
        }

        private async void ProducerFilter_button_ClickAsync(object sender, EventArgs e)
        {
            extraFilters = new FilmworkersFiltersForm(userStatus,(await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Producer>))), Producer_comboBox);
            DialogResult res = extraFilters.ShowDialog();
            if (res == DialogResult.Cancel || res == DialogResult.OK)
            {
                UpdateListBox(AllLimits(filmList));
            }
        }

        private async void DeleteFilm_button_ClickAsync(object sender, EventArgs e)
        {
            if (await FilmsService.Instance.RemoveFilmAsync((Film)Films_listBox.SelectedItem) == true)
            {
                MessageBox.Show($"Фильм \"{((Film)Films_listBox.SelectedItem).Name}\" успешно удалён");
                filmList.Remove((Film)Films_listBox.SelectedItem);
                Films_listBox.Items.Remove((Film)Films_listBox.SelectedItem);
            }
        }

    }
}
