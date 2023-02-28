using FilmsLibrary.Models;
using FilmsLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLibrary
{
    public partial class MainForm : Form
    {
        UserForm userForm;
        AdminForm adminForm;
        RegistartionForm registartionForm;
        DbFill dbFill;
        public MainForm()
        {
            InitializeComponent();
            dbFill = new DbFill();
            this.Load += MainForm_LoadAsync;
        }
        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            if ((await dbFill.AddFilmsAndActorsAsync()) == true)
            {
                MessageBox.Show("Фильмы и актёры успешно добавлены в базу данных!");
                button1.Enabled = true;
                button2.Enabled = true;
                linkLabel1.Enabled = true;
                login_textBox.Enabled = true;
                password_textBox.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                Enter_button.Enabled = true;
                label3.Visible = false;
                label3.Enabled = false;
            }
            else
                MessageBox.Show("Ошибка при загрузке данных!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userForm = new UserForm("Пользователь");
            userForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registartionForm = new RegistartionForm();
            registartionForm.ShowDialog();
        }

        private async void Enter_button_ClickAsync(object sender, EventArgs e)
        {
            User user = await Auth.Instance.Login(login_textBox.Text, password_textBox.Text);
            if (user == null)
            {
                MessageBox.Show("Логин или пароль неверные!");
            }
            else
            {
                if (user.Status == "Администратор")
                {
                    adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else if (user.Status == "Пользователь")
                {
                    userForm = new UserForm(user.Status);
                    userForm.ShowDialog();
                }
            }
        }
    }
}
