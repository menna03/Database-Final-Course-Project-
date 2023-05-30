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


namespace DataBase
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK b LEFT JOIN BORROWED_BOOKS bb ON b.ISBN = bb.ISBN WHERE CONVERT(nvarchar(max), CAST(b.BOOK_TITLE AS varchar(max))) = @BOOK_TITLE", con))
                    {
                        cmd.Parameters.AddWithValue("@BOOK_TITLE", Search.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataView.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["BORROWED_DATE"] == DBNull.Value)
                            {
                                Available.Text = $"Borrowed Status: Available";
                            }
                            else
                            {
                                Available.Text = $"Borrowed Status: Borrowed";
                            }
                        }
                        else
                        {
                            Available.Text = $"Borrowed Status: Book not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Available_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the connection string
                string connectionString = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";

                // Create a new SqlConnection object
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open the connection
                    con.Open();

                    // Create a new SqlCommand object with a simple query to select all columns from the BOOK table
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK", con))
                    {
                        // Create a new SqlDataAdapter object to execute the query and fill a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Set the DataTable as the DataSource property of the DataView object
                        DataView.DataSource = dt;
                        Available.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
