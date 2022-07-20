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
    public partial class ViewProfileOfficer : Form
    {
        connection ob = new connection();
        public static string uname = "";
        public ViewProfileOfficer()
        {
            InitializeComponent();
        }
        public ViewProfileOfficer(string uid)
        {
            InitializeComponent();
            uname = uid;
        }
        private void ViewProfileOfficer_Load(object sender, EventArgs e)
        {
            ob.dr = ob.ret_dr("select * from officer where ousername='" + Program.uname1+ "' and status=0");
            if (ob.dr.Read())
            {
                txtbrwse.Text = Program.uname1.ToString();
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

        private void btbdesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
