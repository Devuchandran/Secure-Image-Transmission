using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SecureTransferMI
{
    public partial class DeleteCriminal : Form
    {
        public DeleteCriminal()
        {
            InitializeComponent();
        }
        connection ob = new connection();
        DataSet ds1 = new DataSet();
        public static string imgid = "";
        private void btbbrwse_Click(object sender, EventArgs e)
        {
            if (txtbrwse.Text == string.Empty)
            {
                MessageBox.Show("Please enter Suspect ID");
            }
            else
            {
                ob.dr = ob.ret_dr("select * from suspect where pid='" + txtbrwse.Text + "' and pstatus=0");
                if (ob.dr.Read())
                {
                    imgid = ob.dr[16].ToString();
                    //   picbxadd.Image = Image.FromFile(Application.StartupPath + "\\ImagePool\\" + ob.dr[16].ToString() + ".jpg");
                    fillgrid();
                }
                else
                {
                    MessageBox.Show("Username Not available");
                }
            }
        }
        void fillgrid()
        {
            ds1.Tables.Clear();
            ds1 = ob.ds("select * from suspect where pid='" + txtbrwse.Text + "' and pstatus=0");
            dataGridView1.DataSource = ds1.Tables[0].DefaultView;

        }

        private void btbdesc_Click(object sender, EventArgs e)
        {
            try
            {
                ob.exec("delete from suspect where pid='" + txtbrwse.Text + "'");
                //ob.exec("delete from category where imageid=" + imgid + "");
                //ob.exec("delete from imgtb where imageid=" + imgid + "");
                //ob.exec("delete from linetb where imageid=" + imgid + "");
                //ob.exec("delete from circletb where imageid=" + imgid + "");
                //ob.exec("delete from triangletb where imageid=" + imgid + "");
                //ob.exec("delete from rectangletb where imageid=" + imgid + "");

               // picbxadd.Image = Image.FromFile(Application.StartupPath + "\\Account\\default.jpg");
               // string path2 = Application.StartupPath + "\\ImagePool\\" + imgid + ".jpg";
                //if (File.Exists(path2))
                //{
                //    File.Delete(path2);
                //}

                fillgrid();
                MessageBox.Show("successfully Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failure");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
