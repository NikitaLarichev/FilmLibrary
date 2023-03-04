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
        IFilmWorker worker;
        public FilmWorkerInfoForm(IFilmWorker worker)
        {
            InitializeComponent();
            this.worker = worker;
            this.Load += FilmWorkerInfoForm_Load;
        }
        private async void FilmWorkerInfoForm_Load(object sender, EventArgs e)
        {
            if(await ListBoxsControl() == true)
                FilmworkerInfoVisual();
        }
        private async Task<bool> ListBoxsControl()
        {
            try
            {
                if (await FilmWorkersService.Instance.FwIsActor(worker) == false)
                {
                    Filmography_label.Visible = false;
                    Filmography_listBox.Visible = false;
                    this.Size = new Size(500, this.Size.Height);
                }
                if (await FilmWorkersService.Instance.FwIsProducer(worker) == false)
                {
                    ProducedFilms_listBox.Visible = false;
                    ProducedFilm_label.Visible = false;
                    Filmography_listBox.Location = new Point(294, Filmography_listBox.Location.Y);
                    Filmography_label.Location = new Point(294, Filmography_label.Location.Y);
                    this.Size = new Size(500, this.Size.Height);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async void FilmworkerInfoVisual()
        {
            Name_label.Text = worker.ToString();
            Info_label.Text = $"Пол: {worker.Sex}\nДата рождения: {worker.Birthday}\n";
            Info_label.Text += $"Место рождения: {worker.Nation.ToString()}, {worker.City}\n";
            Info_label.Text += $"Финансовое состояние: {worker.FinState}$";
            if(await FilmWorkersService.Instance.FwIsActor(worker) == true)
            {
                (await FilmWorkersService.Instance.GetActorAsync(worker)).GetFilms().ToList().ForEach(f => Filmography_listBox.Items.Add(f));
            }          
            if (await FilmWorkersService.Instance.FwIsProducer(worker) == true)
            {
                (await FilmWorkersService.Instance.GetProducerAsync(worker)).GetFilms().ToList().ForEach(f => ProducedFilms_listBox.Items.Add(f));
            }           
        }
        private void Name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
