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
    public partial class Shoes : Form
    {
        public Shoes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Shoes_Load(object sender, EventArgs e)
        {
            LoadShoesPics();
        }
        public void LoadShoesPics()
        {
            pbShoe1.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe1.jpg";
            pbShoe2.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe2.jpg";
            pbShoe3.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe3.jpg";
            pbShoe4.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe4.jpg";
            pbShoe5.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe5.jpg";
            pbShoe6.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe6.jpg";
            pbShoe7.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe7.jpg";
            pbShoe8.ImageLocation = @"E:\VP projects\BreezeStore\pics\shoe8.jpg";
        }

        private void panelShoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
