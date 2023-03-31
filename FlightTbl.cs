using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace airline
{
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || FDate.Text == "" || FLand.Text == "" || FDest.Text == "" || Fsrc.Text == "" || FCap.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            if (Fsrc.SelectedIndex >= 0 && FDest.SelectedIndex >= 0 && Fsrc.SelectedItem.ToString() == FDest.SelectedItem.ToString())
            {
                MessageBox.Show("Please select a different source and destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the selected items are the same
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO FlightTbl VALUES ('" + FcodeTb.Text + "',  '" + Fsrc.SelectedItem.ToString() + "', '" + FDest.SelectedItem.ToString() + "', '" + FDate.Value.ToString() + "', '" + FLand.Value.ToString() + "', '" + FCap.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }




            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            FCap.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlights Viewfl = new ViewFlights();
            Viewfl.Show();
            this.Hide();

        }

        private void Fsrc_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FDest_SelectedIndexChanged(object sender, EventArgs e)
        {



            // Check if the selected item is already in the source combo box

        }

        private void seatNumb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
