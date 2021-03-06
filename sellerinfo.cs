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

namespace GadgetsManagementSystem
{
    public partial class sellerinfo : Form
    {
        DataTable table = new DataTable();
        MySqlConnection connection;
        String ID = "";
        public sellerinfo()
        {
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty.Trim() || textBoxCellNo.Text == string.Empty.Trim() || textBoxEmail.Text == string.Empty.Trim() || textBoxAccNo.Text == string.Empty.Trim() || comboBoxGender.Text == string.Empty.Trim() || comboBoxGadget.Text == string.Empty.Trim() || textBoxModal.Text == string.Empty.Trim() || textBoxRAM.Text == string.Empty.Trim() || textBoxColor.Text == string.Empty.Trim() || textBoxPrice.Text == string.Empty.Trim())
            {
                MessageBox.Show("Please fill all the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Sell?","Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");

                        string query = "insert into sellerinfo(Name, CellNo, Email, AccountNo, Gender, Gadget, Model, RAM, Colour, Price) values(@Name, @CellNo, @Email, @AccountNo, @Gender, @Gadget, @Model, @RAM, @Colour, @Price)";
                        MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                        sqlCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                        sqlCommand.Parameters.AddWithValue("@CellNo", textBoxCellNo.Text);
                        sqlCommand.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@AccountNo", textBoxAccNo.Text);
                        sqlCommand.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
                        sqlCommand.Parameters.AddWithValue("@Gadget", comboBoxGadget.Text);
                        sqlCommand.Parameters.AddWithValue("@Model", textBoxModal.Text);
                        sqlCommand.Parameters.AddWithValue("@RAM", textBoxRAM.Text);
                        sqlCommand.Parameters.AddWithValue("@Colour", textBoxColor.Text);
                        sqlCommand.Parameters.AddWithValue("@Price", textBoxPrice.Text);
     

                        connection.Open();
                        int records = sqlCommand.ExecuteNonQuery();
                        connection.Close();

                        if (records > 0)
                        {
                            MessageBox.Show("Product Selled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxName.Clear();
                            textBoxCellNo.Clear();
                            textBoxEmail.Clear();
                            textBoxAccNo.Clear();
                            textBoxModal.Clear();
                            textBoxRAM.Clear();
                            textBoxColor.Clear();
                            textBoxPrice.Clear();
                            loadData();
                        }
                        connection.Close();
                    }

                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
            }
        }

        private void sellerinfo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from sellerinfo";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();

            BUYDataGridView.DataSource = table;

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BUYDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxCellNo.Clear();
            textBoxEmail.Clear();
            textBoxAccNo.Clear();
            textBoxModal.Clear();
            textBoxRAM.Clear();
            textBoxColor.Clear();
            textBoxPrice.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty.Trim() || textBoxCellNo.Text == string.Empty.Trim() || textBoxEmail.Text == string.Empty || textBoxAccNo.Text == string.Empty.Trim() || comboBoxGender.Text == string.Empty.Trim() || comboBoxGadget.Text == string.Empty.Trim() || textBoxRAM.Text == string.Empty.Trim() || textBoxColor.Text == string.Empty.Trim() || textBoxModal.Text == string.Empty.Trim() || textBoxPrice.Text == string.Empty.Trim())
            {
                MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");

                        string query = "delete from sellerinfo where ID = @ID";
                        MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                        sqlCommand.Parameters.AddWithValue("@ID", ID);

                        connection.Open();
                        int records = sqlCommand.ExecuteNonQuery();

                        if (records > 0)
                        {
                            MessageBox.Show("Product Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBoxName.Clear();
                            textBoxCellNo.Clear();
                            textBoxEmail.Clear();
                            textBoxAccNo.Clear();
                            textBoxModal.Clear();
                            textBoxRAM.Clear();
                            textBoxColor.Clear();
                            textBoxName.Clear();
                            loadData();
                        }
                        connection.Close();
                    }

                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }




            }
        }

            private void BUYDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex; // getting current row index

                DataGridViewRow row = BUYDataGridView.Rows[i]; // getting all row data, on that index

                /*Displaying each and every row index data to specific textbox*/
                ID = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxCellNo.Text = row.Cells[2].Value.ToString();
                textBoxEmail.Text = row.Cells[3].Value.ToString();
                textBoxAccNo.Text = row.Cells[4].Value.ToString();
                comboBoxGender.Text = row.Cells[5].Value.ToString();
                comboBoxGadget.Text = row.Cells[6].Value.ToString();
                textBoxModal.Text = row.Cells[7].Value.ToString();
                textBoxRAM.Text = row.Cells[8].Value.ToString();
                textBoxColor.Text = row.Cells[9].Value.ToString();
                textBoxPrice.Text = row.Cells[10].Value.ToString();
            }

            catch (Exception)
            {
                // this exception is for, if a user clicks the header row or if row index < 0
                //MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
