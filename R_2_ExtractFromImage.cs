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
    public partial class R_2_ExtractFromImage : Form
    {
        public R_2_ExtractFromImage()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Program.recvfile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Steganography obj = new Steganography();
            string final = obj.extractText((Bitmap)pictureBox1.Image);



            FileHandler fil = new FileHandler();
            fil.revoke(final);
            richTextBox1.Text = Program.cipher1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_3_Decryption obj = new R_3_Decryption();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
