using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        // Function to calculate the MD5 hash of a string
        private static string CalculateMD5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider class.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new StringBuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            foreach (byte b in data)
            {
                sBuilder.Append(b.ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
