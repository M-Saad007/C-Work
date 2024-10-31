using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "Data Source=DESKTOP-B8AO3PN;Initial Catalog=login_info;Integrated Security=True";

            string email = textBox1.Text;
            string pass = textBox2.Text;


            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                string query = "INSERT INTO users (PersonID, Email, Pass) VALUES (@PersonID, @Email, @Pass)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PersonID", 10);
                    cmd.Parameters.AddWithValue("@Email", email); 
                    cmd.Parameters.AddWithValue("@Pass", pass); 

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your data has been saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
    }

}
