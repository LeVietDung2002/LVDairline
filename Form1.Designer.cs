﻿namespace airline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            ProgressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label16 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FloralWhite;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(-2, 410);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(802, 44);
            ProgressBar.TabIndex = 1;
            ProgressBar.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.GradientInactiveCaption;
            label16.FlatStyle = FlatStyle.System;
            label16.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkOrchid;
            label16.Location = new Point(-2, 12);
            label16.Name = "label16";
            label16.Size = new Size(802, 87);
            label16.TabIndex = 125;
            label16.Text = "LVD airline";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(-214, 102);
            label1.Name = "label1";
            label1.Size = new Size(1363, 10);
            label1.TabIndex = 126;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(-294, 410);
            label2.Name = "label2";
            label2.Size = new Size(1363, 10);
            label2.TabIndex = 127;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(ProgressBar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Label label16;
        private Label label1;
        private Label label2;
    }
}