namespace airline
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            label2 = new Label();
            label6 = new Label();
            FcodeTb = new TextBox();
            label3 = new Label();
            FCap = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            Fsrc = new ComboBox();
            FDest = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            FDate = new DateTimePicker();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            FLand = new DateTimePicker();
            label10 = new Label();
            button4 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.DarkKhaki;
            label2.Font = new Font("SimSun", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrchid;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(1128, 88);
            label2.TabIndex = 5;
            label2.Text = "Record New Flights";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(277, 233);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 13;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FcodeTb
            // 
            FcodeTb.BackColor = Color.AntiqueWhite;
            FcodeTb.Location = new Point(277, 216);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(278, 27);
            FcodeTb.TabIndex = 12;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkMagenta;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkKhaki;
            label3.Location = new Point(277, 446);
            label3.Name = "label3";
            label3.Size = new Size(278, 10);
            label3.TabIndex = 15;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FCap
            // 
            FCap.BackColor = Color.AntiqueWhite;
            FCap.Location = new Point(277, 425);
            FCap.Name = "FCap";
            FCap.Size = new Size(278, 27);
            FCap.TabIndex = 14;
            FCap.TextChanged += seatNumb_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(12, 216);
            label4.Name = "label4";
            label4.Size = new Size(265, 50);
            label4.TabIndex = 16;
            label4.Text = "Flight code";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(-5, 402);
            label5.Name = "label5";
            label5.Size = new Size(265, 50);
            label5.TabIndex = 17;
            label5.Text = "Numb seat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FloralWhite;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkKhaki;
            label7.Location = new Point(-55, 279);
            label7.Name = "label7";
            label7.Size = new Size(252, 53);
            label7.TabIndex = 18;
            label7.Text = "Source";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.FloralWhite;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkKhaki;
            label8.Location = new Point(-33, 326);
            label8.Name = "label8";
            label8.Size = new Size(252, 53);
            label8.TabIndex = 19;
            label8.Text = "Destination";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fsrc
            // 
            Fsrc.BackColor = SystemColors.Window;
            Fsrc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Fsrc.ForeColor = Color.Red;
            Fsrc.FormattingEnabled = true;
            Fsrc.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            Fsrc.Location = new Point(277, 279);
            Fsrc.Name = "Fsrc";
            Fsrc.Size = new Size(151, 43);
            Fsrc.TabIndex = 20;
            Fsrc.SelectedIndexChanged += Fsrc_SelectedIndexChanged;
            // 
            // FDest
            // 
            FDest.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            FDest.ForeColor = Color.Red;
            FDest.FormattingEnabled = true;
            FDest.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            FDest.Location = new Point(277, 332);
            FDest.Name = "FDest";
            FDest.Size = new Size(151, 43);
            FDest.TabIndex = 21;
            FDest.SelectedIndexChanged += FDest_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkKhaki;
            button1.Location = new Point(296, 651);
            button1.Name = "button1";
            button1.Size = new Size(169, 58);
            button1.TabIndex = 22;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(587, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkKhaki;
            label9.Location = new Point(-5, 470);
            label9.Name = "label9";
            label9.Size = new Size(265, 50);
            label9.TabIndex = 25;
            label9.Text = "Take of date";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FDate
            // 
            FDate.Location = new Point(305, 492);
            FDate.Name = "FDate";
            FDate.Size = new Size(250, 27);
            FDate.TabIndex = 26;
            FDate.ValueChanged += FDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 32);
            panel2.TabIndex = 57;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSalmon;
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(1100, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 122;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkKhaki;
            button3.Location = new Point(471, 651);
            button3.Name = "button3";
            button3.Size = new Size(168, 58);
            button3.TabIndex = 58;
            button3.Text = "View Flight";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FLand
            // 
            FLand.Location = new Point(305, 566);
            FLand.Name = "FLand";
            FLand.Size = new Size(250, 27);
            FLand.TabIndex = 59;
            // 
            // label10
            // 
            label10.BackColor = Color.FloralWhite;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkKhaki;
            label10.Location = new Point(-42, 544);
            label10.Name = "label10";
            label10.Size = new Size(344, 50);
            label10.TabIndex = 60;
            label10.Text = "Date of Land";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkKhaki;
            button4.Location = new Point(645, 651);
            button4.Name = "button4";
            button4.Size = new Size(170, 58);
            button4.TabIndex = 62;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(-83, 194);
            label11.Name = "label11";
            label11.Size = new Size(1363, 10);
            label11.TabIndex = 94;
            // 
            // label12
            // 
            label12.BackColor = Color.Black;
            label12.Location = new Point(-128, 615);
            label12.Name = "label12";
            label12.Size = new Size(1363, 10);
            label12.TabIndex = 95;
            // 
            // label13
            // 
            label13.BackColor = Color.Black;
            label13.Location = new Point(1142, -2);
            label13.Name = "label13";
            label13.Size = new Size(10, 617);
            label13.TabIndex = 96;
            // 
            // label14
            // 
            label14.BackColor = Color.Black;
            label14.Location = new Point(0, -1);
            label14.Name = "label14";
            label14.Size = new Size(10, 628);
            label14.TabIndex = 97;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.GradientInactiveCaption;
            label16.FlatStyle = FlatStyle.System;
            label16.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkOrchid;
            label16.Location = new Point(-5, 35);
            label16.Name = "label16";
            label16.Size = new Size(1157, 61);
            label16.TabIndex = 123;
            label16.Text = "LVD airline";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(-107, 96);
            label1.Name = "label1";
            label1.Size = new Size(1363, 10);
            label1.TabIndex = 124;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 33);
            panel1.TabIndex = 60;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1152, 768);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(FLand);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(FDate);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(FDest);
            Controls.Add(Fsrc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FCap);
            Controls.Add(label6);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label6;
        private TextBox FcodeTb;
        private Label label3;
        private TextBox FCap;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox Fsrc;
        private ComboBox FDest;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label9;
        private DateTimePicker FDate;
        private Panel panel2;
        private Button button3;
        private DateTimePicker FLand;
        private Label label10;
        private Button button4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label1;
        private Button button2;
        private Panel panel1;
    }
}