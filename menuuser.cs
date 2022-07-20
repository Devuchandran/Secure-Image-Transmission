using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecureTransferMI;

namespace SecureTransferMI
{
    public partial class menuuser : Form
    {
        private string picpath=null;
        public menuuser()
        {
            InitializeComponent();
            
        }

        private void btbcls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
          
            

        }

        private void btbdelete_Click(object sender, EventArgs e)
        {

            //userdel obj = new userdel();
            //obj.Show();

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

            
        private void btbdraw_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            ViewProfileOfficer obj = new ViewProfileOfficer();
            obj.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AddCriminal obj = new AddCriminal();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateCrimial obj = new UpdateCrimial();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCriminal obj = new DeleteCriminal();
            obj.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            R_1_LoadImage obj = new R_1_LoadImage();
            obj.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ViewProfileOfficer obj = new ViewProfileOfficer();
            obj.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           
        }
        
        

        
    }
}
