namespace airline
{
    partial class CancellationTbl
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
            label20 = new Label();
            TidCb = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            CanId = new TextBox();
            label2 = new Label();
            button5 = new Button();
            CancelDGV = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            FcodeTb = new TextBox();
            grBox = new GroupBox();
            CancDate = new DateTimePicker();
            button4 = new Button();
            label8 = new Label();
            label11 = new Label();
            label1 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)CancelDGV).BeginInit();
            grBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label20
            // 
            label20.BackColor = Color.FloralWhite;
            label20.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.DarkKhaki;
            label20.Location = new Point(147, 605);
            label20.Name = "label20";
            label20.Size = new Size(520, 50);
            label20.TabIndex = 111;
            label20.Text = "Cancellation list";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TidCb
            // 
            TidCb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            TidCb.ForeColor = Color.Red;
            TidCb.FormattingEnabled = true;
            TidCb.Location = new Point(261, 167);
            TidCb.Name = "TidCb";
            TidCb.Size = new Size(151, 43);
            TidCb.TabIndex = 98;
            TidCb.SelectedIndexChanged += TidCb_SelectedIndexChanged;
            TidCb.SelectionChangeCommitted += TidCb_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(23, 230);
            label9.Name = "label9";
            label9.Size = new Size(142, 40);
            label9.TabIndex = 94;
            label9.Text = "Date:";
            // 
            // label7
            // 
            label7.BackColor = Color.FloralWhite;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 110);
            label7.Name = "label7";
            label7.Size = new Size(175, 40);
            label7.TabIndex = 93;
            label7.Text = "Flight Code:";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(190, 40);
            label3.TabIndex = 92;
            label3.Text = "TicketId:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 50);
            label4.Name = "label4";
            label4.Size = new Size(180, 40);
            label4.TabIndex = 91;
            label4.Text = "Cancelled ID:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkMagenta;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(315, 228);
            label6.Name = "label6";
            label6.Size = new Size(278, 10);
            label6.TabIndex = 90;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CanId
            // 
            CanId.BackColor = Color.AntiqueWhite;
            CanId.Location = new Point(315, 211);
            CanId.Name = "CanId";
            CanId.Size = new Size(278, 27);
            CanId.TabIndex = 89;
            CanId.TextChanged += CanId_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Font = new Font("SimSun", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSalmon;
            label2.Location = new Point(-1, 85);
            label2.Name = "label2";
            label2.Size = new Size(809, 60);
            label2.TabIndex = 88;
            label2.Text = "Ticket Cancellation";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(1248, 12);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 113;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            // 
            // CancelDGV
            // 
            CancelDGV.BackgroundColor = SystemColors.ControlLightLight;
            CancelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CancelDGV.Location = new Point(15, 658);
            CancelDGV.Name = "CancelDGV";
            CancelDGV.RowHeadersWidth = 51;
            CancelDGV.RowTemplate.Height = 29;
            CancelDGV.Size = new Size(767, 270);
            CancelDGV.TabIndex = 114;
            CancelDGV.CellContentClick += CancelDGV_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkKhaki;
            button3.Location = new Point(170, 544);
            button3.Name = "button3";
            button3.Size = new Size(131, 58);
            button3.TabIndex = 115;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkKhaki;
            button1.Location = new Point(330, 544);
            button1.Name = "button1";
            button1.Size = new Size(131, 58);
            button1.TabIndex = 116;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkKhaki;
            button2.Location = new Point(494, 544);
            button2.Name = "button2";
            button2.Size = new Size(131, 58);
            button2.TabIndex = 117;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkMagenta;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(315, 285);
            label5.Name = "label5";
            label5.Size = new Size(278, 10);
            label5.TabIndex = 119;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FcodeTb
            // 
            FcodeTb.BackColor = Color.AntiqueWhite;
            FcodeTb.Location = new Point(315, 268);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(278, 27);
            FcodeTb.TabIndex = 118;
            FcodeTb.TextAlign = HorizontalAlignment.Right;
            // 
            // grBox
            // 
            grBox.BackColor = Color.FloralWhite;
            grBox.Controls.Add(CancDate);
            grBox.Controls.Add(label9);
            grBox.Controls.Add(label3);
            grBox.Controls.Add(label7);
            grBox.Controls.Add(label4);
            grBox.Controls.Add(TidCb);
            grBox.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            grBox.ForeColor = SystemColors.ControlText;
            grBox.Location = new Point(54, 158);
            grBox.Name = "grBox";
            grBox.Size = new Size(681, 349);
            grBox.TabIndex = 120;
            grBox.TabStop = false;
            grBox.Enter += grBox_Enter;
            // 
            // CancDate
            // 
            CancDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancDate.Location = new Point(261, 234);
            CancDate.Name = "CancDate";
            CancDate.Size = new Size(250, 27);
            CancDate.TabIndex = 95;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSalmon;
            button4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(757, 0);
            button4.Name = "button4";
            button4.Size = new Size(37, 31);
            button4.TabIndex = 121;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("SimSun-ExtB", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkOrchid;
            label8.Location = new Point(-1, 29);
            label8.Name = "label8";
            label8.Size = new Size(796, 46);
            label8.TabIndex = 122;
            label8.Text = "LVD airline";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(-283, 75);
            label11.Name = "label11";
            label11.Size = new Size(1363, 10);
            label11.TabIndex = 123;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(-252, 145);
            label1.Name = "label1";
            label1.Size = new Size(1363, 10);
            label1.TabIndex = 124;
            // 
            // label10
            // 
            label10.BackColor = Color.Black;
            label10.Location = new Point(-1, 510);
            label10.Name = "label10";
            label10.Size = new Size(796, 10);
            label10.TabIndex = 125;
            // 
            // label12
            // 
            label12.BackColor = Color.Black;
            label12.Location = new Point(-1, 74);
            label12.Name = "label12";
            label12.Size = new Size(10, 1018);
            label12.TabIndex = 126;
            // 
            // label13
            // 
            label13.BackColor = Color.Black;
            label13.Location = new Point(794, -1);
            label13.Name = "label13";
            label13.Size = new Size(14, 587);
            label13.TabIndex = 127;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 32);
            panel1.TabIndex = 128;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSalmon;
            button6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Crimson;
            button6.Location = new Point(909, 3);
            button6.Name = "button6";
            button6.Size = new Size(40, 36);
            button6.TabIndex = 123;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // CancellationTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(794, 934);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(FcodeTb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(CancelDGV);
            Controls.Add(button5);
            Controls.Add(label20);
            Controls.Add(label6);
            Controls.Add(CanId);
            Controls.Add(label2);
            Controls.Add(grBox);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancellationTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTbl";
            Load += CancellationTbl_Load;
            ((System.ComponentModel.ISupportInitialize)CancelDGV).EndInit();
            grBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label20;
        private ComboBox TidCb;
        private Label label9;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox CanId;
        private Label label2;
        private Button button5;
        private DataGridView CancelDGV;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox FcodeTb;
        private GroupBox grBox;
        private DateTimePicker CancDate;
        private Button button4;
        private Label label8;
        private Label label11;
        private Label label1;
        private Label label10;
        private Label label12;
        private Label label13;
        private Panel panel1;
        private Button button6;
    }
}