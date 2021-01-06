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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Admistration_Load(object sender, EventArgs e)
        {
            pbPicForAdmistrationForm.ImageLocation = @"E:\VP projects\BreezeStore\pics\keys.jpg";
        }
    }
}
