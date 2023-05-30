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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
       

       

        private void button5_Click_1(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=AHMAD;Initial Catalog=Library;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string id = tbid.Text, Password = tbPassword.Text, email = tbemail.Text;
            string query = "INSERT INTO ADMIN (ADMIN_ID,EMAIL, PASSWORD) VALUES ('" + id + "','" + email + "', '" + Password + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
