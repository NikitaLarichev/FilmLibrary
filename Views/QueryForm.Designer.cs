namespace FilmsLibrary.Views
{
    partial class QueryForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Genre_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Film_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Country_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Country_comboBox2 = new System.Windows.Forms.ComboBox();
            this.Genre_comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Genre_comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Actor_comboBox6 = new System.Windows.Forms.ComboBox();
            this.Year_numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Actor_comboBox7 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 644);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(954, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // Genre_comboBox1
            // 
            this.Genre_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre_comboBox1.FormattingEnabled = true;
            this.Genre_comboBox1.Location = new System.Drawing.Point(327, 100);
            this.Genre_comboBox1.Name = "Genre_comboBox1";
            this.Genre_comboBox1.Size = new System.Drawing.Size(180, 24);
            this.Genre_comboBox1.TabIndex = 2;
            // 
            // Film_comboBox1
            // 
            this.Film_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Film_comboBox1.FormattingEnabled = true;
            this.Film_comboBox1.Location = new System.Drawing.Point(531, 100);
            this.Film_comboBox1.Name = "Film_comboBox1";
            this.Film_comboBox1.Size = new System.Drawing.Size(231, 24);
            this.Film_comboBox1.TabIndex = 3;
            // 
            // Country_comboBox1
            // 
            this.Country_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country_comboBox1.FormattingEnabled = true;
            this.Country_comboBox1.Location = new System.Drawing.Point(784, 100);
            this.Country_comboBox1.Name = "Country_comboBox1";
            this.Country_comboBox1.Size = new System.Drawing.Size(155, 24);
            this.Country_comboBox1.TabIndex = 4;
            this.Country_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Country_comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(324, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(528, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фильм";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(781, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Страна";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(528, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Страна";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(324, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Жанр";
            // 
            // Country_comboBox2
            // 
            this.Country_comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country_comboBox2.FormattingEnabled = true;
            this.Country_comboBox2.Location = new System.Drawing.Point(531, 187);
            this.Country_comboBox2.Name = "Country_comboBox2";
            this.Country_comboBox2.Size = new System.Drawing.Size(180, 24);
            this.Country_comboBox2.TabIndex = 9;
            // 
            // Genre_comboBox2
            // 
            this.Genre_comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre_comboBox2.FormattingEnabled = true;
            this.Genre_comboBox2.Location = new System.Drawing.Point(327, 187);
            this.Genre_comboBox2.Name = "Genre_comboBox2";
            this.Genre_comboBox2.Size = new System.Drawing.Size(180, 24);
            this.Genre_comboBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(954, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(324, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Жанр";
            // 
            // Genre_comboBox3
            // 
            this.Genre_comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre_comboBox3.FormattingEnabled = true;
            this.Genre_comboBox3.Location = new System.Drawing.Point(327, 275);
            this.Genre_comboBox3.Name = "Genre_comboBox3";
            this.Genre_comboBox3.Size = new System.Drawing.Size(180, 24);
            this.Genre_comboBox3.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(954, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(954, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 48);
            this.button4.TabIndex = 16;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(954, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 48);
            this.button5.TabIndex = 17;
            this.button5.Text = "Выполнить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(324, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Актёр";
            // 
            // Actor_comboBox6
            // 
            this.Actor_comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Actor_comboBox6.FormattingEnabled = true;
            this.Actor_comboBox6.Location = new System.Drawing.Point(327, 525);
            this.Actor_comboBox6.Name = "Actor_comboBox6";
            this.Actor_comboBox6.Size = new System.Drawing.Size(180, 24);
            this.Actor_comboBox6.TabIndex = 18;
            // 
            // Year_numericUpDown6
            // 
            this.Year_numericUpDown6.Location = new System.Drawing.Point(592, 525);
            this.Year_numericUpDown6.Name = "Year_numericUpDown6";
            this.Year_numericUpDown6.Size = new System.Drawing.Size(170, 22);
            this.Year_numericUpDown6.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(954, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 48);
            this.button6.TabIndex = 21;
            this.button6.Text = "Выполнить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(954, 552);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 48);
            this.button7.TabIndex = 22;
            this.button7.Text = "Выполнить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(324, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Актёр";
            // 
            // Actor_comboBox7
            // 
            this.Actor_comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Actor_comboBox7.FormattingEnabled = true;
            this.Actor_comboBox7.Location = new System.Drawing.Point(327, 603);
            this.Actor_comboBox7.Name = "Actor_comboBox7";
            this.Actor_comboBox7.Size = new System.Drawing.Size(180, 24);
            this.Actor_comboBox7.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(954, 636);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 48);
            this.button8.TabIndex = 25;
            this.button8.Text = "Выполнить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(324, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(624, 49);
            this.label9.TabIndex = 26;
            this.label9.Text = "1. Для заданного жанра опледелить все фильмы, чья стоимость  меньше, чем заданный" +
    " фильм из заданной страны";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(324, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(778, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "2. Найти долю дешевых долю дорогих фильмов для заданной страны заданного жанра";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(324, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(778, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "3. Найти страны, где показано наибольшее число фильмов заданного жанра";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(324, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(596, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "4. Найти всех актёров каждый из которых либо мужчина, либо живёт в Париже";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(324, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(615, 59);
            this.label13.TabIndex = 30;
            this.label13.Text = "5. Найти имена и адреса всех актёров, которые одновременно являются продюсерами с" +
    " состоянием свыше 100000$";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(324, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(624, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "6. Для заданного актёра найти в каких фильмах он снимался в заданном году";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(324, 552);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(624, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "7. Найти кто из продюсеров обладает большим состоянием чем заданный актёр";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(324, 636);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(615, 22);
            this.label16.TabIndex = 33;
            this.label16.Text = "8. Найти всех продюсеров, кто одновременно является и актёрами";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(589, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 23);
            this.label17.TabIndex = 34;
            this.label17.Text = "Год";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(19, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(286, 23);
            this.label18.TabIndex = 35;
            this.label18.Text = "Результат";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 720);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Actor_comboBox7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Year_numericUpDown6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Actor_comboBox6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Genre_comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Country_comboBox2);
            this.Controls.Add(this.Genre_comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Country_comboBox1);
            this.Controls.Add(this.Film_comboBox1);
            this.Controls.Add(this.Genre_comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Genre_comboBox1;
        private System.Windows.Forms.ComboBox Film_comboBox1;
        private System.Windows.Forms.ComboBox Country_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Country_comboBox2;
        private System.Windows.Forms.ComboBox Genre_comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Genre_comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Actor_comboBox6;
        private System.Windows.Forms.NumericUpDown Year_numericUpDown6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Actor_comboBox7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}