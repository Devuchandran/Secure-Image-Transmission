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
    public partial class UpdateOfficer : Form
    {
        connection ob = new connection();
        public UpdateOfficer()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbbrwse_Click(object sender, EventArgs e)
        {
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("Please enter Officer username");
            }
            else
            {
                ob.dr = ob.ret_dr("select * from officer where ousername='" + txtbrwse.Text + "' and status=0");
                if (ob.dr.Read())
                {

                    picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\" + ob.dr[0].ToString() + ".jpg");

                    txtdes.Text = ob.dr[0].ToString();
                    txtcateg.Text = ob.dr[8].ToString();
                    textBox9.Text = ob.dr[9].ToString();
                    textBox2.Text = ob.dr[4].ToString();
                    textBox3.Text = ob.dr[5].ToString();
                    textBox4.Text = ob.dr[6].ToString();
                    textBox6.Text = ob.dr[7].ToString();
                    textBox8.Text = ob.dr[10].ToString();
                    textBox1.Text = ob.dr[1].ToString();

                }
            }
        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
            try
            {
                ob.exec("update officer set officername='" + textBox1.Text + "',age='" + textBox2.Text + "',email='" + textBox6.Text + "',phone='" + textBox4.Text + "',dob='" + textBox3.Text + "', address='" + textBox8.Text + "' where ousername='" + txtbrwse.Text + "'");
                MessageBox.Show("Update Successfully");
                txtdes.Text = "";
                txtcateg.Text = "";
                textBox9.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                textBox1.Text = "";
                txtbrwse.Text = "";
              //  picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\default.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updation Failure");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcateg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar <= '/')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
