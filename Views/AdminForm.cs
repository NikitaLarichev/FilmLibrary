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
    public partial class AdminForm : Form
    {
        AddFilmForm addFilmForm;
        AddFilmworkerForm addFilmWorkerForm;
        UserForm userForm;
        QueryForm queryForm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addFilmForm = new AddFilmForm();
            addFilmForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addFilmWorkerForm = new AddFilmworkerForm();
            addFilmWorkerForm.ShowDialog();
        }
        private void UserForm_button_Click(object sender, EventArgs e)
        {
            userForm = new UserForm("Администратор");
            userForm.ShowDialog();
        }

        private void QueryForm_button_Click(object sender, EventArgs e)
        {
            queryForm = new QueryForm();
            queryForm.ShowDialog();
        }
    }
}
