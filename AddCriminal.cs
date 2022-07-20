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
    public partial class AddCriminal : Form
    {
        public AddCriminal()
        {
            InitializeComponent();
        }
        connection ob = new connection();
        public string str = null;
        public string st, st1;
        public int i = 0;
        private void btbbrwse_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                picbxadd.Image = Image.FromFile(obj.FileName);
                txtbrwse.Text = obj.FileName;
            }
        }
        public string getaccount()
        {
            int c = 0;
            ob.dr = ob.ret_dr("select isnull(max(pid),500)+1 from suspect");
            if (ob.dr.Read())
            {
                c = Convert.ToInt32(ob.dr[0].ToString());
            }
            return c.ToString();
        }
        public void insertdb()
        {

            int status = 0;
            int p = 0;
            string query = "insert into suspect values(" + textBox1.Text + ",'" + txtdes.Text + "','" + txtcateg.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox8.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'," + p + "," + status + ")";
            ob.exec1(query);
            MessageBox.Show("Details Added Successfully");

        }
        private void btbdesc_Click(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty)
            {
                MessageBox.Show("Please enter Name");
            }
            if (txtcateg.Text == string.Empty)
            {
                MessageBox.Show("Please enter Height");
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please enter Phone");
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter Age");
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please enter Date of Birth");
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please enter Identification Mark");
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Please enter Eye Type");
            }
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("Please enter Skin Type");
            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("Please enter Past History");
            }
            if (textBox9.Text == string.Empty)
            {
                MessageBox.Show("Please enter Hair Type");
            }
            if (textBox10.Text == string.Empty)
            {
                MessageBox.Show("Please enter Case Number");
            }
            if (textBox11.Text == string.Empty)
            {
                MessageBox.Show("Please enter Blood Type");
            }
            if (textBox12.Text == string.Empty)
            {
                MessageBox.Show("Please enter Case Details");
            }
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("Please browse Photo");
            }
            else
            {

               Program.suspectid = textBox1.Text;
           
                insertdb();
                int c = 0;
                S_1_LoadImages obj = new S_1_LoadImages(txtbrwse.Text);
                obj.Show();
            }

        
        }
        public string getbranchname()
        {
            int c = 0;
            ob.dr =ob.ret_dr("select branchname from branch");
            while (ob.dr.Read())
            {
                comboBox2.Items.Add(ob.dr[0].ToString());
            }
            return c.ToString();
        }
        private void AddCriminal_Load(object sender, EventArgs e)
        {
            textBox1.Text = getaccount();
            getbranchname();
        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;

            //}
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar >= '/')
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
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
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
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
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
            //if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= ' ')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar >= '/')
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

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
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
