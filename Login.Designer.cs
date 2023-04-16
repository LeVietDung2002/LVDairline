namespace airline
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            UidTb = new TextBox();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            PasswordTb = new TextBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            label16 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 417);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Coral;
            label5.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(-3, 234);
            label5.Name = "label5";
            label5.Size = new Size(287, 120);
            label5.TabIndex = 5;
            label5.Text = "Eo Vi Di ee lai";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Coral;
            label4.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(3, 134);
            label4.Name = "label4";
            label4.Size = new Size(284, 50);
            label4.TabIndex = 4;
            label4.Text = "LVD airline";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkMagenta;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(290, 134);
            label2.Name = "label2";
            label2.Size = new Size(211, 50);
            label2.TabIndex = 4;
            label2.Text = "UID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkMagenta;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkKhaki;
            label3.Location = new Point(293, 211);
            label3.Name = "label3";
            label3.Size = new Size(211, 50);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(404, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(551, 289);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UidTb
            // 
            UidTb.BackColor = Color.AntiqueWhite;
            UidTb.Location = new Point(523, 143);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(278, 27);
            UidTb.TabIndex = 8;
            UidTb.TextChanged += UidTb_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(480, 353);
            button3.Name = "button3";
            button3.Size = new Size(94, 58);
            button3.TabIndex = 10;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(523, 163);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 11;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.DarkMagenta;
            label7.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkKhaki;
            label7.Location = new Point(522, 237);
            label7.Name = "label7";
            label7.Size = new Size(278, 10);
            label7.TabIndex = 12;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.AntiqueWhite;
            PasswordTb.Location = new Point(522, 220);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(278, 27);
            PasswordTb.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(718, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(761, -3);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 123;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 33);
            panel2.TabIndex = 124;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSalmon;
            button4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(1100, 3);
            button4.Name = "button4";
            button4.Size = new Size(40, 36);
            button4.TabIndex = 122;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.GradientInactiveCaption;
            label16.FlatStyle = FlatStyle.System;
            label16.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkOrchid;
            label16.Location = new Point(183, 39);
            label16.Name = "label16";
            label16.Size = new Size(800, 82);
            label16.TabIndex = 130;
            label16.Text = "LVD airline";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(284, 121);
            label1.Name = "label1";
            label1.Size = new Size(633, 10);
            label1.TabIndex = 131;
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Location = new Point(284, 274);
            label8.Name = "label8";
            label8.Size = new Size(516, 12);
            label8.TabIndex = 132;
            // 
            // label9
            // 
            label9.BackColor = Color.Black;
            label9.Location = new Point(284, 121);
            label9.Name = "label9";
            label9.Size = new Size(10, 165);
            label9.TabIndex = 133;
            // 
            // label10
            // 
            label10.BackColor = Color.Black;
            label10.Location = new Point(284, 285);
            label10.Name = "label10";
            label10.Size = new Size(10, 165);
            label10.TabIndex = 134;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(284, 33);
            label11.Name = "label11";
            label11.Size = new Size(10, 165);
            label11.TabIndex = 135;
            // 
            // label12
            // 
            label12.BackColor = Color.Black;
            label12.Location = new Point(284, 30);
            label12.Name = "label12";
            label12.Size = new Size(633, 10);
            label12.TabIndex = 136;
            // 
            // label13
            // 
            label13.BackColor = Color.Black;
            label13.Location = new Point(284, 440);
            label13.Name = "label13";
            label13.Size = new Size(633, 10);
            label13.TabIndex = 137;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(UidTb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(PasswordTb);
            Controls.Add(panel2);
            Controls.Add(label16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox UidTb;
        private Button button3;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox PasswordTb;
        private PictureBox pictureBox2;
        private Button button5;
        private Panel panel2;
        private Button button4;
        private Label label16;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}