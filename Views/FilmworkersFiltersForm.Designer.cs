namespace FilmsLibrary.Views
{
    partial class FilmworkersFiltersForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sex_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.City_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Films_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteFW_button = new System.Windows.Forms.Button();
            this.Info_button = new System.Windows.Forms.Button();
            this.Sorting_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Reverse_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список работников киноиндустрии";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 324);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(334, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пол";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sex_comboBox
            // 
            this.Sex_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex_comboBox.FormattingEnabled = true;
            this.Sex_comboBox.Items.AddRange(new object[] {
            "Все",
            "мужской",
            "женский"});
            this.Sex_comboBox.Location = new System.Drawing.Point(337, 115);
            this.Sex_comboBox.Name = "Sex_comboBox";
            this.Sex_comboBox.Size = new System.Drawing.Size(241, 24);
            this.Sex_comboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(334, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(334, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "От";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(334, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "До";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(337, 241);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Country_comboBox.Location = new System.Drawing.Point(337, 303);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(241, 24);
            this.Country_comboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(334, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Страна";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // City_comboBox
            // 
            this.City_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City_comboBox.FormattingEnabled = true;
            this.City_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.City_comboBox.Location = new System.Drawing.Point(337, 368);
            this.City_comboBox.Name = "City_comboBox";
            this.City_comboBox.Size = new System.Drawing.Size(241, 24);
            this.City_comboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(334, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 35);
            this.label7.TabIndex = 11;
            this.label7.Text = "Город";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(337, 451);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(241, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(334, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "От";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(334, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "До";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(337, 495);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(241, 22);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(334, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 35);
            this.label10.TabIndex = 17;
            this.label10.Text = "Финансовое состояние";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(12, 548);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(302, 49);
            this.Add_button.TabIndex = 18;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Films_comboBox
            // 
            this.Films_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Films_comboBox.FormattingEnabled = true;
            this.Films_comboBox.Items.AddRange(new object[] {
            "Все"});
            this.Films_comboBox.Location = new System.Drawing.Point(337, 567);
            this.Films_comboBox.Name = "Films_comboBox";
            this.Films_comboBox.Size = new System.Drawing.Size(241, 24);
            this.Films_comboBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(334, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 35);
            this.label11.TabIndex = 19;
            this.label11.Text = "Films";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteFW_button
            // 
            this.DeleteFW_button.Enabled = false;
            this.DeleteFW_button.Location = new System.Drawing.Point(12, 436);
            this.DeleteFW_button.Name = "DeleteFW_button";
            this.DeleteFW_button.Size = new System.Drawing.Size(302, 49);
            this.DeleteFW_button.TabIndex = 21;
            this.DeleteFW_button.Text = "Удалить работника из базы данных";
            this.DeleteFW_button.UseVisualStyleBackColor = true;
            this.DeleteFW_button.Visible = false;
            this.DeleteFW_button.Click += new System.EventHandler(this.DeleteFW_button_ClickAsync);
            // 
            // Info_button
            // 
            this.Info_button.Location = new System.Drawing.Point(12, 491);
            this.Info_button.Name = "Info_button";
            this.Info_button.Size = new System.Drawing.Size(302, 49);
            this.Info_button.TabIndex = 22;
            this.Info_button.Text = "Вся информация";
            this.Info_button.UseVisualStyleBackColor = true;
            this.Info_button.Click += new System.EventHandler(this.Info_button_Click);
            // 
            // Sorting_comboBox
            // 
            this.Sorting_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sorting_comboBox.FormattingEnabled = true;
            this.Sorting_comboBox.Items.AddRange(new object[] {
            "по имени",
            "по фамилии",
            "по возрасту",
            "по финансовому состоянию"});
            this.Sorting_comboBox.Location = new System.Drawing.Point(337, 60);
            this.Sorting_comboBox.Name = "Sorting_comboBox";
            this.Sorting_comboBox.Size = new System.Drawing.Size(207, 24);
            this.Sorting_comboBox.TabIndex = 24;          
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(334, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 26);
            this.label12.TabIndex = 23;
            this.label12.Text = "Сортировка";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Reverse_button
            // 
            this.Reverse_button.Location = new System.Drawing.Point(550, 60);
            this.Reverse_button.Name = "Reverse_button";
            this.Reverse_button.Size = new System.Drawing.Size(28, 23);
            this.Reverse_button.TabIndex = 25;
            this.Reverse_button.Text = "↑";
            this.Reverse_button.UseVisualStyleBackColor = true;
            this.Reverse_button.Click += new System.EventHandler(this.Reverse_button_Click);
            // 
            // FilmworkersFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 611);
            this.Controls.Add(this.Reverse_button);
            this.Controls.Add(this.Sorting_comboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Info_button);
            this.Controls.Add(this.DeleteFW_button);
            this.Controls.Add(this.Films_comboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.City_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Country_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sex_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FilmworkersFiltersForm";
            this.Text = "FilmworkersFiltersForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sex_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox City_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox Films_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteFW_button;
        private System.Windows.Forms.Button Info_button;
        private System.Windows.Forms.ComboBox Sorting_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Reverse_button;
    }
}