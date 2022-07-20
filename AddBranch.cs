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
    public partial class AddBranch : Form
    {
        connection ob = new connection();
        public AddBranch()
        {
            InitializeComponent();
        }
        public string getbranchid()
        {
            int c = 0;
            ob.dr = ob.ret_dr("select isnull(max(branchid),1000)+1 from branch");
            if (ob.dr.Read())
            {
                c = Convert.ToInt32(ob.dr[0].ToString());
            }
            return c.ToString();
        }
        public void insertdb()
        {
            if(txtcateg.Text==string.Empty)
            {
                MessageBox.Show("Please Enter Details");
            }

            else if (txtdes.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Branch Name");
            }
            else
            {
                int status = 0;
                int p = 0;
                string query = "insert into branch values(" + textBox1.Text + ",'" + txtdes.Text + "','" + txtcateg.Text + "'," + status + ")";
                ob.exec1(query);
                MessageBox.Show("Details Added Successfully");
            }

        }
        private void btbdesc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || txtdes.Text == "" || txtcateg.Text == "")
            {
                MessageBox.Show("Please enter the field");
            }
            else
            {
                insertdb();
               
            }
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {
            textBox1.Text = getbranchid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
