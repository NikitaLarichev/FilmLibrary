namespace FilmsLibrary.Views
{
    partial class AdminForm
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
            this.Addfilm_button = new System.Windows.Forms.Button();
            this.AddFilmworker_button = new System.Windows.Forms.Button();
            this.UserForm_button = new System.Windows.Forms.Button();
            this.QueryForm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addfilm_button
            // 
            this.Addfilm_button.Location = new System.Drawing.Point(50, 131);
            this.Addfilm_button.Name = "Addfilm_button";
            this.Addfilm_button.Size = new System.Drawing.Size(268, 68);
            this.Addfilm_button.TabIndex = 0;
            this.Addfilm_button.Text = "Добавить новый фильм";
            this.Addfilm_button.UseVisualStyleBackColor = true;
            this.Addfilm_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFilmworker_button
            // 
            this.AddFilmworker_button.Location = new System.Drawing.Point(50, 32);
            this.AddFilmworker_button.Name = "AddFilmworker_button";
            this.AddFilmworker_button.Size = new System.Drawing.Size(268, 67);
            this.AddFilmworker_button.TabIndex = 1;
            this.AddFilmworker_button.Text = "Добавить нового работника киноиндустрии";
            this.AddFilmworker_button.UseVisualStyleBackColor = true;
            this.AddFilmworker_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserForm_button
            // 
            this.UserForm_button.Location = new System.Drawing.Point(50, 234);
            this.UserForm_button.Name = "UserForm_button";
            this.UserForm_button.Size = new System.Drawing.Size(268, 68);
            this.UserForm_button.TabIndex = 4;
            this.UserForm_button.Text = "Пользовательская форма";
            this.UserForm_button.UseVisualStyleBackColor = true;
            this.UserForm_button.Click += new System.EventHandler(this.UserForm_button_Click);
            // 
            // QueryForm_button
            // 
            this.QueryForm_button.Location = new System.Drawing.Point(50, 335);
            this.QueryForm_button.Name = "QueryForm_button";
            this.QueryForm_button.Size = new System.Drawing.Size(268, 68);
            this.QueryForm_button.TabIndex = 5;
            this.QueryForm_button.Text = "Запросы для задания";
            this.QueryForm_button.UseVisualStyleBackColor = true;
            this.QueryForm_button.Click += new System.EventHandler(this.QueryForm_button_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 415);
            this.Controls.Add(this.QueryForm_button);
            this.Controls.Add(this.UserForm_button);
            this.Controls.Add(this.AddFilmworker_button);
            this.Controls.Add(this.Addfilm_button);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Addfilm_button;
        private System.Windows.Forms.Button AddFilmworker_button;
        private System.Windows.Forms.Button UserForm_button;
        private System.Windows.Forms.Button QueryForm_button;
    }
}