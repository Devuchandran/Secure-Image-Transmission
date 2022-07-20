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
    public partial class DeleteBranch : Form
    {
        public DeleteBranch()
        {
            InitializeComponent();
        }
        connection ob = new connection();
        DataSet ds1 = new DataSet();
        void fillgrid()
        {
            ds1.Tables.Clear();
            ds1 = ob.ds("select * from branch where status=0");
            dataGridView1.DataSource = ds1.Tables[0].DefaultView;

        }
        private void DeleteBranch_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("please enter Branch ID");
            }
            else
            {
                ob.exec("delete from branch where branchid='" + txtbrwse.Text + "'");
                MessageBox.Show("Delete Successfully");
                fillgrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbbrwse_Click(object sender, EventArgs e)
        {

        }
    }
}
