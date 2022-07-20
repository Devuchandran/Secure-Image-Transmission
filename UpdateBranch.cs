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
    public partial class UpdateBranch : Form
    {
        connection ob = new connection();
        public UpdateBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter Branch ID");
            }
            else
            {
                ob.dr = ob.ret_dr("select * from branch where branchid='" + textBox1.Text + "' and status=0");
                if (ob.dr.Read())
                {
                    txtdes.Text = ob.dr[1].ToString();
                    txtcateg.Text = ob.dr[2].ToString();
                }
            }
        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
            try
            {
                ob.exec("update branch set branchname='" + txtdes.Text + "',details='" + txtcateg.Text + "' where branchid='" + textBox1.Text + "'");
                MessageBox.Show("Update Successfully");
                txtdes.Text = "";
                txtcateg.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Update failure");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
