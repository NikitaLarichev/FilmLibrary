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
    public partial class ListBoxForm : Form
    {
        Control control;
        AddFilmworkerForm addFilmworkerForm;
        DbService dbService = DbService.Instance;
        string ProfessionName = null;
        public ListBoxForm(string ProfessionName, Control control)
        {
            InitializeComponent();
            addFilmworkerForm = new AddFilmworkerForm();
            this.ProfessionName = ProfessionName;
            this.control = control;
            listBox1.DoubleClick += ListBox1_DoubleClick;
            this.Load += ListBoxForm_LoadAsync;
        }
        private async void ListBoxForm_LoadAsync(object sender, EventArgs e)
        {
            UpdateLabel(ProfessionName);
            await UpdateListboxAsync(ProfessionName);
        }
        private async Task<bool> UpdateListboxAsync(string ProfessionName)
        {
            try
            {
                switch (ProfessionName)
                {
                    case "Продюсер":
                        (await dbService.GetProducersAsync()).ToList().ForEach(e => listBox1.Items.Add(e));
                        break;
                    case "Актёр":
                        (await dbService.GetActorsAsync()).ToList().ForEach(e => listBox1.Items.Add(e));
                        break;
                    default:break;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void UpdateLabel(string ProfessionName)
        {
            switch (ProfessionName)
            {
                case "Продюсер": label1.Text = "Список продюсеров:"; break;
                case "Актёр": label1.Text = "Список актёров:"; break;
                default: break;
            }
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            ListBoxFill();
        }
        private void ListBoxFill()
        {
            if (control is TextBox)
                ((TextBox)control).Text = listBox1.SelectedItem.ToString();
            else if (control is ListBox)
                ((ListBox)control).Items.Add(listBox1.SelectedItem);
            this.Close();
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (addFilmworkerForm.ShowDialog() == DialogResult.Cancel)
                await UpdateListboxAsync(ProfessionName);           
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ListBoxFill();
        }
    }
}
