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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string ISBN = tbISBN.Text, Title = tbTitle.Text, PublicationYear = tbPublicationYear.Text, Author_id = tbAuthor_id.Text;
            string query = "INSERT INTO BOOK (ISBN,AUTHOR_ID,BOOK_TITLE,PUBLICATION_YEAR) VALUES ('" + ISBN + "','" + Author_id + "' ,'" + Title + "','" + PublicationYear + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbPublicationYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string ISBN = tbISBN.Text;
            string query = "DELETE FROM BOOK where ISBN='" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string ISBN = tbISBN.Text, Title = tbTitle.Text, PublicationYear = tbPublicationYear.Text;
            string query = "UPDATE BOOK SET BOOK_TITLE = '" + Title + "', PUBLICATION_YEAR = '" + PublicationYear + "' WHERE ISBN = '" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated");
        }

        private void tbAuthor_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

       
    }
}
