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
    public partial class Dresses : Form
    {
        public Dresses()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pbDress4_Click(object sender, EventArgs e)
        {

        }
        public void DresspicLoad() 
        {
            pbDress1.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress1.jpg";
            pbDress2.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress2.jpg";
            pbDress3.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress3.jpg";
            pbDress4.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress4.jpg";
            pbDress5.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress5.jpg";
            pbDress6.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress6.jpg";
            pbDress7.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress7.jpg";
            pbDress8.ImageLocation = @"E:\VP projects\BreezeStore\pics\Dress8.jpg";
           

        }

        private void Dresses_Load(object sender, EventArgs e)
        {
            DresspicLoad();
        }
    }
}
