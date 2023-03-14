using System;
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
            
                PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
                PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
                PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
                PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
                natcb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
                GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            

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
    }
}
