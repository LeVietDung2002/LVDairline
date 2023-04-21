namespace airline
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(199, 128);
            label1.Name = "label1";
            label1.Size = new Size(423, 50);
            label1.TabIndex = 6;
            label1.Text = "Eo Vi Di Eo Vi Ve";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(121, 378);
            button1.Name = "button1";
            button1.Size = new Size(138, 60);
            button1.TabIndex = 7;
            button1.Text = "Flight";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSalmon;
            button2.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(265, 378);
            button2.Name = "button2";
            button2.Size = new Size(138, 60);
            button2.TabIndex = 8;
            button2.Text = "Passengers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSalmon;
            button3.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(409, 378);
            button3.Name = "button3";
            button3.Size = new Size(138, 60);
            button3.TabIndex = 9;
            button3.Text = "Tickets";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSalmon;
            button4.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(553, 378);
            button4.Name = "button4";
            button4.Size = new Size(138, 60);
            button4.TabIndex = 10;
            button4.Text = "Cancellation";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(-273, 441);
            label2.Name = "label2";
            label2.Size = new Size(1363, 10);
            label2.TabIndex = 127;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 43);
            panel2.TabIndex = 123;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(760, 0);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 122;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(-242, 33);
            label3.Name = "label3";
            label3.Size = new Size(1363, 10);
            label3.TabIndex = 128;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Location = new Point(-288, 118);
            label5.Name = "label5";
            label5.Size = new Size(1363, 10);
            label5.TabIndex = 130;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 43);
            label4.Name = "label4";
            label4.Size = new Size(800, 75);
            label4.TabIndex = 129;
            label4.Text = "LVD airline";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Button button5;
        private Button button6;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label4;
    }
}