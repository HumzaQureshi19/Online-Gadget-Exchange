using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace GadgetsManagementSystem
{
    public partial class mobiles : Form
    {
        DataTable table = new DataTable();
        MySqlConnection connection;
        String ID = "";
        public mobiles()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mobiles_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from mobilesOwn";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();

            dataGridViewMobOwn.DataSource = table;

        }

        private void loadData1()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from othersMobiles";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();
        }

        private void dataGridViewMobOthers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void dataGridViewMobOwn_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void tabbtn_Click(object sender, EventArgs e)
        {
            tablet tabs = new tablet();
            this.Hide();
            tabs.Show();
        }

        private void laptopbtn_Click(object sender, EventArgs e)
        {
            laptop lap = new laptop();
            this.Hide();
            lap.Show();
        }

        private int imageNo = 5;

        private void LoadNextImage()
        {
            if (imageNo == 7)
            {
                imageNo = 5;
            }
            picBoxMobSlider1.ImageLocation = string.Format(@"mobiles\{0}.jpg", imageNo);
            imageNo++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private int imgNo = 7;

        private void LoadNextImg()
        {
            if (imgNo == 11)
            {
                imgNo = 7;
            }
            picBoxMobSlider2.ImageLocation = string.Format(@"mobiles\{0}.jpg", imgNo);
            imgNo++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }

        private int imageeNo = 11;

        private void LoadNextImagee()
        {
            if (imageeNo == 13)
            {
                imageeNo = 11;
            }
            picBoxMobSlider3.ImageLocation = string.Format(@"mobiles\{0}.jpg", imageNo);
            imageeNo++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LoadNextImagee();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
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

        private void mobbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
