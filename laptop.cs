using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GadgetsManagementSystem
{
    public partial class laptop : Form
    {
        DataTable table = new DataTable();
        MySqlConnection connection;
        String ID = "";
        public laptop()
        {
            InitializeComponent();
        }

        private void laptop_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from laptopsOwn";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();

            dataGridViewLaptopsOwn.DataSource = table;

        }

        //private void loadData1()
        //{


        //}

        private void dataGridViewLaptopsOwn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewLaptopsOthers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }

        private void mobbtn_Click(object sender, EventArgs e)
        {
            mobiles mob = new mobiles();
            this.Hide();
            mob.Show();
        }

        private void tabbtn_Click(object sender, EventArgs e)
        {
            tablet tabs = new tablet();
            this.Hide();
            tabs.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private int imageNo = 19;

        private void LoadNextImage()
        {
            if (imageNo == 21)
            {
                imageNo = 19;
            }
            picBoxLaptopSlider1.ImageLocation = string.Format(@"laptops\{0}.png", imageNo);
            imageNo++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private int imgNo = 9;

        private void LoadNextImg()
        {
            if (imgNo == 13)
            {
                imgNo = 9;
            }
            picBoxLaptopSlider2.ImageLocation = string.Format(@"laptops\{0}.png", imgNo);
            imgNo++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }

        private int imageeNo = 13;

        private void LoadNextImagee()
        {
            if (imageeNo == 18)
            {
                imageeNo = 13;
            }
            picBoxLaptopSlider3.ImageLocation = string.Format(@"laptops\{0}.png", imageeNo);
            imageeNo++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LoadNextImagee();
        }

        private void dataGridViewLaptopsOwn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void butbtnn_Click(object sender, EventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }
    }
}
