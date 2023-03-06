namespace FilmsLibrary.Views
{
    partial class AddFilmForm
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
            this.AddFilm_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Budget_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxOffice_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Viewers_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Actors_listBox = new System.Windows.Forms.ListBox();
            this.CountryDemo_listBox = new System.Windows.Forms.ListBox();
            this.Genre_listBox = new System.Windows.Forms.ListBox();
            this.CountryDemo_comboBox = new System.Windows.Forms.ComboBox();
            this.Genre_comboBox = new System.Windows.Forms.ComboBox();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.AddGenre_button = new System.Windows.Forms.Button();
            this.AddCountryDemo_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Rating_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Redact_button = new System.Windows.Forms.Button();
            this.Producer_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFilm_button
            // 
            this.AddFilm_button.Location = new System.Drawing.Point(315, 515);
            this.AddFilm_button.Name = "AddFilm_button";
            this.AddFilm_button.Size = new System.Drawing.Size(473, 51);
            this.AddFilm_button.TabIndex = 0;
            this.AddFilm_button.Text = "Добавить фильм в базу даных";
            this.AddFilm_button.UseVisualStyleBackColor = true;
            this.AddFilm_button.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(27, 49);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(224, 22);
            this.Name_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 111);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(224, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр";
            // 
            // Budget_maskedTextBox
            // 
            this.Budget_maskedTextBox.Location = new System.Drawing.Point(27, 442);
            this.Budget_maskedTextBox.Name = "Budget_maskedTextBox";
            this.Budget_maskedTextBox.Size = new System.Drawing.Size(224, 22);
            this.Budget_maskedTextBox.TabIndex = 7;
            this.Budget_maskedTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Бюджет";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сборы";
            // 
            // BoxOffice_maskedTextBox
            // 
            this.BoxOffice_maskedTextBox.Location = new System.Drawing.Point(27, 493);
            this.BoxOffice_maskedTextBox.Name = "BoxOffice_maskedTextBox";
            this.BoxOffice_maskedTextBox.Size = new System.Drawing.Size(224, 22);
            this.BoxOffice_maskedTextBox.TabIndex = 9;
            this.BoxOffice_maskedTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество зрителей";
            // 
            // Viewers_maskedTextBox
            // 
            this.Viewers_maskedTextBox.Location = new System.Drawing.Point(27, 544);
            this.Viewers_maskedTextBox.Name = "Viewers_maskedTextBox";
            this.Viewers_maskedTextBox.Size = new System.Drawing.Size(224, 22);
            this.Viewers_maskedTextBox.TabIndex = 11;
            this.Viewers_maskedTextBox.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(312, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Продюсер";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(312, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Актёры";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Страна";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(560, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Страны демонстрации";
            // 
            // Actors_listBox
            // 
            this.Actors_listBox.FormattingEnabled = true;
            this.Actors_listBox.ItemHeight = 16;
            this.Actors_listBox.Location = new System.Drawing.Point(315, 110);
            this.Actors_listBox.Name = "Actors_listBox";
            this.Actors_listBox.Size = new System.Drawing.Size(212, 324);
            this.Actors_listBox.TabIndex = 21;
            // 
            // CountryDemo_listBox
            // 
            this.CountryDemo_listBox.FormattingEnabled = true;
            this.CountryDemo_listBox.ItemHeight = 16;
            this.CountryDemo_listBox.Location = new System.Drawing.Point(563, 111);
            this.CountryDemo_listBox.Name = "CountryDemo_listBox";
            this.CountryDemo_listBox.Size = new System.Drawing.Size(225, 324);
            this.CountryDemo_listBox.TabIndex = 22;
            // 
            // Genre_listBox
            // 
            this.Genre_listBox.FormattingEnabled = true;
            this.Genre_listBox.ItemHeight = 16;
            this.Genre_listBox.Location = new System.Drawing.Point(27, 204);
            this.Genre_listBox.Name = "Genre_listBox";
            this.Genre_listBox.Size = new System.Drawing.Size(224, 100);
            this.Genre_listBox.TabIndex = 23;
            // 
            // CountryDemo_comboBox
            // 
            this.CountryDemo_comboBox.FormattingEnabled = true;
            this.CountryDemo_comboBox.Location = new System.Drawing.Point(563, 46);
            this.CountryDemo_comboBox.Name = "CountryDemo_comboBox";
            this.CountryDemo_comboBox.Size = new System.Drawing.Size(169, 24);
            this.CountryDemo_comboBox.TabIndex = 24;
            // 
            // Genre_comboBox
            // 
            this.Genre_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre_comboBox.FormattingEnabled = true;
            this.Genre_comboBox.Items.AddRange(new object[] {
            "Боевик",
            "Ужас",
            "Триллер",
            "Драма",
            "Комедия",
            "Мультфильм",
            "Мелодрама",
            "Исторический",
            "Приключение",
            "Биография",
            "Фантастика",
            "Фэнтези"});
            this.Genre_comboBox.Location = new System.Drawing.Point(27, 174);
            this.Genre_comboBox.Name = "Genre_comboBox";
            this.Genre_comboBox.Size = new System.Drawing.Size(169, 24);
            this.Genre_comboBox.TabIndex = 25;
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Location = new System.Drawing.Point(27, 338);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(224, 24);
            this.Country_comboBox.TabIndex = 26;
            // 
            // AddGenre_button
            // 
            this.AddGenre_button.Location = new System.Drawing.Point(202, 174);
            this.AddGenre_button.Name = "AddGenre_button";
            this.AddGenre_button.Size = new System.Drawing.Size(49, 24);
            this.AddGenre_button.TabIndex = 27;
            this.AddGenre_button.Text = "Add";
            this.AddGenre_button.UseVisualStyleBackColor = true;
            this.AddGenre_button.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // AddCountryDemo_button
            // 
            this.AddCountryDemo_button.Location = new System.Drawing.Point(738, 46);
            this.AddCountryDemo_button.Name = "AddCountryDemo_button";
            this.AddCountryDemo_button.Size = new System.Drawing.Size(50, 24);
            this.AddCountryDemo_button.TabIndex = 28;
            this.AddCountryDemo_button.Text = "Add";
            this.AddCountryDemo_button.UseVisualStyleBackColor = true;
            this.AddCountryDemo_button.Click += new System.EventHandler(this.AddCountryDemo_button_ClickAsync);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Рейтинг";
            // 
            // Rating_maskedTextBox
            // 
            this.Rating_maskedTextBox.Location = new System.Drawing.Point(27, 391);
            this.Rating_maskedTextBox.Name = "Rating_maskedTextBox";
            this.Rating_maskedTextBox.Size = new System.Drawing.Size(224, 22);
            this.Rating_maskedTextBox.TabIndex = 30;
            this.Rating_maskedTextBox.Text = "0";
            // 
            // Redact_button
            // 
            this.Redact_button.Location = new System.Drawing.Point(315, 450);
            this.Redact_button.Name = "Redact_button";
            this.Redact_button.Size = new System.Drawing.Size(473, 51);
            this.Redact_button.TabIndex = 31;
            this.Redact_button.Text = "Редактировать фильм ";
            this.Redact_button.UseVisualStyleBackColor = true;
            this.Redact_button.Click += new System.EventHandler(this.Redact_button_Click);
            // 
            // Producer_textBox
            // 
            this.Producer_textBox.Location = new System.Drawing.Point(315, 49);
            this.Producer_textBox.Name = "Producer_textBox";
            this.Producer_textBox.Size = new System.Drawing.Size(212, 22);
            this.Producer_textBox.TabIndex = 14;
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 576);
            this.Controls.Add(this.Redact_button);
            this.Controls.Add(this.Rating_maskedTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AddCountryDemo_button);
            this.Controls.Add(this.AddGenre_button);
            this.Controls.Add(this.Country_comboBox);
            this.Controls.Add(this.Genre_comboBox);
            this.Controls.Add(this.CountryDemo_comboBox);
            this.Controls.Add(this.Genre_listBox);
            this.Controls.Add(this.CountryDemo_listBox);
            this.Controls.Add(this.Actors_listBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Producer_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Viewers_maskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxOffice_maskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Budget_maskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFilm_button);
            this.Name = "AddFilmForm";
            this.Text = "AddFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFilm_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Budget_maskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox BoxOffice_maskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Viewers_maskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox Actors_listBox;
        private System.Windows.Forms.ListBox CountryDemo_listBox;
        private System.Windows.Forms.ListBox Genre_listBox;
        private System.Windows.Forms.ComboBox CountryDemo_comboBox;
        private System.Windows.Forms.ComboBox Genre_comboBox;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Button AddGenre_button;
        private System.Windows.Forms.Button AddCountryDemo_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox Rating_maskedTextBox;
        private System.Windows.Forms.Button Redact_button;
        private System.Windows.Forms.TextBox Producer_textBox;
    }
}