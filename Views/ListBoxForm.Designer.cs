namespace FilmsLibrary.Views
{
    partial class ListBoxForm
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
            this.CreateNew_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 324);
            this.listBox1.TabIndex = 0;
            // 
            // CreateNew_button
            // 
            this.CreateNew_button.Location = new System.Drawing.Point(1, 429);
            this.CreateNew_button.Name = "CreateNew_button";
            this.CreateNew_button.Size = new System.Drawing.Size(333, 48);
            this.CreateNew_button.TabIndex = 2;
            this.CreateNew_button.Text = "Создать нового";
            this.CreateNew_button.UseVisualStyleBackColor = true;
            this.CreateNew_button.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работники киноиндустрии:";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(4, 368);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(330, 55);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Выбрать";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 483);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNew_button);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBoxForm";
            this.Text = "ListBoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CreateNew_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
    }
}