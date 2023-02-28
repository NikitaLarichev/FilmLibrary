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
    public partial class FilmWorkerInfoForm : Form
    {
        Actor actor;
        Producer producer;
        FilmWorker worker;
        public FilmWorkerInfoForm(FilmWorker worker)
        {
            InitializeComponent();
            this.worker = worker;
            this.Load += FilmWorkerInfoForm_Load;
        }
        private async void FilmWorkerInfoForm_Load(object sender, EventArgs e)
        {
            actor = (await DbService.Instance.GetActorsAsync()).FirstOrDefault(a => a.FirstName == worker.FirstName &&
            a.LastName == worker.LastName && a.Birthday == worker.Birthday);
            producer = (await DbService.Instance.GetProducersAsync()).FirstOrDefault(a => a.FirstName == worker.FirstName &&
            a.LastName == worker.LastName && a.Birthday == worker.Birthday);
            FilmworkerInfoVisual();
        }
        private void FilmworkerInfoVisual()
        {
            Name_label.Text = worker.ToString();
            Info_label.Text = $"Пол: {worker.Sex}\nДата рождения: {worker.Birthday}\n";
            Info_label.Text += $"Место рождения: {worker.Nation.ToString()}, {worker.City}\n";
            Info_label.Text += $"Финансовое состояние: {worker.FinState}$";
            if (producer != null)
                (producer).FilmsProduce.ToList().ForEach(f => ProducedFilms_listBox.Items.Add(f));
            else
            {//перенести визуал в отдельный метод
                ProducedFilms_listBox.Visible = false;
                ProducedFilm_label.Visible = false;
                Filmography_listBox.Location = new Point(294, Filmography_listBox.Location.Y);
                Filmography_label.Location = new Point(294, Filmography_label.Location.Y);
                this.Size = new Size(500, this.Size.Height);
            }
            if (actor != null)
                (actor).Filmography.ToList().ForEach(f => Filmography_listBox.Items.Add(f));
            else
            {
                Filmography_label.Visible = false;
                Filmography_listBox.Visible = false;
                this.Size = new Size(500, this.Size.Height);
            }
        }
        private void Name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
