using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTb.TextChanged += PasswordTb_TextChanged;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PasswordTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the username and password are correct
            if (string.IsNullOrWhiteSpace(UidTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                MessageBox.Show("Enter user id or password");
                return;
            }

            if (UidTb.Text == "admin" && PasswordTb.Text == "admin")
            {
                MessageBox.Show("Login Successful!");
                // Navigate to the main menu form or dashboard
                Home mainMenu = new Home();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password. Please try again.");
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            PasswordTb.PasswordChar = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UidTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
