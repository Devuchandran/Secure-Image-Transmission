using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace SecureTransferMI
{
    public partial class R_1_LoadImage : Form
    {
        connection ob = new connection();
        connection con = new connection();
        public R_1_LoadImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
           
            //DialogResult result = openFileDialog1.ShowDialog();
            //if (result == DialogResult.OK) // Test result.
            //{
               // textBox1.Text = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
                Program.recvfile = textBox1.Text;

                
            //}
        }
         //Steganography obj = new Steganography();
         //   string final = obj.extractText((Bitmap)pictureBox1.Image);

           

         //   FileHandler fil = new FileHandler();
         //   fil.revoke(final);
        private void button2_Click(object sender, EventArgs e)
        {
           
            //pictureBox2.Image = Base64ToImage(Program.miximage1);
            //pictureBox3.Image = Base64ToImage(Crypto.DecryptStringAES(Program.cipher1, textBox2.Text));
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.exec("update message set status=1 where mid="+ comboBox1.SelectedItem.ToString() + "");
            R_2_ExtractFromImage obj = new R_2_ExtractFromImage();
            ActiveForm.Hide();
            obj.Show();
        }

        private void R_1_LoadImage_Load(object sender, EventArgs e)
        {

            ob.dr = ob.ret_dr("select mid from message where rofficerid='"+Program.uname1+"' and status=0");
            while (ob.dr.Read())
            {
                comboBox1.Items.Add(ob.dr[0].ToString());
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ob.dr = ob.ret_dr("select * from message where mid='" + comboBox1.SelectedItem.ToString() + "'");
            if(ob.dr.Read())
            {
                textBox2.Text = ob.dr[5].ToString();
                textBox1.Text = ob.dr[3].ToString();
                Program.id1 = ob.dr[4].ToString();

             
            }
        }


    }
}
