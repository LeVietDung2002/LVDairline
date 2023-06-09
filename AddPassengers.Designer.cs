﻿namespace airline
{
    partial class AddPassengers
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
            label4 = new Label();
            label6 = new Label();
            PassID = new TextBox();
            label5 = new Label();
            PassName = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            PassAd = new TextBox();
            GenderCb = new ComboBox();
            NationalityCb = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            PhoneTb = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label16 = new Label();
            label17 = new Label();
            PassportTb = new TextBox();
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            label18 = new Label();
            label19 = new Label();
            label1 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(-2, 106);
            label2.Name = "label2";
            label2.Size = new Size(951, 113);
            label2.TabIndex = 28;
            label2.Text = "Record Passengers";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(95, 270);
            label4.Name = "label4";
            label4.Size = new Size(212, 40);
            label4.TabIndex = 34;
            label4.Text = "Passenger ID:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(412, 287);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 33;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PassID
            // 
            PassID.BackColor = Color.AntiqueWhite;
            PassID.Location = new Point(412, 270);
            PassID.Name = "PassID";
            PassID.Size = new Size(278, 27);
            PassID.TabIndex = 32;
            PassID.TextChanged += PassID_TextChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkMagenta;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(412, 357);
            label5.Name = "label5";
            label5.Size = new Size(278, 10);
            label5.TabIndex = 36;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PassName
            // 
            PassName.BackColor = Color.AntiqueWhite;
            PassName.Location = new Point(412, 340);
            PassName.Name = "PassName";
            PassName.Size = new Size(278, 27);
            PassName.TabIndex = 35;
            PassName.TextChanged += PassName_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(95, 340);
            label3.Name = "label3";
            label3.Size = new Size(290, 40);
            label3.TabIndex = 41;
            label3.Text = "Passenger Name:";
            // 
            // label9
            // 
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(97, 484);
            label9.Name = "label9";
            label9.Size = new Size(269, 40);
            label9.TabIndex = 43;
            label9.Text = "Passenger Address:";
            // 
            // label10
            // 
            label10.BackColor = Color.DarkMagenta;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkKhaki;
            label10.Location = new Point(412, 501);
            label10.Name = "label10";
            label10.Size = new Size(278, 10);
            label10.TabIndex = 45;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PassAd
            // 
            PassAd.BackColor = Color.AntiqueWhite;
            PassAd.Location = new Point(412, 484);
            PassAd.Name = "PassAd";
            PassAd.Size = new Size(278, 27);
            PassAd.TabIndex = 44;
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            GenderCb.ForeColor = SystemColors.ActiveBorder;
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "MALE", "FEMALE", "ELSE" });
            GenderCb.Location = new Point(412, 613);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(191, 43);
            GenderCb.TabIndex = 49;
            // 
            // NationalityCb
            // 
            NationalityCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            NationalityCb.ForeColor = SystemColors.ActiveBorder;
            NationalityCb.FormattingEnabled = true;
            NationalityCb.Items.AddRange(new object[] { "INDIAN", "CHINESE\t", "AMERICAN", "VIETNAMESE", "NIGERIAN", "SPANISH", "TURKISH", "ETHIOPAN", "JAPANESE", "KOREAN", "MALAYSIAN", "TAIWANSESE", "THAI" });
            NationalityCb.Location = new Point(412, 543);
            NationalityCb.Name = "NationalityCb";
            NationalityCb.Size = new Size(191, 43);
            NationalityCb.TabIndex = 48;
            NationalityCb.SelectedIndexChanged += NationalityCb_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.BackColor = Color.FloralWhite;
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(95, 620);
            label11.Name = "label11";
            label11.Size = new Size(237, 40);
            label11.TabIndex = 47;
            label11.Text = "Gender:";
            // 
            // label12
            // 
            label12.BackColor = Color.FloralWhite;
            label12.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(95, 550);
            label12.Name = "label12";
            label12.Size = new Size(237, 40);
            label12.TabIndex = 46;
            label12.Text = "Nationality:";
            // 
            // label13
            // 
            label13.BackColor = Color.FloralWhite;
            label13.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(95, 690);
            label13.Name = "label13";
            label13.Size = new Size(271, 40);
            label13.TabIndex = 52;
            label13.Text = "Passenger Phone:";
            // 
            // label14
            // 
            label14.BackColor = Color.DarkMagenta;
            label14.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkKhaki;
            label14.Location = new Point(412, 707);
            label14.Name = "label14";
            label14.Size = new Size(278, 10);
            label14.TabIndex = 51;
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.AntiqueWhite;
            PhoneTb.Location = new Point(412, 690);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(278, 27);
            PhoneTb.TabIndex = 50;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkKhaki;
            button2.Location = new Point(412, 809);
            button2.Name = "button2";
            button2.Size = new Size(103, 58);
            button2.TabIndex = 54;
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
            button1.Location = new Point(306, 809);
            button1.Name = "button1";
            button1.Size = new Size(100, 58);
            button1.TabIndex = 53;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label16
            // 
            label16.BackColor = Color.FloralWhite;
            label16.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(97, 410);
            label16.Name = "label16";
            label16.Size = new Size(269, 40);
            label16.TabIndex = 58;
            label16.Text = "Passport Number:";
            // 
            // label17
            // 
            label17.BackColor = Color.DarkMagenta;
            label17.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkKhaki;
            label17.Location = new Point(412, 427);
            label17.Name = "label17";
            label17.Size = new Size(278, 10);
            label17.TabIndex = 57;
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PassportTb
            // 
            PassportTb.BackColor = Color.AntiqueWhite;
            PassportTb.Location = new Point(412, 410);
            PassportTb.Name = "PassportTb";
            PassportTb.Size = new Size(278, 27);
            PassportTb.TabIndex = 56;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 33);
            panel1.TabIndex = 59;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(909, 3);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 123;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkKhaki;
            button3.Location = new Point(306, 873);
            button3.Name = "button3";
            button3.Size = new Size(315, 41);
            button3.TabIndex = 60;
            button3.Text = "ViewPassenger";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkKhaki;
            button4.Location = new Point(521, 809);
            button4.Name = "button4";
            button4.Size = new Size(100, 58);
            button4.TabIndex = 61;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label18
            // 
            label18.BackColor = Color.Black;
            label18.Location = new Point(-191, 219);
            label18.Name = "label18";
            label18.Size = new Size(1363, 10);
            label18.TabIndex = 124;
            // 
            // label19
            // 
            label19.BackColor = Color.Black;
            label19.Location = new Point(-228, 771);
            label19.Name = "label19";
            label19.Size = new Size(1363, 10);
            label19.TabIndex = 125;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(-2, 36);
            label1.Name = "label1";
            label1.Size = new Size(951, 60);
            label1.TabIndex = 126;
            label1.Text = "LVD airline";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.Black;
            label15.Location = new Point(-273, 96);
            label15.Name = "label15";
            label15.Size = new Size(1363, 10);
            label15.TabIndex = 127;
            // 
            // AddPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(951, 928);
            Controls.Add(label15);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(PassportTb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(PhoneTb);
            Controls.Add(GenderCb);
            Controls.Add(NationalityCb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(PassAd);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(PassName);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(PassID);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassengers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPassengers";
            Load += AddPassengers_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label4;
        private Label label6;
        private TextBox PassID;
        private Label label5;
        private TextBox PassName;
        private Label label8;
        private TextBox PassNameTb;
        private Label label3;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox PassAd;
        private ComboBox GenderCb;
        private ComboBox NationalityCb;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox PhoneTb;
        private Button button2;
        private Button button1;
        private Label label16;
        private Label label17;
        private TextBox PassportTb;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Label label18;
        private Label label19;
        private Label label1;
        private Button button5;
        private Label label15;
    }
}