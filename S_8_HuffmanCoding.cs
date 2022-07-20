using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
namespace SecureTransferMI
{
    public partial class S_8_HuffmanCoding : Form
    {
        public S_8_HuffmanCoding(Bitmap bmp)
        {
            InitializeComponent();
            pictureBox1.Image = (Bitmap)bmp;
        }

        private void bProcess_Click(object sender, EventArgs e)
        {
            SetText();
        }

        public  void SetText()
        {
            byte[] b = ImageToBinary(Program.OrginalFilePath);

            StringBuilder binary = new StringBuilder();

            foreach (var bb in b)
            {
                binary.Append(Convert.ToString(bb, 2));
            }

            richTextBox1.Text = binary.ToString();

        }
        public string imagetobase64(Image simage, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                simage.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static byte[] ImageToBinary(string _path)
        {
            FileStream fS = new FileStream(_path, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = imagetobase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png);
            //txt_hidden.Text = str;

            richTextBox2.Text = Crypto.EncryptStringAES(str, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.cipher = richTextBox2.Text;
            S_9_Embedding obj = new S_9_Embedding((Bitmap)pictureBox1.Image,richTextBox2.Text);
            ActiveForm.Hide();
            obj.Show();

        }
    }
}
