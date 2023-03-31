using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline
{
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "Select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];


            Con.Close();
        }
        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassengers addpas = new AddPassengers();
            addpas.Show();
            this.Hide();
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PassengerDGV.Rows[e.RowIndex];

            PidTb.Text = row.Cells[0].Value.ToString();
            PnameTb.Text = row.Cells[1].Value.ToString();
            PpassTb.Text = row.Cells[2].Value.ToString();
            PaddTb.Text = row.Cells[3].Value.ToString();
            natcb.SelectedItem = row.Cells[4].Value.ToString();
            GendCb.SelectedItem = row.Cells[5].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Enter the passenger to Delete");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Passengertbl where PassID =" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successully");


                    Con.Close();

                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PidTb.Text = " ";
            PnameTb.Text = " ";
            PpassTb.Text = " ";
            PaddTb.Text = " ";
            natcb.Text = "";
            GendCb.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == " " || PnameTb.Text == " " || PpassTb.Text == " " || PaddTb.Text == " " || natcb.Text == "" || GendCb.Text == " ")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " update PassengerTbl set PassName='" + PnameTb.Text + "', Passport = '" + PpassTb.Text + "', PassAd= '" + PaddTb.Text + "',PassNat='" + natcb.SelectedItem.ToString() + "',PassGend='" + GendCb.SelectedItem.ToString() + "',PassPhone='" + PphoneTb.Text + "' where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    populate(); // refresh the data in the DataGridView with the updated values
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

