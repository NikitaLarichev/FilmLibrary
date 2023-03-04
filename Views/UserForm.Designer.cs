namespace FilmsLibrary.Views
{
    partial class UserForm
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
            this.Films_listBox = new System.Windows.Forms.ListBox();
            this.Sorting_comboBox = new System.Windows.Forms.ComboBox();
            this.Reverse_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Genre_comboBox = new System.Windows.Forms.ComboBox();
            this.Genre_listBox = new System.Windows.Forms.ListBox();
            this.Actor_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Actor_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Producer_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Year1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Year2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Budget2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Budget1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Box2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Box1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Rating2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Rating1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ActorsFilters_button = new System.Windows.Forms.Button();
            this.ProducerFilter_button = new System.Windows.Forms.Button();
            this.DemoCountries_listBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DemoCountry_comboBox = new System.Windows.Forms.ComboBox();
            this.DeleteFilm_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Year1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Budget2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Budget1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating1_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Films_listBox
            // 
            this.Films_listBox.FormattingEnabled = true;
            this.Films_listBox.ItemHeight = 16;
            this.Films_listBox.Location = new System.Drawing.Point(12, 48);
            this.Films_listBox.Name = "Films_listBox";
            this.Films_listBox.Size = new System.Drawing.Size(276, 468);
            this.Films_listBox.TabIndex = 0;
            // 
            // Sorting_comboBox
            // 
            this.Sorting_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sorting_comboBox.FormattingEnabled = true;
            this.Sorting_comboBox.Items.AddRange(new object[] {
            "по названию",
            "по году выхода",
            "по бюджету",
            "по сборам",
            "по странам"});
            this.Sorting_comboBox.Location = new System.Drawing.Point(309, 47);
            this.Sorting_comboBox.Name = "Sorting_comboBox";
            this.Sorting_comboBox.Size = new System.Drawing.Size(223, 24);
            this.Sorting_comboBox.TabIndex = 1;
            // 
            // Reverse_button
            // 
            this.Reverse_button.Location = new System.Drawing.Point(538, 47);
            this.Reverse_button.Name = "Reverse_button";
            this.Reverse_button.Size = new System.Drawing.Size(39, 24);
            this.Reverse_button.TabIndex = 2;
            this.Reverse_button.Text = "↑";
            this.Reverse_button.UseVisualStyleBackColor = true;
            this.Reverse_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(306, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список фильмов:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(306, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Жанры:";
            // 
            // Genre_comboBox
            // 
            this.Genre_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre_comboBox.FormattingEnabled = true;
            this.Genre_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Genre_comboBox.Location = new System.Drawing.Point(309, 100);
            this.Genre_comboBox.Name = "Genre_comboBox";
            this.Genre_comboBox.Size = new System.Drawing.Size(268, 24);
            this.Genre_comboBox.TabIndex = 5;
            // 
            // Genre_listBox
            // 
            this.Genre_listBox.FormattingEnabled = true;
            this.Genre_listBox.ItemHeight = 16;
            this.Genre_listBox.Location = new System.Drawing.Point(309, 125);
            this.Genre_listBox.Name = "Genre_listBox";
            this.Genre_listBox.Size = new System.Drawing.Size(268, 148);
            this.Genre_listBox.TabIndex = 7;
            // 
            // Actor_listBox
            // 
            this.Actor_listBox.FormattingEnabled = true;
            this.Actor_listBox.ItemHeight = 16;
            this.Actor_listBox.Location = new System.Drawing.Point(309, 336);
            this.Actor_listBox.Name = "Actor_listBox";
            this.Actor_listBox.Size = new System.Drawing.Size(268, 180);
            this.Actor_listBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(306, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Актёры:";
            // 
            // Actor_comboBox
            // 
            this.Actor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Actor_comboBox.FormattingEnabled = true;
            this.Actor_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Actor_comboBox.Location = new System.Drawing.Point(309, 311);
            this.Actor_comboBox.Name = "Actor_comboBox";
            this.Actor_comboBox.Size = new System.Drawing.Size(268, 24);
            this.Actor_comboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(592, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Продюсер:";
            // 
            // Producer_comboBox
            // 
            this.Producer_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Producer_comboBox.FormattingEnabled = true;
            this.Producer_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Producer_comboBox.Location = new System.Drawing.Point(595, 101);
            this.Producer_comboBox.Name = "Producer_comboBox";
            this.Producer_comboBox.Size = new System.Drawing.Size(268, 24);
            this.Producer_comboBox.TabIndex = 11;
            this.Producer_comboBox.SelectedIndexChanged += new System.EventHandler(this.Producer_comboBox_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(592, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Год выхода:";
            // 
            // Year1_numericUpDown
            // 
            this.Year1_numericUpDown.Location = new System.Drawing.Point(595, 279);
            this.Year1_numericUpDown.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.Year1_numericUpDown.Name = "Year1_numericUpDown";
            this.Year1_numericUpDown.Size = new System.Drawing.Size(135, 22);
            this.Year1_numericUpDown.TabIndex = 14;
            this.Year1_numericUpDown.ValueChanged += new System.EventHandler(this.Year1_numericUpDown_ValueChanged);
            // 
            // Year2_numericUpDown
            // 
            this.Year2_numericUpDown.Location = new System.Drawing.Point(736, 279);
            this.Year2_numericUpDown.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.Year2_numericUpDown.Name = "Year2_numericUpDown";
            this.Year2_numericUpDown.Size = new System.Drawing.Size(127, 22);
            this.Year2_numericUpDown.TabIndex = 15;
            this.Year2_numericUpDown.Value = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.Year2_numericUpDown.ValueChanged += new System.EventHandler(this.Year2_numericUpDown_ValueChanged);
            // 
            // Budget2_numericUpDown
            // 
            this.Budget2_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Budget2_numericUpDown.Location = new System.Drawing.Point(595, 414);
            this.Budget2_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Budget2_numericUpDown.Name = "Budget2_numericUpDown";
            this.Budget2_numericUpDown.Size = new System.Drawing.Size(268, 22);
            this.Budget2_numericUpDown.TabIndex = 17;
            this.Budget2_numericUpDown.Value = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Budget2_numericUpDown.ValueChanged += new System.EventHandler(this.Budget2_numericUpDown_ValueChanged);
            // 
            // Budget1_numericUpDown
            // 
            this.Budget1_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Budget1_numericUpDown.Location = new System.Drawing.Point(595, 361);
            this.Budget1_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Budget1_numericUpDown.Name = "Budget1_numericUpDown";
            this.Budget1_numericUpDown.Size = new System.Drawing.Size(268, 22);
            this.Budget1_numericUpDown.TabIndex = 16;
            this.Budget1_numericUpDown.ValueChanged += new System.EventHandler(this.Budget1_numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(592, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Бюджет:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(592, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "     от";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(592, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "     до";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(592, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Страна производства:";
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Country_comboBox.Location = new System.Drawing.Point(595, 48);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(268, 24);
            this.Country_comboBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(592, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "     до";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(592, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "     от";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(592, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "Сборы:";
            // 
            // Box2_numericUpDown
            // 
            this.Box2_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Box2_numericUpDown.Location = new System.Drawing.Point(595, 551);
            this.Box2_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Box2_numericUpDown.Name = "Box2_numericUpDown";
            this.Box2_numericUpDown.Size = new System.Drawing.Size(268, 22);
            this.Box2_numericUpDown.TabIndex = 24;
            this.Box2_numericUpDown.Value = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Box2_numericUpDown.ValueChanged += new System.EventHandler(this.Box2_numericUpDown_ValueChanged);
            // 
            // Box1_numericUpDown
            // 
            this.Box1_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Box1_numericUpDown.Location = new System.Drawing.Point(595, 498);
            this.Box1_numericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Box1_numericUpDown.Name = "Box1_numericUpDown";
            this.Box1_numericUpDown.Size = new System.Drawing.Size(268, 22);
            this.Box1_numericUpDown.TabIndex = 23;
            this.Box1_numericUpDown.ValueChanged += new System.EventHandler(this.Box1_numericUpDown_ValueChanged);
            // 
            // Rating2_numericUpDown
            // 
            this.Rating2_numericUpDown.DecimalPlaces = 1;
            this.Rating2_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Rating2_numericUpDown.Location = new System.Drawing.Point(736, 223);
            this.Rating2_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rating2_numericUpDown.Name = "Rating2_numericUpDown";
            this.Rating2_numericUpDown.Size = new System.Drawing.Size(127, 22);
            this.Rating2_numericUpDown.TabIndex = 30;
            this.Rating2_numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rating2_numericUpDown.ValueChanged += new System.EventHandler(this.Rating2_numericUpDown_ValueChanged);
            // 
            // Rating1_numericUpDown
            // 
            this.Rating1_numericUpDown.DecimalPlaces = 1;
            this.Rating1_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Rating1_numericUpDown.Location = new System.Drawing.Point(595, 223);
            this.Rating1_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rating1_numericUpDown.Name = "Rating1_numericUpDown";
            this.Rating1_numericUpDown.Size = new System.Drawing.Size(135, 22);
            this.Rating1_numericUpDown.TabIndex = 29;
            this.Rating1_numericUpDown.ValueChanged += new System.EventHandler(this.Rating1_numericUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(592, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Рейтинг:";
            // 
            // ActorsFilters_button
            // 
            this.ActorsFilters_button.Location = new System.Drawing.Point(309, 527);
            this.ActorsFilters_button.Name = "ActorsFilters_button";
            this.ActorsFilters_button.Size = new System.Drawing.Size(268, 50);
            this.ActorsFilters_button.TabIndex = 31;
            this.ActorsFilters_button.Text = "Дополнительные фильтры для актёров";
            this.ActorsFilters_button.UseVisualStyleBackColor = true;
            this.ActorsFilters_button.Click += new System.EventHandler(this.ActorsFilters_button_ClickAsync);
            // 
            // ProducerFilter_button
            // 
            this.ProducerFilter_button.Location = new System.Drawing.Point(595, 143);
            this.ProducerFilter_button.Name = "ProducerFilter_button";
            this.ProducerFilter_button.Size = new System.Drawing.Size(268, 51);
            this.ProducerFilter_button.TabIndex = 32;
            this.ProducerFilter_button.Text = "Дополнительные фильтры для продюсера";
            this.ProducerFilter_button.UseVisualStyleBackColor = true;
            this.ProducerFilter_button.Click += new System.EventHandler(this.ProducerFilter_button_ClickAsync);
            // 
            // DemoCountries_listBox
            // 
            this.DemoCountries_listBox.FormattingEnabled = true;
            this.DemoCountries_listBox.ItemHeight = 16;
            this.DemoCountries_listBox.Location = new System.Drawing.Point(874, 89);
            this.DemoCountries_listBox.Name = "DemoCountries_listBox";
            this.DemoCountries_listBox.Size = new System.Drawing.Size(250, 484);
            this.DemoCountries_listBox.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(871, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(253, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "В каких странах демонстировался:";
            // 
            // DemoCountry_comboBox
            // 
            this.DemoCountry_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DemoCountry_comboBox.FormattingEnabled = true;
            this.DemoCountry_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.DemoCountry_comboBox.Location = new System.Drawing.Point(874, 48);
            this.DemoCountry_comboBox.Name = "DemoCountry_comboBox";
            this.DemoCountry_comboBox.Size = new System.Drawing.Size(250, 24);
            this.DemoCountry_comboBox.TabIndex = 34;
            // 
            // DeleteFilm_button
            // 
            this.DeleteFilm_button.Enabled = false;
            this.DeleteFilm_button.Location = new System.Drawing.Point(12, 529);
            this.DeleteFilm_button.Name = "DeleteFilm_button";
            this.DeleteFilm_button.Size = new System.Drawing.Size(276, 49);
            this.DeleteFilm_button.TabIndex = 36;
            this.DeleteFilm_button.Text = "Удалить выбранный фильм";
            this.DeleteFilm_button.UseVisualStyleBackColor = true;
            this.DeleteFilm_button.Visible = false;
            this.DeleteFilm_button.Click += new System.EventHandler(this.DeleteFilm_button_ClickAsync);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 590);
            this.Controls.Add(this.DeleteFilm_button);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DemoCountry_comboBox);
            this.Controls.Add(this.DemoCountries_listBox);
            this.Controls.Add(this.ProducerFilter_button);
            this.Controls.Add(this.ActorsFilters_button);
            this.Controls.Add(this.Rating2_numericUpDown);
            this.Controls.Add(this.Rating1_numericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Box2_numericUpDown);
            this.Controls.Add(this.Box1_numericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Country_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Budget2_numericUpDown);
            this.Controls.Add(this.Budget1_numericUpDown);
            this.Controls.Add(this.Year2_numericUpDown);
            this.Controls.Add(this.Year1_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Producer_comboBox);
            this.Controls.Add(this.Actor_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Actor_comboBox);
            this.Controls.Add(this.Genre_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Genre_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reverse_button);
            this.Controls.Add(this.Sorting_comboBox);
            this.Controls.Add(this.Films_listBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Year1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Budget2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Budget1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating1_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Films_listBox;
        private System.Windows.Forms.ComboBox Sorting_comboBox;
        private System.Windows.Forms.Button Reverse_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Genre_comboBox;
        private System.Windows.Forms.ListBox Genre_listBox;
        private System.Windows.Forms.ListBox Actor_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Actor_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Producer_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Year1_numericUpDown;
        private System.Windows.Forms.NumericUpDown Year2_numericUpDown;
        private System.Windows.Forms.NumericUpDown Budget2_numericUpDown;
        private System.Windows.Forms.NumericUpDown Budget1_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Box2_numericUpDown;
        private System.Windows.Forms.NumericUpDown Box1_numericUpDown;
        private System.Windows.Forms.NumericUpDown Rating2_numericUpDown;
        private System.Windows.Forms.NumericUpDown Rating1_numericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ActorsFilters_button;
        private System.Windows.Forms.Button ProducerFilter_button;
        private System.Windows.Forms.ListBox DemoCountries_listBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox DemoCountry_comboBox;
        private System.Windows.Forms.Button DeleteFilm_button;
    }
}