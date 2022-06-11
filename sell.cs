using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadgetsManagementSystem
{
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
        }

        private void checkBoxMobiles_CheckedChanged(object sender, EventArgs e)
        {
            sellerinfo si = new sellerinfo();
            this.Hide();
            si.Show();
        }

        private void checkBoxTablets_CheckedChanged(object sender, EventArgs e)
        {
            sellerinfo si = new sellerinfo();
            this.Hide();
            si.Show();
        }

        private void checkBoxLaptops_CheckedChanged(object sender, EventArgs e)
        {
            sellerinfo si = new sellerinfo();
            this.Hide();
            si.Show();
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

        private void pictime_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }
    }
}
