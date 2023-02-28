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
        ListBoxForm listBoxForm;
        DbService dbService = DbService.Instance;
        public AddFilmForm()
        {
            InitializeComponent();
            Actors_listBox.Click += Actors_listBox_ClickAsync;
            Producer_textBox.Click += Producer_textBox_ClickAsync;
            numericUpDown1.Value = DateTime.Now.Year;
            this.Load += AddFilmForm_LoadAsync;
        }
        private async void AddFilmForm_LoadAsync(object sender, EventArgs e)
        {
            (await dbService.GetCountriesAsync()).ForEach(c => Country_comboBox.Items.Add(c));
            (await dbService.GetDemoCountriesAsync()).ForEach(c => CountryDemo_comboBox.Items.Add(c));
        }
        private async void Producer_textBox_ClickAsync(object sender, EventArgs e)
        {
            List<Object> list = (await dbService.GetProducersAsync()).ToList<Object>();   
            LoadListBox("Продюсер", Producer_textBox);
        }
        private void LoadListBox(string ProfessionName, Control control)
        {
            listBoxForm = new ListBoxForm(ProfessionName, control);
            listBoxForm.ShowDialog();
        }
        private async void Actors_listBox_ClickAsync(object sender, EventArgs e)
        {
            List<Object> list = (await dbService.GetActorsAsync()).ToList<Object>();
            LoadListBox("Актёр", Actors_listBox);
        }
        private async Task<Film> FilmCreatorAsync()
        {
            Film newFilm = new Film()
            {
                Name = Name_textBox.Text,
                Year = new DateTime((int)numericUpDown1.Value, 1, 1),
                CountryProduce = (Country)Country_comboBox.SelectedItem ?? new Country() { Name = Country_comboBox.Name },
                Rating = float.Parse(Rating_maskedTextBox.Text),
                Budget = Decimal.Parse(Budget_maskedTextBox.Text),
                BoxOffice = Decimal.Parse(Budget_maskedTextBox.Text),
                Viewers = Int64.Parse(Viewers_maskedTextBox.Text),
                FilmProducer = (await dbService.GetProducersAsync()).FirstOrDefault(f => f.ToString() == Producer_textBox.Text),
            };
            foreach (Genre g in Genre_listBox.Items)
                newFilm.Genres.Add(g);
            foreach (DemoCountry c in CountryDemo_listBox.Items)
                newFilm.CountriesDemonstration.Add(c);
            foreach (Actor f in Actors_listBox.Items)
                newFilm.Actors.Add(f);
            return newFilm;
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Film newFilm = await FilmCreatorAsync();
            newFilm.Genres.ToList().ForEach(g => g.Films.Add(newFilm));
            newFilm.CountryProduce.FilmProduce.Add(newFilm);             
            newFilm.CountriesDemonstration.ToList().ForEach(c => c.Films.Add(newFilm));
            newFilm.Actors.ToList().ForEach(a => a.Filmography.Add(newFilm));
            await dbService.InsertToDbAsync(newFilm);
            this.Close();
        }
        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            Genre genre = (await dbService.GetGenresAsync()).FirstOrDefault(g => g.Name == Genre_comboBox.Text) ?? new Genre() { Name = Genre_comboBox.Text };
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
            Country country = (await dbService.GetCountriesAsync()).FirstOrDefault(c => c.Name == CountryDemo_comboBox.Text) ?? new Country() { Name = CountryDemo_comboBox.Text };
            if(country.Name != "")
                CountryDemo_listBox.Items.Add(country);
        }
    }
}
