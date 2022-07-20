using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecureTransferMI
{
    public partial class BasePage : Form
    {
        public BasePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            S_1_LoadImages obj = new S_1_LoadImages();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            R_1_LoadImage obj = new R_1_LoadImage();
            obj.Show();
        }
    }
}
