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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string id = tbid.Text;
            string query = "DELETE FROM STUDENT where STUDENT_ID='" + id + "'";
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
            string id = tbid.Text, name = tbname.Text, email = tbemail.Text, password = tbPassword.Text;
            string query = "UPDATE STUDENT SET  STUDENT_NAME = '" + name + "', EMAIL = '" + email + "',PASSWORD='" + password + "' WHERE STUDENT_ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string id = tbid.Text, name = tbname.Text, email = tbemail.Text, password = tbPassword.Text;
            string query = "INSERT INTO STUDENT (STUDENT_ID,EMAIL, PASSWORD,STUDENT_NAME) VALUES ('" + id + "','" + email + "', '" + password + "','" + name + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
