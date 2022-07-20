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
    public partial class R_5_Final : Form
    {
        connection con = new connection();
        public R_5_Final()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Program.recvfile;
            pictureBox2.Image = Base64ToImage(Program.miximage1);
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
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ViewCriminal obj = new ViewCriminal(Program.id1);
            obj.Show();
        }
    }
}
