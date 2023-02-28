namespace FilmsLibrary.Views
{
    partial class FilmInfoForm
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
            this.filmName_label = new System.Windows.Forms.Label();
            this.Info_label = new System.Windows.Forms.Label();
            this.Producer_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Actors_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filmName_label
            // 
            this.filmName_label.Location = new System.Drawing.Point(164, 20);
            this.filmName_label.Name = "filmName_label";
            this.filmName_label.Size = new System.Drawing.Size(457, 38);
            this.filmName_label.TabIndex = 0;
            this.filmName_label.Text = "Film_name";
            this.filmName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info_label
            // 
            this.Info_label.Location = new System.Drawing.Point(12, 81);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(332, 357);
            this.Info_label.TabIndex = 1;
            this.Info_label.Text = "Info_label";
            // 
            // Producer_linkLabel
            // 
            this.Producer_linkLabel.Location = new System.Drawing.Point(520, 81);
            this.Producer_linkLabel.Name = "Producer_linkLabel";
            this.Producer_linkLabel.Size = new System.Drawing.Size(268, 28);
            this.Producer_linkLabel.TabIndex = 2;
            this.Producer_linkLabel.TabStop = true;
            this.Producer_linkLabel.Text = "linkLabel1";
            this.Producer_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Producer_linkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(422, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Продюсер: ";
            // 
            // Actors_listBox
            // 
            this.Actors_listBox.FormattingEnabled = true;
            this.Actors_listBox.ItemHeight = 16;
            this.Actors_listBox.Location = new System.Drawing.Point(425, 162);
            this.Actors_listBox.Name = "Actors_listBox";
            this.Actors_listBox.Size = new System.Drawing.Size(238, 276);
            this.Actors_listBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(422, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Актёры:";
            // 
            // FilmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Actors_listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Producer_linkLabel);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.filmName_label);
            this.Name = "FilmInfoForm";
            this.Text = "FilmInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label filmName_label;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.LinkLabel Producer_linkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Actors_listBox;
        private System.Windows.Forms.Label label3;
    }
}