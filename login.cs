using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecureTransferMI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        connection ob = new connection();

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btb1_Click(object sender, EventArgs e)
        {
             ob.dr = ob.ret_dr("select * from login where uname='" +textBox1.Text + "'");
             if (ob.dr.Read())
             {

                 if ((textBox1.Text == ob.dr[0].ToString()) && textBox2.Text == ob.dr[1].ToString())
                 {
                     if (ob.dr[2].ToString() == "0".ToString())
                     {
                         menu obj = new menu();
                         obj.Show();
                     }
                     else if (ob.dr[2].ToString() == "1".ToString())
                     {
                         Program.uname1 = textBox1.Text;
                         menuuser obj = new menuuser();
                         obj.Show();
                     }
                     else
                     {
                         MessageBox.Show("invalid user");
                     }

                 }

                 else
                 {
                     MessageBox.Show("Incorrect password!!!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 }
             }
             else
             {
                 MessageBox.Show("Incorrect Username!!!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

             }
                
            

       
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btb1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
