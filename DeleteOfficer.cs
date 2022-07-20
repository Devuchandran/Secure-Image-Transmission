using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SecureTransferMI
{
    public partial class DeleteOfficer : Form
    {

        connection ob = new connection();
        DataSet ds1 = new DataSet();
        public DeleteOfficer()
        {
            InitializeComponent();
        }

        private void txtcateg_TextChanged(object sender, EventArgs e)
        {

        }
        void fillgrid()
        {
            ds1.Tables.Clear();
            ds1 = ob.ds("select * from officer where ousername='" + txtbrwse.Text + "' and status=0");
            dataGridView1.DataSource = ds1.Tables[0].DefaultView;

        }

        private void btbbrwse_Click(object sender, EventArgs e)
        {
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("Please enter Officer Username");
            }
            else
            {
                ob.dr = ob.ret_dr("select * from officer where ousername='" + txtbrwse.Text + "' and status=0");
                if (ob.dr.Read())
                {

                    picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\" + ob.dr[0].ToString() + ".jpg");
                    fillgrid();
                }
                else
                {
                    MessageBox.Show("Username Not available");
                }
            }
            
            
        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
            ob.exec("update officer set status=1 where ousername='" + txtbrwse.Text + "'");

            ob.exec("update login set status=2 where uname='" + txtbrwse.Text + "'");
           // picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\default.jpg");
            fillgrid();
            MessageBox.Show("successfully Deleted");
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
