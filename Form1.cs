using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GadgetsManagementSystem;


namespace GadgetsManagementSystem
{
    public partial class LOGIN : Form
    {
        DataTable table = new DataTable();
        MySqlConnection connection;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                table.Clear();
                Welcome welcome = new Welcome();
                this.Hide();
                welcome.Show();
            }
        }

        private bool isValidated()
        {
            if(usertextbox.Text == string.Empty.Trim() || passtext.Text == string.Empty.Trim())
            {
                return false;
            }

            else
            {
                try
                {
                    connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project");
                    connection.Open();

                    string query = "Select userName, passWord from accounts where userName = @userName and passWord = @passWord";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@userName", usertextbox.Text);
                    sqlCommand.Parameters.AddWithValue("@passWord", passtext.Text);

                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    table.Load(reader);
                    connection.Close();

                    if (table.Rows.Count <= 0)
                    {
                        return false;
                    }

                    else
                    {
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    //MessageBox.Show(ex.Message);
                }
               
      

                return false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passcheckBox.Checked == true)
            {
                passtext.UseSystemPasswordChar = false;
            }

            else
            {
                passtext.UseSystemPasswordChar = true;
            }
        }
    }
}
