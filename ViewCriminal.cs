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
    public partial class ViewCriminal : Form
    {
        connection ob = new connection();
        public static string imgid = "";
        public ViewCriminal()
        {
            InitializeComponent();
        }
        public ViewCriminal(string id)
        {
            InitializeComponent();
            imgid = id;
        }
        private void btbdesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCriminal_Load(object sender, EventArgs e)
        {
            string str = "select * from suspect where pid=" + imgid + " and pstatus=0";
            ob.dr = ob.ret_dr(str);
            if (ob.dr.Read())
            {

               
                textBox1.Text = ob.dr[0].ToString();
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
                textBox11.Text = ob.dr[14].ToString();
                textBox12.Text = ob.dr[15].ToString();
                textBox13.Text = ob.dr[6].ToString();
                textBox14.Text = ob.dr[7].ToString();
                

            }
        }
    }
}
