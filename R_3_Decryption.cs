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
    public partial class R_3_Decryption : Form
    {
        public R_3_Decryption()
        {
            InitializeComponent();
            richTextBox1.Text = Program.cipher1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Base64ToImage(Crypto.DecryptStringAES(Program.cipher1, textBox1.Text));
                img.Save(Application.StartupPath + "\\ imgenc.png", ImageFormat.Png);
                SetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" decryption Failed...");
            }
        }
        public void SetText()
        {
            byte[] b = ImageToBinary(Application.StartupPath + "\\ imgenc.png");

            StringBuilder binary = new StringBuilder();

            foreach (var bb in b)
            {
                binary.Append(Convert.ToString(bb, 2));
            }

            richTextBox2.Text = binary.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            R_4_RecoverImage1 obj = new R_4_RecoverImage1();
            ActiveForm.Hide();
            obj.Show();
        }
       
    }
}
