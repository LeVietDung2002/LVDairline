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
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(289, 110);
            label2.Name = "label2";
            label2.Size = new Size(511, 50);
            label2.TabIndex = 26;
            label2.Text = "View Scheduled Flights";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(275, 32);
            label1.Name = "label1";
            label1.Size = new Size(511, 50);
            label1.TabIndex = 25;
            label1.Text = "LVD airline";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FDate
            // 
            FDate.Location = new Point(260, 295);
            FDate.Name = "FDate";
            FDate.Size = new Size(250, 27);
            FDate.TabIndex = 38;
            // 
            // label9
            // 
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkKhaki;
            label9.Location = new Point(-5, 273);
            label9.Name = "label9";
            label9.Size = new Size(265, 50);
            label9.TabIndex = 37;
            label9.Text = "Take of date";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DstCb
            // 
            DstCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            DstCb.ForeColor = SystemColors.ActiveBorder;
            DstCb.FormattingEnabled = true;
            DstCb.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            DstCb.Location = new Point(715, 280);
            DstCb.Name = "DstCb";
            DstCb.Size = new Size(151, 43);
            DstCb.TabIndex = 36;
            DstCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // SrcCb
            // 
            SrcCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SrcCb.ForeColor = SystemColors.ActiveBorder;
            SrcCb.FormattingEnabled = true;
            SrcCb.Items.AddRange(new object[] { "BangKok", "TP.HCM", "Dubai", "Singapore", "Tokyo", "Kyoto", "Madrid", "Da Nang", "Hue", "California" });
            SrcCb.Location = new Point(715, 195);
            SrcCb.Name = "SrcCb";
            SrcCb.Size = new Size(151, 43);
            SrcCb.TabIndex = 35;
            // 
            // label8
            // 
            label8.BackColor = Color.FloralWhite;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkKhaki;
            label8.Location = new Point(525, 273);
            label8.Name = "label8";
            label8.Size = new Size(252, 53);
            label8.TabIndex = 34;
            label8.Text = "Destination";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FloralWhite;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkKhaki;
            label7.Location = new Point(534, 181);
            label7.Name = "label7";
            label7.Size = new Size(252, 53);
            label7.TabIndex = 33;
            label7.Text = "Source";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(225, 395);
            label5.Name = "label5";
            label5.Size = new Size(265, 50);
            label5.TabIndex = 32;
            label5.Text = "Numb seat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(-5, 207);
            label4.Name = "label4";
            label4.Size = new Size(265, 50);
            label4.TabIndex = 31;
            label4.Text = "Flight code";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkMagenta;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkKhaki;
            label3.Location = new Point(490, 430);
            label3.Name = "label3";
            label3.Size = new Size(278, 10);
            label3.TabIndex = 30;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Seatnum
            // 
            Seatnum.BackColor = Color.AntiqueWhite;
            Seatnum.Location = new Point(490, 409);
            Seatnum.Name = "Seatnum";
            Seatnum.Size = new Size(278, 27);
            Seatnum.TabIndex = 29;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(275, 247);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 28;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FcodeTb
            // 
            FcodeTb.BackColor = Color.AntiqueWhite;
            FcodeTb.Location = new Point(275, 230);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(278, 27);
            FcodeTb.TabIndex = 27;
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
            FlightDGV.Location = new Point(-15, 538);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.RowHeadersWidth = 51;
            FlightDGV.RowTemplate.Height = 29;
            FlightDGV.Size = new Size(1117, 348);
            FlightDGV.TabIndex = 76;
            FlightDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1098, 1000);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
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
    }
}