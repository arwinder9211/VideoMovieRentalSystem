﻿namespace VideoMovieRentalSystem
{
    partial class MovieForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.TextBox();
            this.Copies = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 60;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(99, 295);
            this.Genre.Multiline = true;
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(286, 53);
            this.Genre.TabIndex = 59;
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(99, 224);
            this.Plot.Multiline = true;
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(286, 53);
            this.Plot.TabIndex = 58;
            // 
            // Copies
            // 
            this.Copies.Location = new System.Drawing.Point(99, 187);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(135, 20);
            this.Copies.TabIndex = 57;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(99, 141);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(135, 20);
            this.Year.TabIndex = 56;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(99, 23);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(286, 53);
            this.Title.TabIndex = 54;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(99, 100);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(286, 20);
            this.Rating.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Rating";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Plot;
        private System.Windows.Forms.TextBox Copies;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}