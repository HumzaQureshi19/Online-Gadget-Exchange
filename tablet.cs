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
    public partial class tablet : Form
    {
        DataTable table = new DataTable();
        MySqlConnection connection;
        public tablet()
        {
            InitializeComponent();
        }

        private void dataGridViewTabOwn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void tablet_Load(object sender, EventArgs e)
        {
            loadData();
      
        }

        private void loadData()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from tabOwn";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();

            dataGridViewTabOwn.DataSource = table;

        }

        private void loadData1()
        {
            table.Rows.Clear();

            connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=sadia240;database=project;");
            string query = "select * from othersTab";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();
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

       // private void tabbtn_Click(object sender, EventArgs e)
        //{
          //  tablet tabs = new tablet();
            //this.Hide();
            //tabs.Show();
        //}

        private void laptopbtn_Click(object sender, EventArgs e)
        {
            laptop lap = new laptop();
            this.Hide();
            lap.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();

        }

        private int imageNo = 1;

        private void LoadNextImage()
        {
            if (imageNo == 5)
            {
                imageNo = 1;
            }
            picBoxTabSlider1.ImageLocation = string.Format(@"tablets\{0}.png", imageNo);
            imageNo++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
       
        private int imgNo = 21;

        private void LoadNextImg()
        {
            if (imgNo == 23)
            {
                imgNo = 21;
            }
            picBoxTabSlider2.ImageLocation = string.Format(@"tablets\{0}.png", imgNo);
            imgNo++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }

        private int imageeNo = 19;

        private void LoadNextImagee()
        {
            if (imageeNo == 23)
            {
                imageeNo = 19;
            }
            picBoxTabSlider3.ImageLocation = string.Format(@"tablets\{0}.png", imageNo);
            imageeNo++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LoadNextImagee();
        }

        //private void dataGridViewTabOthers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
          //  buyInfo buyerinfo = new buyInfo();
            //this.Hide();
            //buyerinfo.Show();
        //}

        private void buybtn_Click(object sender, EventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            buyInfo buyerinfo = new buyInfo();
            this.Hide();
            buyerinfo.Show();
        }
    }
}
