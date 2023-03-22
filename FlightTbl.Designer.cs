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
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            FcodeTb = new TextBox();
            label3 = new Label();
            seatNumb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            Fsrc = new ComboBox();
            FDest = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            FDate = new DateTimePicker();
            label15 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(210, 21);
            label1.Name = "label1";
            label1.Size = new Size(511, 50);
            label1.TabIndex = 4;
            label1.Text = "LVD airline";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(226, 132);
            label2.Name = "label2";
            label2.Size = new Size(511, 50);
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
            // seatNumb
            // 
            seatNumb.BackColor = Color.AntiqueWhite;
            seatNumb.Location = new Point(277, 425);
            seatNumb.Name = "seatNumb";
            seatNumb.Size = new Size(278, 27);
            seatNumb.TabIndex = 14;
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
            button1.Location = new Point(277, 535);
            button1.Name = "button1";
            button1.Size = new Size(115, 58);
            button1.TabIndex = 22;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkKhaki;
            button2.Location = new Point(444, 535);
            button2.Name = "button2";
            button2.Size = new Size(111, 58);
            button2.TabIndex = 23;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(598, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 289);
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
            FDate.Location = new Point(277, 493);
            FDate.Name = "FDate";
            FDate.Size = new Size(250, 27);
            FDate.TabIndex = 26;
            // 
            // label15
            // 
            label15.BackColor = Color.GhostWhite;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkKhaki;
            label15.Location = new Point(930, 0);
            label15.Name = "label15";
            label15.Size = new Size(46, 32);
            label15.TabIndex = 56;
            label15.Text = "X";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += label15_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.Controls.Add(label15);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 32);
            panel2.TabIndex = 57;
            panel2.Paint += panel2_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(1114, 0);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 0;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkKhaki;
            button3.Location = new Point(610, 535);
            button3.Name = "button3";
            button3.Size = new Size(168, 58);
            button3.TabIndex = 58;
            button3.Text = "View Flight";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(976, 621);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(FDate);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDest);
            Controls.Add(Fsrc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(seatNumb);
            Controls.Add(label6);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox FcodeTb;
        private Label label3;
        private TextBox seatNumb;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox Fsrc;
        private ComboBox FDest;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label9;
        private DateTimePicker FDate;
        private Label label15;
        private Panel panel2;
        private Button button5;
        private Button button3;
    }
}