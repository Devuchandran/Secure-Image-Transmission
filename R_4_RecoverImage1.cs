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
    public partial class R_4_RecoverImage1 : Form
    {
        public R_4_RecoverImage1()
        {
            InitializeComponent();
            SetText();
            pictureBox1.ImageLocation = Program.recvfile;
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
        public static byte[] ImageToBinary(string _path)
        {
            FileStream fS = new FileStream(_path, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }

        private void bProcess_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Application.StartupPath + "\\ imgenc.png";
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
            pictureBox4.Image = Base64ToImage(Program.miximage1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_5_Final obj = new R_5_Final();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
