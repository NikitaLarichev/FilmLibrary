namespace FilmsLibrary.Views
{
    partial class RegistartionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password2_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateUser_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(37, 150);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(318, 22);
            this.Login_textBox.TabIndex = 1;
            // 
            // Password1_textBox
            // 
            this.Password1_textBox.Location = new System.Drawing.Point(37, 226);
            this.Password1_textBox.Name = "Password1_textBox";
            this.Password1_textBox.Size = new System.Drawing.Size(318, 22);
            this.Password1_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Password2_textBox
            // 
            this.Password2_textBox.Location = new System.Drawing.Point(37, 302);
            this.Password2_textBox.Name = "Password2_textBox";
            this.Password2_textBox.Size = new System.Drawing.Size(318, 22);
            this.Password2_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите пароль";
            // 
            // CreateUser_button
            // 
            this.CreateUser_button.Location = new System.Drawing.Point(37, 363);
            this.CreateUser_button.Name = "CreateUser_button";
            this.CreateUser_button.Size = new System.Drawing.Size(318, 53);
            this.CreateUser_button.TabIndex = 6;
            this.CreateUser_button.Text = "Создать аккаунт";
            this.CreateUser_button.UseVisualStyleBackColor = true;
            this.CreateUser_button.Click += new System.EventHandler(this.CreateUser_button_ClickAsync);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.comboBox1.Location = new System.Drawing.Point(40, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Статус";
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateUser_button);
            this.Controls.Add(this.Password2_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistartionForm";
            this.Text = "RegistartionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password2_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateUser_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}