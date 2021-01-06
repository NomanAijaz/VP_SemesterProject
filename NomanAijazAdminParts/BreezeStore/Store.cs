using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreezeStore
{
    public partial class Store : Form
    {
         public int price;
        string[] ArrayAd;
        public Store()
        {
            InitializeComponent();

          
        }
        public void slideShow() {
            int n = 0;
            ArrayAd = new string[4];
            ArrayAd[0] = "Slide2.jpg";
            ArrayAd[1] = "slide show3.jpg";
            ArrayAd[2] = "SlideShow2.jpg";
            ArrayAd[3] = "Slideshow4.jpg";
            pbSlideShow.ImageLocation = @"E:\VP projects\BreezeStore\pics\"+ArrayAd[0];
            timer1.Start();

                if (n > 3)
                {
                    n = 0;
                    pbSlideShow.ImageLocation = @"E:\VP projects\BreezeStore\pics\" + ArrayAd[n];
                }

                else
                {
                    pbSlideShow.ImageLocation = @"E:\VP projects\BreezeStore\pics\" + ArrayAd[n];
                    n++;
                }

            pbDress.ImageLocation = @"E:\VP projects\BreezeStore\pics\dressAd.jpg";
            pbShoes.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoesAd.jpg";
            pbMakeup.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeupAd.jpg";
        }

        private void Store_Load(object sender, EventArgs e)
        {
            pbBreeze.ImageLocation = @"E:\VP projects\BreezeStore\pics\breeze.png";
            slideShow();
        }

        private void pbShoes_Click(object sender, EventArgs e)
        {
            Shoes shoes = new Shoes();
            shoes.ShowDialog();
        }

        private void pbDress_Click(object sender, EventArgs e)
        {
            Dresses dresses = new Dresses();
            dresses.ShowDialog();
        }

        private void pbSlideShow_Click(object sender, EventArgs e)
        {

        }

        private void pbMakeup_Click(object sender, EventArgs e)
        {
            Makeup makeup = new Makeup();
            makeup.ShowDialog();
        }
    }
}
