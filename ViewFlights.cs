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
using System.Text.RegularExpressions;

namespace airline
{
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "Select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];


            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = FlightDGV.Rows[e.RowIndex];

            FcodeTb.Text = row.Cells[0].Value.ToString();
            SrcCb.SelectedItem = row.Cells[1].Value.ToString();
            DstCb.SelectedItem = row.Cells[2].Value.ToString();
            FDate.Text = row.Cells[3].Value.ToString();
            Seatnum.Text = row.Cells[4].Value.ToString();

        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FcodeTb.Text = "";

            Seatnum.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter the flight code to delete");
            }
            else
            {
                try
                {
                    // Use a using statement to manage the database connection
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();

                        // Check if the row exists
                        string query = "SELECT COUNT(*) FROM FlightTbl WHERE Fcode = '" + FcodeTb.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Delete the row
                            query = "DELETE FROM FlightTbl WHERE Fcode = '" + FcodeTb.Text + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Flight deleted successfully");
                            populate(); // refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Flight not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the flight. Please try again." + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\LVDairline.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (FcodeTb.Text == "" || SrcCb.SelectedItem == null || DstCb.SelectedItem == null || FDate.Text == "" || Seatnum.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "', FDest='" + DstCb.SelectedItem.ToString() + "', FDate='" + FDate.Value.Date.ToString() + "', FCap='" + Seatnum.Text + "' where Fcode='" + FcodeTb.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Flight Updated Successfully");
                        Con.Close();
                        populate(); // refresh the data in the DataGridView with the updated values
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
    }
}
