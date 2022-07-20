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
    public partial class UpdateCrimial : Form
    {
        connection ob = new connection();
        public UpdateCrimial()
        {
            InitializeComponent();
        }

        private void btbbrwse_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter Suspect ID");
            }
            else
            {
                ob.dr = ob.ret_dr("select * from suspect where pid='" + textBox1.Text + "' and pstatus=0");
                if (ob.dr.Read())
                {

                    //  picbxadd.Image = Image.FromFile(Application.StartupPath + "\\ImagePool\\" + ob.dr[16].ToString() + ".jpg");

                    txtdes.Text = ob.dr[1].ToString();
                    txtcateg.Text = ob.dr[2].ToString();
                    textBox2.Text = ob.dr[4].ToString();
                    textBox3.Text = ob.dr[5].ToString();
                    textBox4.Text = ob.dr[8].ToString();
                    textBox5.Text = ob.dr[3].ToString();
                    textBox6.Text = ob.dr[9].ToString();
                    textBox7.Text = ob.dr[10].ToString();
                    textBox8.Text = ob.dr[13].ToString();
                    textBox9.Text = ob.dr[11].ToString();
                    textBox10.Text = ob.dr[12].ToString();
                    textBox11.Text = ob.dr[15].ToString();
                    textBox12.Text = ob.dr[14].ToString();
                    textBox13.Text = ob.dr[6].ToString();
                    textBox14.Text = ob.dr[7].ToString();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ob.exec("update suspect set pname='" + textBox1.Text + "',page='" + textBox2.Text + "',pmark='" + textBox4.Text + "',pdob='" + textBox3.Text + "', peye='" + textBox6.Text + "', pskin='" + textBox7.Text + "', phair='" + textBox9.Text + "',phistory='" + textBox8.Text + "',premark='" + textBox11.Text + "',pheight='"+txtcateg.Text+"' where pid='" + textBox1.Text + "'");
                MessageBox.Show("Update Successfully");
                txtdes.Text = "";
                txtcateg.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
               // picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\default.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updation Failure");
            }
        }

        private void UpdateCrimial_Load(object sender, EventArgs e)
        {

        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}


        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcateg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
