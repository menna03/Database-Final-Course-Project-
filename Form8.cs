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
namespace DataBase

{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Author_ID = textBox1.Text;
            string query = "DELETE FROM AUTHOR where AUTHOR_ID='" + Author_ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Author_ID = textBox1.Text, Name = textBox2.Text;
            string query = "UPDATE AUTHOR SET AUTHOR_NAME = '" + Name + "' WHERE AUTHOR_ID = '" + Author_ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string AuthorID = textBox1.Text, Name = textBox2.Text;
            string query = "INSERT INTO AUTHOR (AUTHOR_ID,AUTHOR_NAME) VALUES ('" + AuthorID + "','" + Name + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
