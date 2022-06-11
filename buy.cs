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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void panelBelow_Paint(object sender, PaintEventArgs e)
        {

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

        private void laptopbtn_Click(object sender, EventArgs e)
        {
            laptop lap = new laptop();
            this.Hide();
            lap.Show();
        }

        private int imageNo = 1;
        private void LoadNextImage()
        {
            if (imageNo == 6)
            {
                imageNo = 1;
            }
            picBoxSlider.ImageLocation = string.Format(@"Images_slider\{0}.jpg", imageNo);
            imageNo++;
        }

        private void timerpicslider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void picBoxSlider_Click(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
