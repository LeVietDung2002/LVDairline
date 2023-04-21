namespace airline
{
    partial class ViewFlights
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
            label2 = new Label();
            label1 = new Label();
            FDate = new DateTimePicker();
            label9 = new Label();
            DstCb = new ComboBox();
            SrcCb = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Seatnum = new TextBox();
            label6 = new Label();
            FcodeTb = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            FlightDGV = new DataGridView();
            FLand = new DateTimePicker();
            label10 = new Label();
            button5 = new Button();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label12 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel2 = new Panel();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSalmon;
            label2.Location = new Point(4, 101);
            label2.Name = "label2";
            label2.Size = new Size(1098, 59);
            label2.TabIndex = 26;
            label2.Text = "View Scheduled Flights";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(1097, 53);
            label1.TabIndex = 25;
            label1.Text = "LVD airline";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FDate
            // 
            FDate.Location = new Point(220, 283);
            FDate.Name = "FDate";
            FDate.Size = new Size(250, 27);
            FDate.TabIndex = 38;
            FDate.ValueChanged += FDate_ValueChanged;
            // 
            // label9
            // 
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(34, 279);
            label9.Name = "label9";
            label9.Size = new Size(166, 35);
            label9.TabIndex = 37;
            label9.Text = "Take of date:";
            // 
            // DstCb
            // 
            DstCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            DstCb.ForeColor = SystemColors.ActiveBorder;
            DstCb.FormattingEnabled = true;
            DstCb.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            DstCb.Location = new Point(766, 299);
            DstCb.Name = "DstCb";
            DstCb.Size = new Size(186, 43);
            DstCb.TabIndex = 36;
            DstCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // SrcCb
            // 
            SrcCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SrcCb.ForeColor = SystemColors.ActiveBorder;
            SrcCb.FormattingEnabled = true;
            SrcCb.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            SrcCb.Location = new Point(766, 236);
            SrcCb.Name = "SrcCb";
            SrcCb.Size = new Size(186, 43);
            SrcCb.TabIndex = 35;
            SrcCb.SelectedIndexChanged += SrcCb_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.BackColor = Color.FloralWhite;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(584, 307);
            label8.Name = "label8";
            label8.Size = new Size(140, 35);
            label8.TabIndex = 34;
            label8.Text = "Destination:";
            // 
            // label7
            // 
            label7.BackColor = Color.FloralWhite;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(584, 244);
            label7.Name = "label7";
            label7.Size = new Size(140, 35);
            label7.TabIndex = 33;
            label7.Text = "Source:";
            // 
            // label5
            // 
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(292, 424);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 32;
            label5.Text = "Numb seat:";
            // 
            // label4
            // 
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 213);
            label4.Name = "label4";
            label4.Size = new Size(156, 34);
            label4.TabIndex = 31;
            label4.Text = "Flight code:";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkMagenta;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkKhaki;
            label3.Location = new Point(456, 446);
            label3.Name = "label3";
            label3.Size = new Size(278, 10);
            label3.TabIndex = 30;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Seatnum
            // 
            Seatnum.BackColor = Color.AntiqueWhite;
            Seatnum.Location = new Point(456, 425);
            Seatnum.Name = "Seatnum";
            Seatnum.Size = new Size(278, 27);
            Seatnum.TabIndex = 29;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(220, 237);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 28;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FcodeTb
            // 
            FcodeTb.BackColor = Color.AntiqueWhite;
            FcodeTb.Location = new Point(220, 220);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(278, 27);
            FcodeTb.TabIndex = 27;
            FcodeTb.TextChanged += FcodeTb_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkKhaki;
            button2.Location = new Point(534, 462);
            button2.Name = "button2";
            button2.Size = new Size(109, 58);
            button2.TabIndex = 41;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkKhaki;
            button1.Location = new Point(292, 462);
            button1.Name = "button1";
            button1.Size = new Size(118, 58);
            button1.TabIndex = 40;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkKhaki;
            button3.Location = new Point(416, 462);
            button3.Name = "button3";
            button3.Size = new Size(112, 58);
            button3.TabIndex = 42;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkKhaki;
            button4.Location = new Point(649, 462);
            button4.Name = "button4";
            button4.Size = new Size(113, 58);
            button4.TabIndex = 43;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FlightDGV
            // 
            FlightDGV.BackgroundColor = SystemColors.ControlLightLight;
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightDGV.Location = new Point(25, 545);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.RowHeadersWidth = 51;
            FlightDGV.RowTemplate.Height = 29;
            FlightDGV.Size = new Size(1060, 321);
            FlightDGV.TabIndex = 76;
            FlightDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // FLand
            // 
            FLand.Location = new Point(220, 341);
            FLand.Name = "FLand";
            FLand.Size = new Size(250, 27);
            FLand.TabIndex = 78;
            FLand.ValueChanged += FLand_ValueChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.FloralWhite;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(34, 337);
            label10.Name = "label10";
            label10.Size = new Size(157, 38);
            label10.TabIndex = 77;
            label10.Text = "Date of Land:";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(1055, 3);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 79;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(-3, 160);
            label11.Name = "label11";
            label11.Size = new Size(1104, 10);
            label11.TabIndex = 80;
            // 
            // label13
            // 
            label13.BackColor = Color.Black;
            label13.Location = new Point(0, 163);
            label13.Name = "label13";
            label13.Size = new Size(10, 375);
            label13.TabIndex = 82;
            // 
            // label14
            // 
            label14.BackColor = Color.Black;
            label14.Location = new Point(1091, 170);
            label14.Name = "label14";
            label14.Size = new Size(10, 375);
            label14.TabIndex = 83;
            // 
            // label15
            // 
            label15.BackColor = Color.Black;
            label15.Location = new Point(-3, 406);
            label15.Name = "label15";
            label15.Size = new Size(1104, 10);
            label15.TabIndex = 84;
            // 
            // label16
            // 
            label16.BackColor = Color.Black;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(10, 375);
            label16.TabIndex = 85;
            // 
            // label17
            // 
            label17.BackColor = Color.Black;
            label17.Location = new Point(1091, 0);
            label17.Name = "label17";
            label17.Size = new Size(10, 375);
            label17.TabIndex = 86;
            // 
            // label18
            // 
            label18.BackColor = Color.Black;
            label18.Location = new Point(-3, -1);
            label18.Name = "label18";
            label18.Size = new Size(1104, 10);
            label18.TabIndex = 87;
            // 
            // label12
            // 
            label12.BackColor = Color.Black;
            label12.Location = new Point(0, 501);
            label12.Name = "label12";
            label12.Size = new Size(10, 375);
            label12.TabIndex = 88;
            // 
            // label19
            // 
            label19.BackColor = Color.Black;
            label19.Location = new Point(1091, 501);
            label19.Name = "label19";
            label19.Size = new Size(10, 375);
            label19.TabIndex = 89;
            // 
            // label20
            // 
            label20.BackColor = Color.Black;
            label20.Location = new Point(-3, 876);
            label20.Name = "label20";
            label20.Size = new Size(1104, 10);
            label20.TabIndex = 90;
            // 
            // label21
            // 
            label21.BackColor = Color.Black;
            label21.Location = new Point(0, 91);
            label21.Name = "label21";
            label21.Size = new Size(1104, 10);
            label21.TabIndex = 91;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 42);
            panel2.TabIndex = 124;
            // 
            // label22
            // 
            label22.BackColor = Color.Black;
            label22.Location = new Point(0, 528);
            label22.Name = "label22";
            label22.Size = new Size(1104, 10);
            label22.TabIndex = 125;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1093, 878);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label12);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(FLand);
            Controls.Add(label10);
            Controls.Add(FlightDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDate);
            Controls.Add(label9);
            Controls.Add(DstCb);
            Controls.Add(SrcCb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Seatnum);
            Controls.Add(label6);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker FDate;
        private Label label9;
        private ComboBox DstCb;
        private ComboBox SrcCb;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Seatnum;
        private Label label6;
        private TextBox FcodeTb;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private DataGridView FlightDGV;
        private DateTimePicker FLand;
        private Label label10;
        private Button button5;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label12;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel2;
        private Label label22;
    }
}