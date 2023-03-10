using FilmsLibrary.Controls;
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
    public partial class FilmworkersFiltersForm : Form
    {
        List<IFilmWorker> list;
        FilmWorkerInfoForm infoForm;
        Control control;
        public FilmworkersFiltersForm(string userStatus, List<IFilmWorker> list, Control control)
        {
            InitializeComponent();
            if (userStatus == "Администратор")
                ExtraButtonLoad();
            this.list = list;
            this.control = control;
            this.Load += FilmworkersFiltersForm_LoadAsync;
            listBox1.DoubleClick += ListBox1_DoubleClick;
            Sex_comboBox.SelectedIndex = 0;
            Country_comboBox.SelectedIndex = 0;
            City_comboBox.SelectedIndex = 0;
            Films_comboBox.SelectedIndex = 0;

        }
        private void ExtraButtonLoad()
        {
            DeleteFW_button.Enabled = true;
            DeleteFW_button.Visible = true;
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (control is ListBox)
                    if (((ListBox)control).Items.Contains(listBox1.SelectedItem) == false)
                        ((ListBox)control).Items.Add(listBox1.SelectedItem);
                if (control is ComboBox)
                    ((ComboBox)control).SelectedItem = listBox1.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private async void FilmworkersFiltersForm_LoadAsync(object sender, EventArgs e)
        {
            foreach(var c in list)
            {
                if (Country_comboBox.Items.Contains(c.Nation) == false)
                    Country_comboBox.Items.Add(c.Nation);
                if(City_comboBox.Items.Contains(c.City) == false)
                    City_comboBox.Items.Add(c.City);
            }

            (await FilmsService.Instance.GetFilmsAsync()).ForEach(f => Films_comboBox.Items.Add(f));

            Films_comboBox.SelectedIndexChanged += Films_comboBox_SelectedIndexChanged;
            Sex_comboBox.SelectedIndexChanged += Sex_comboBox_SelectedIndexChanged;
            Country_comboBox.SelectedIndexChanged += Country_comboBox_SelectedIndexChanged;
            City_comboBox.SelectedIndexChanged += City_comboBox_SelectedIndexChanged;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            Sorting_comboBox.SelectedIndexChanged += Sorting_comboBox_SelectedIndexChanged;

            Sorting_comboBox.SelectedIndex = 0;
            UpdateListBox(AllFilters());
        }

        private void Films_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void UpdateListBox(List<IFilmWorker> list)
        {
            listBox1.Items.Clear();
            list.ForEach(f => listBox1.Items.Add(f));
        }
        private List<IFilmWorker> AllFilters()
        {
            List<IFilmWorker> list1 = null;
            list1 = FwFilters.Instance.SexFilter(list, Sex_comboBox.Text);
            if (Sex_comboBox.SelectedIndex == 0)
                list1 = list;
            List<IFilmWorker> list2 = null;
            list2 = FwFilters.Instance.BirthdayFilter(list1, dateTimePicker1.Value, dateTimePicker2.Value);
            List<IFilmWorker> list3 = null;
            list3 = Country_comboBox.SelectedIndex == 0 ? list2 : FwFilters.Instance.NationFilter(list2, (Country)Country_comboBox.SelectedItem);
            List<IFilmWorker> list4 = null;
            list4 = City_comboBox.SelectedIndex == 0 ? list3 : FwFilters.Instance.CityFilter(list3, City_comboBox.Text);
            List<IFilmWorker> list5 = null;
            list5 = FwFilters.Instance.FinFilter(list4, numericUpDown1.Value, numericUpDown2.Value);
            if (Films_comboBox.SelectedIndex == 0)
                return list5;
            List<IFilmWorker> list6 = new List<IFilmWorker>();
            list6 = FwFilters.Instance.FilmFilter(list5, (Film)Films_comboBox.SelectedItem);
            return list6;
        }

        private void Sex_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void Country_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void City_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllFilters());
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if(control is ListBox)
            {
                if (listBox1.SelectedItem != null)
                    if(((ListBox)control).Items.Contains(listBox1.SelectedItem) == false)
                        ((ListBox)control).Items.Add(listBox1.SelectedItem);
                else
                    foreach (var item in listBox1.Items)
                            if(((ListBox)control).Items.Contains(item) == false)
                                ((ListBox)control).Items.Add(item);
            }
            if(control is ComboBox)
            {
                if (listBox1.SelectedItem != null)
                    ((ComboBox)control).SelectedItem = listBox1.SelectedItem;
                if (listBox1.Items.Count == 1)
                    ((ComboBox)control).SelectedItem = listBox1.Items[0];
            }
            this.Close();    
        }
        private async void DeleteFW_button_ClickAsync(object sender, EventArgs e)
        { 
            if(((IFilmWorker)listBox1.SelectedItem) is Actor)
                if(await FilmWorkersService.Instance.RemoveFWAsync((Actor)listBox1.SelectedItem) == true)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    list.Remove((IFilmWorker)listBox1.SelectedItem);
                }
            if (((IFilmWorker)listBox1.SelectedItem) is Producer)
                if (await FilmWorkersService.Instance.RemoveFWAsync((Producer)listBox1.SelectedItem) == true)
                {
                    if (((ComboBox)control).Items.Contains((Producer)listBox1.SelectedItem) == true)
                    {
                        ((ComboBox)control).Items.Remove((Producer)listBox1.SelectedItem);
                    }
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    list.Remove((IFilmWorker)listBox1.SelectedItem);
                }
        }

        private void Info_button_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                infoForm = new FilmWorkerInfoForm((IFilmWorker)listBox1.SelectedItem);
                infoForm.ShowDialog();
            }
        }

        private void Reverse_button_Click(object sender, EventArgs e)
        {
            Reverse_button.Text = Reverse_button.Text == "↑" ? "↓" : "↑";
            list.Reverse();
            UpdateListBox(AllFilters());
        }
        private void SortingFW()
        {
            Reverse_button.Text = "↑";
            switch (Sorting_comboBox.SelectedIndex)
            {
                case 0:
                    list = list.OrderBy(f => f.FirstName).ToList();
                    break;
                case 1:
                    list = list.OrderBy(f => f.LastName).ToList();
                    break;
                case 2:
                    list = list.OrderBy(f => f.Birthday).ToList();
                    break;
                case 3:
                    list = list.OrderBy(f => f.FinState).ToList();
                    break;
                default:
                    list = list.OrderBy(f => f.FirstName).ToList();
                    break;
            }
        }
        private void Sorting_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortingFW();
            UpdateListBox(AllFilters());
        }
    }
}
