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
    public partial class Makeup : Form
    {
        public Makeup()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void Makeup_Load(object sender, EventArgs e)
        {
            LoadmakeupPics();
        }
        public void LoadmakeupPics()
        {
            pbMakeup1.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup1.jpg";
            pbMakeup2.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup2.jpg";
            pbMakeup3.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup3.jpg";
            pbMakeup4.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup4.jpg";
            pbMakeup5.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup5.jpg";
            pbMakeup6.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup6.jpg";
            pbMakeup7.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup7.jpg";
            pbMakeup8.ImageLocation = @"E:\VP projects\BreezeStore\pics\makeup8.jpg";
        }

        private void pbMakeup8_Click(object sender, EventArgs e)
        {

        }
    }
}
