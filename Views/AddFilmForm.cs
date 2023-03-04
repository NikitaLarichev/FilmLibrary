using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsLibrary.Models;

namespace FilmsLibrary.Views
{
    public partial class AddFilmForm : Form
    {
        FilmsRedactListBoxForm filmRedactListBox;
        FWListBoxForm listBoxForm;
        bool redactButnFlag = true;
        Film redactFilm = null;
        public AddFilmForm()
        {
            InitializeComponent();
            Actors_listBox.Click += Actors_listBox_ClickAsync;
            Producer_textBox.Click += Producer_textBox_ClickAsync;
            numericUpDown1.Value = DateTime.Now.Year;
            this.Load += AddFilmForm_LoadAsync;
            Actors_listBox.DoubleClick += Actors_listBox_DoubleClick;
            CountryDemo_listBox.DoubleClick += CountryDemo_listBox_DoubleClick;
            Genre_listBox.DoubleClick += Genre_listBox_DoubleClick;
        }

        private void Genre_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Genre_listBox.SelectedItem != null)
            {
                Genre_listBox.Items.Remove(Genre_listBox.SelectedItem);
            }
        }

        private void CountryDemo_listBox_DoubleClick(object sender, EventArgs e)
        {
            if(CountryDemo_listBox.SelectedItem != null)
            {
                CountryDemo_listBox.Items.Remove(CountryDemo_listBox.SelectedItem);
            }
        }

        private void Actors_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Actors_listBox.SelectedItem != null)
            {
                Actors_listBox.Items.Remove(Actors_listBox.SelectedItem);
            }
        }

        private async void AddFilmForm_LoadAsync(object sender, EventArgs e)
        {
            (await ExtraDataService.Instance.GetCountriesAsync()).ForEach(c => Country_comboBox.Items.Add(c));
            (await ExtraDataService.Instance.GetDemoCountriesAsync()).ForEach(c => CountryDemo_comboBox.Items.Add(c));
        }
        private async void Producer_textBox_ClickAsync(object sender, EventArgs e)
        {
            List<IFilmWorker> list = (await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Producer>)));   
            LoadListBox(list, Producer_textBox);
        }
        private void LoadListBox(List<IFilmWorker> list, Control control)
        {
            listBoxForm = new FWListBoxForm(list, control);
            listBoxForm.ShowDialog();
        }
        private async void Actors_listBox_ClickAsync(object sender, EventArgs e)
        {
            if (Actors_listBox.SelectedItem == null)
            {
                List<IFilmWorker> list = (await FilmWorkersService.Instance.GetFilmWorkersAsync(typeof(List<Actor>)));
                LoadListBox(list, Actors_listBox);
            }
        }
        private async Task<Film> FilmRedactAsync(Film film)
        {
            film.Name = Name_textBox.Text;
            film.Year = new DateTime((int)numericUpDown1.Value, 1, 1);
            film.CountryProduce = (Country)Country_comboBox.SelectedItem ?? new Country() { Name = Country_comboBox.Text };
            film.Rating = float.Parse(Rating_maskedTextBox.Text);
            film.Budget = Decimal.Parse(Budget_maskedTextBox.Text);
            film.BoxOffice = Decimal.Parse(BoxOffice_maskedTextBox.Text);
            film.Viewers = Int64.Parse(Viewers_maskedTextBox.Text);
            film.FilmProducer = (Producer)await FilmWorkersService.Instance.GetProducerAsync(Producer_textBox.Text);
            film.Genres.Clear();
            foreach (Genre g in Genre_listBox.Items)
                film.Genres.Add(g);
            film.CountriesDemonstration.Clear();
            foreach (DemoCountry c in CountryDemo_listBox.Items)
                film.CountriesDemonstration.Add(c);
            film.Actors.Clear();
            foreach (Actor f in Actors_listBox.Items)
                film.Actors.Add(f);
            return film;
        }
        private bool AllTestFields()
        {
            if(Name_textBox.Text == "")
            {
                MessageBox.Show("Введите название фильма");
                return false;
            }
            if (Genre_listBox.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один жанр");
                return false;
            }
            if(Country_comboBox.Text == "")
            {
                MessageBox.Show("Выбирите или введите название страны");
                return false;
            }
            return true;
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (AllTestFields() == false)
                return;
            Film newFilm = await FilmRedactAsync(new Film());
            if (await FilmsService.Instance.AddFilmAsync(newFilm) == true)
            {
                MessageBox.Show($"Фильм {newFilm.Name} успешно добавлен в базу данных");
                this.Close();
            }
        }
        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            Genre genre = await ExtraDataService.Instance.GetGenreAsync(Genre_comboBox.Text);
            foreach (Genre g in Genre_listBox.Items)
            {
                if (g.Name == genre.Name)
                    return;
            }
            if(Genre_comboBox.Text != "")
                Genre_listBox.Items.Add(genre);
        }
        private async void AddCountryDemo_button_ClickAsync(object sender, EventArgs e)
        {
            DemoCountry country = await ExtraDataService.Instance.GetDemoCountryAsync(CountryDemo_comboBox.Text);
            if(country.Name != "")
                CountryDemo_listBox.Items.Add(country);
        }
        public void LoadFilm(Film film)
        {
            redactFilm = film;
            Name_textBox.Text = film.Name;
            numericUpDown1.Value = film.Year.Year;
            film.Genres.ToList().ForEach(g => Genre_listBox.Items.Add(g));
            Country_comboBox.SelectedItem = film.CountryProduce;
            Rating_maskedTextBox.Text = film.Rating.ToString();
            Budget_maskedTextBox.Text = film.Budget.ToString();
            BoxOffice_maskedTextBox.Text = film.BoxOffice.ToString();
            Viewers_maskedTextBox.Text = film.Viewers.ToString();
            Producer_textBox.Text = film.FilmProducer == null ? "" : film.FilmProducer.ToString();
            film.Actors.ToList().ForEach(a => Actors_listBox.Items.Add(a));
            film.CountriesDemonstration.ToList().ForEach(c => CountryDemo_listBox.Items.Add(c));
        }
        private async Task<bool>  SaveChangeInFilm()
        {
            try
            {
                if (redactFilm != null)
                {
                    await FilmRedactAsync(redactFilm);
                    await FilmsService.Instance.SaveChangesDbAsync();
                    return true;
                }
            }
            catch (Exception)
            { 
                return false;
            }
            return false;
        }
        private async void Redact_button_Click(object sender, EventArgs e)
        {
            if (redactButnFlag == true)
            {
                filmRedactListBox = new FilmsRedactListBoxForm(this);
                if (filmRedactListBox.ShowDialog() == DialogResult.OK)
                {
                    Redact_button.Text = "Сохранить изменения";
                    redactButnFlag = false;
                }
            }
            else
            {
                if (await SaveChangeInFilm() == true)
                    MessageBox.Show("Изменения сохранены успешно");
                Redact_button.Text = "Редактировать фильм";
                redactButnFlag = true;
            }
        }
    }
}
