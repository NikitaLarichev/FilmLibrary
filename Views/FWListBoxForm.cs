using FilmsLibrary.Models;
using System;
using System.CodeDom;
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
    public partial class FWListBoxForm : Form
    {
        AddFilmworkerForm addFilmworkerForm;
        Control control;
        List<IFilmWorker> list;
        public FWListBoxForm(List<IFilmWorker> list, Control control)
        {
            InitializeComponent();
            addFilmworkerForm = new AddFilmworkerForm();
            this.list = list;
            this.control = control;;
            listBox1.DoubleClick += ListBox1_DoubleClick;
            this.Load += ListBoxForm_Load;
        }
        private void ListBoxForm_Load(object sender, EventArgs e)
        {
            UpdateListboxAsync();
        }
        private void UpdateListboxAsync()
        {
            list.ForEach(o => listBox1.Items.Add(o));
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
        private void button1_ClickAsync(object sender, EventArgs e)
        {
            if (addFilmworkerForm.ShowDialog() == DialogResult.Cancel)
                UpdateListboxAsync();           
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ListBoxFill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
