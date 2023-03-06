using FilmsLibrary.Models;
using FilmsLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary
{
    public partial class AddFilmworkerForm : Form
    {
        public AddFilmworkerForm()
        {
            InitializeComponent();
            this.Load += AddFilmworkerForm_LoadAsync;
        }
        private async void AddFilmworkerForm_LoadAsync(object sender, EventArgs e)
        {
            (await ExtraDataService.Instance.GetCountriesAsync()).ForEach((c) => Country_comboBox.Items.Add(c));
            Sex_comboBox.SelectedIndex = 1;
        }
        private async Task<bool> FilmworkerCreatorAsync(string ProfessionName)
        {
            FilmWorker worker = null;
            //нарушение второго принципа SOLID которое я не знаю как исправить
            try
            {
                switch (ProfessionName)
                {
                    case "Продюсер":
                        worker = new Producer();
                        break;
                    case "Актёр":
                        worker = new Actor();
                        break;
                    default:break;
                }
                worker.FirstName = FName_textBox.Text;
                worker.LastName = LName_textBox.Text;
                worker.Sex = Sex_comboBox.Text;
                worker.Birthday = dateTimePicker1.Value.Date;
                worker.City = City_textBox.Text;
                worker.FinState = Decimal.Parse(FinSate_maskedTextBox.Text);
                worker.Nation = await ExtraDataService.Instance.GetCountryAsync(Country_comboBox.Text);
                switch (ProfessionName)
                {
                    case "Продюсер":
                        await FilmWorkersService.Instance.AddFWAsync((Producer)worker);
                        break;
                    case "Актёр":
                        await FilmWorkersService.Instance.AddFWAsync((Actor)worker);
                        break;
                    default: break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool AllTestFields()
        {
            if (FName_textBox.Text == "")
            {
                MessageBox.Show("Введите Имя");
                return false;
            }
            if (LName_textBox.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return false;
            }
            if (Profession_listBox.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну профессию");
                return false;
            }
            return true;
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (AllTestFields() == false)
                return;
            foreach(string profName in Profession_listBox.Items)
            {
                if(await FilmworkerCreatorAsync(profName) == true)
                    MessageBox.Show($"Новый {profName.ToLower()} успешно добавлен в базу данных");
            }
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(Profession_listBox.Items.Contains(Profession_comboBox.Text) == false)
                Profession_listBox.Items.Add(Profession_comboBox.Text);
        }
    }
}
