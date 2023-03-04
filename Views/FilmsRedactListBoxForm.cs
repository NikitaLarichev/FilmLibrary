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
    public partial class FilmsRedactListBoxForm : Form
    {
        AddFilmForm addFilmForm;
        public FilmsRedactListBoxForm(AddFilmForm form)
        {
            InitializeComponent();
            addFilmForm = form;
            listBox1.DoubleClick += ListBox1_DoubleClick;
            textBox1.TextChanged += TextBox1_TextChanged;
            this.Load += FilmsRedactListBoxForm_Load;
        }

        private async void FilmsRedactListBoxForm_Load(object sender, EventArgs e)
        {
            (await FilmsService.Instance.GetFilmsAsync()).ForEach(o => listBox1.Items.Add(o));
        }

        private async void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();          
            if (textBox1.Text == "")
                (await FilmsService.Instance.GetFilmsAsync()).ForEach(o => listBox1.Items.Add(o));
            else
                (await FilmsService.Instance.GetFilmsAsync()).Where(f => f.Name.Contains(textBox1.Text)).ToList().ForEach(o => listBox1.Items.Add(o));
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            SelectFilm();
            this.Close();
        }
        private void SelectFilm()
        {
            if (listBox1.SelectedItem != null)
            {
                addFilmForm.LoadFilm((Film)listBox1.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            SelectFilm();
            this.Close();
        }
    }
}
