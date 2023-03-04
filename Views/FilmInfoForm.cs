using FilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary.Views
{
    public partial class FilmInfoForm : Form
    {
        Film film;
        FilmWorkerInfoForm fwInfoForm;
        public FilmInfoForm(Film film)
        {
            InitializeComponent();
            this.film = film;
            Actors_listBox.DoubleClick += Actors_listBox_DoubleClick;
            FilmInfoVisual();
            
        }

        private void Actors_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Actors_listBox.SelectedItem != null)
            {
                fwInfoForm = new FilmWorkerInfoForm((IFilmWorker)Actors_listBox.SelectedItem);
                fwInfoForm.ShowDialog();
            }
        }

        private void FilmInfoVisual()
        {
            string country = film.CountryProduce == null ? "???" : film.CountryProduce.Name;
            string producer = film.FilmProducer == null ? "???" : film.FilmProducer.ToString();
            filmName_label.Text = film.Name;
            Info_label.Text = "Жанр:";
            foreach (Genre g in film.Genres)
                Info_label.Text += g.Name + ", ";
            Info_label.Text = $"Год: {film.Year.Year}\nРейтинг: {film.Rating}\n";
            Info_label.Text += $"\nСтрана производства: {country}\nБюджет: {film.Budget}$\n";
            Info_label.Text += $"Сборы: {film.BoxOffice}$\nКоличество зрителей: {film.Viewers} чел.\n";
            Info_label.Text += $"Страны демонстрации: ";
            foreach (DemoCountry c in film.CountriesDemonstration)
                Info_label.Text += c.Name + ", ";
            Producer_linkLabel.Text = producer;
            film.Actors.ToList().ForEach(a => Actors_listBox.Items.Add(a));
        }
        private void Producer_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (film.FilmProducer != null)
            {
                fwInfoForm = new FilmWorkerInfoForm(film.FilmProducer);
                fwInfoForm.ShowDialog();
            }
        }

    }
}
