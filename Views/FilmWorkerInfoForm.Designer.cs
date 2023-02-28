namespace FilmsLibrary.Views
{
    partial class FilmWorkerInfoForm
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
            this.Filmography_listBox = new System.Windows.Forms.ListBox();
            this.Filmography_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Info_label = new System.Windows.Forms.Label();
            this.ProducedFilm_label = new System.Windows.Forms.Label();
            this.ProducedFilms_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Filmography_listBox
            // 
            this.Filmography_listBox.FormattingEnabled = true;
            this.Filmography_listBox.ItemHeight = 16;
            this.Filmography_listBox.Location = new System.Drawing.Point(511, 117);
            this.Filmography_listBox.Name = "Filmography_listBox";
            this.Filmography_listBox.Size = new System.Drawing.Size(211, 324);
            this.Filmography_listBox.TabIndex = 0;
            // 
            // Filmography_label
            // 
            this.Filmography_label.Location = new System.Drawing.Point(511, 84);
            this.Filmography_label.Name = "Filmography_label";
            this.Filmography_label.Size = new System.Drawing.Size(211, 30);
            this.Filmography_label.TabIndex = 1;
            this.Filmography_label.Text = "Фильмография:";
            // 
            // Name_label
            // 
            this.Name_label.Location = new System.Drawing.Point(12, 31);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(255, 30);
            this.Name_label.TabIndex = 2;
            this.Name_label.Text = "Name";
            this.Name_label.Click += new System.EventHandler(this.Name_label_Click);
            // 
            // Info_label
            // 
            this.Info_label.Location = new System.Drawing.Point(12, 82);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(276, 359);
            this.Info_label.TabIndex = 3;
            this.Info_label.Text = "Info";
            // 
            // ProducedFilm_label
            // 
            this.ProducedFilm_label.Location = new System.Drawing.Point(294, 84);
            this.ProducedFilm_label.Name = "ProducedFilm_label";
            this.ProducedFilm_label.Size = new System.Drawing.Size(211, 30);
            this.ProducedFilm_label.TabIndex = 5;
            this.ProducedFilm_label.Text = "Спродюсированные фильмы:";
            // 
            // ProducedFilms_listBox
            // 
            this.ProducedFilms_listBox.FormattingEnabled = true;
            this.ProducedFilms_listBox.ItemHeight = 16;
            this.ProducedFilms_listBox.Location = new System.Drawing.Point(294, 117);
            this.ProducedFilms_listBox.Name = "ProducedFilms_listBox";
            this.ProducedFilms_listBox.Size = new System.Drawing.Size(211, 324);
            this.ProducedFilms_listBox.TabIndex = 4;
            // 
            // FilmWorkerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.ProducedFilm_label);
            this.Controls.Add(this.ProducedFilms_listBox);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Filmography_label);
            this.Controls.Add(this.Filmography_listBox);
            this.Name = "FilmWorkerInfoForm";
            this.Text = "FilmInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Filmography_listBox;
        private System.Windows.Forms.Label Filmography_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.Label ProducedFilm_label;
        private System.Windows.Forms.ListBox ProducedFilms_listBox;
    }
}