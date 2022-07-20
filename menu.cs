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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btbcls_Click(object sender, EventArgs e)
        {
          
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void btbviews_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
           
        }

        private void btbdelete_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "login")
                    Application.OpenForms[i].Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddOfficer obj = new AddOfficer();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteOfficer obj = new DeleteOfficer();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateOfficer obj = new UpdateOfficer();
            obj.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddBranch obj = new AddBranch();
            obj.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DeleteBranch obj = new DeleteBranch();
            obj.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            UpdateBranch obj = new UpdateBranch();
            obj.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
