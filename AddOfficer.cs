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
    public partial class AddOfficer : Form
    {
        connection con = new connection();
        public AddOfficer()
        {
            InitializeComponent();
        }

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
            con.dr = con.ret_dr("select isnull(max(officerid),200)+1 from officer");
            if (con.dr.Read())
            {
                c = Convert.ToInt32(con.dr[0].ToString());
            }
            return c.ToString();
        }
        public string getbranchname()
        {
            int c = 0;
            con.dr = con.ret_dr("select branchname from branch");
            while (con.dr.Read())
            {
                comboBox2.Items.Add(con.dr[0].ToString());
            }
            return c.ToString();
        }
        public void insertdb(String p)
        {

            int status = 0;
            string query = "insert into officer values(" + textBox1.Text + ",'" + txtdes.Text + "','" + txtcateg.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + textBox8.Text + "','" + p + "'," + status + ")";
            con.exec1(query);
            MessageBox.Show("Details Added Successfully");

        }
        public void insertlogin()
        {

            int status = 1;
            string query = "insert into login values('" + txtcateg.Text + "','" + textBox5.Text + "','" + status.ToString() + "')";
            con.exec1(query);
           // MessageBox.Show("Details Added Successfully");

        }
        private void btbdesc_Click(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty)
            {
                MessageBox.Show("Please enter Name");
            }
            if (txtcateg.Text == string.Empty)
            {
                MessageBox.Show("Please enter Username");
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please enter Password");
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
                MessageBox.Show("Please enter Phone Number");
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Please enter Email ID");
            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("Please enter Address");
            }
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("Please browse Photo");
            }
            else
            {

                string paths = Application.StartupPath + "\\Account";

                System.IO.Directory.CreateDirectory(paths);
                string path1 = paths + "\\" + textBox1.Text + ".jpg";
                picbxadd.Image.Save(path1);
                string p = textBox1.Text + ".jpg";

                insertdb(p);
                insertlogin();
                textBox1.Text = "";
                txtdes.Text = "";
                txtcateg.Text = "";
                textBox5.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                txtbrwse.Text = "";
                this.Close();
            }


        }

        private void AddOfficer_Load(object sender, EventArgs e)
        {
            textBox1.Text = getaccount();
            getbranchname();


        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0') && (e.KeyChar <= '9'))
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
