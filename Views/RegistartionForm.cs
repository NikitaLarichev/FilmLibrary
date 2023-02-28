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
    public partial class RegistartionForm : Form
    {
        Auth auth;
        public RegistartionForm()
        {
            InitializeComponent();
            auth = Auth.Instance;
            comboBox1.SelectedIndex = 0;
        }

        private async void CreateUser_button_ClickAsync(object sender, EventArgs e)
        {
            if(await auth.GetUser(Login_textBox.Text) != null)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует!");
                return;
            }
            if(Password1_textBox.Text != Password2_textBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            User user = new User() { Login = Login_textBox.Text, Password = Password1_textBox.Text, Status = comboBox1.Text };
            if (await auth.CreateUser(user) == true)
            {
                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
            }
        }
    }
}
