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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            this.Hide();
            administration.ShowDialog();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            this.Hide();
            userLogin.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbWelcome.ImageLocation = @"E:\VP projects\BreezeStore\pics\breeze1.png";
        }
    }
}
