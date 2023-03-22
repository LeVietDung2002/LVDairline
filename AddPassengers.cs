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
    public partial class AddPassengers : Form
    {
        public AddPassengers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddPassengers_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassID.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO PassengerTbl VALUES ('" + PassID.Text + "', '" + PassName.Text + "', '" + PassportTb.Text + "', '" + PassAd.Text + "', '" + NationalityCb.SelectedItem.ToString() + "', '" + GenderCb.SelectedItem.ToString() + "', '" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void PassID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassengers viewpass = new ViewPassengers();
            viewpass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
