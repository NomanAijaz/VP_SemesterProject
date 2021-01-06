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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pbPicOfUserLoginForm.ImageLocation = @"E:\VP projects\BreezeStore\pics\keys.jpg";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.ShowDialog();
        }
    }
}
