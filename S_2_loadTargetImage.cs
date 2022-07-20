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
    public partial class S_2_loadTargetImage : Form
    {
        public S_2_loadTargetImage()
        {
            InitializeComponent();
        }

        public S_2_loadTargetImage(string dimension)
        {
            InitializeComponent();
            pictureBox2.Image = (Bitmap)Bitmap.FromFile(Program.OrginalFilePath);
            label12.Text = dimension;
        }
        ImageHandler imageHandler = new ImageHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
                Program.TargetFilePath = textBox1.Text;
                imageHandler.CurrentBitmap = (Bitmap)Bitmap.FromFile(Program.TargetFilePath);
                imageHandler.BitmapPath = Program.TargetFilePath;
                imageinfo(imageHandler);
            }
        }

        //..................................image details................................................................

        public void imageinfo(ImageHandler h)
        {
            FileInfo fileInfo = new FileInfo(h.BitmapPath);
            lblImageName.Text = fileInfo.Name.Replace(fileInfo.Extension, "");
            lblImageExtension.Text = fileInfo.Extension;
            string loc = fileInfo.DirectoryName;
            if (loc.Length > 50)
                loc = loc.Substring(0, 15) + "..." + loc.Substring(loc.LastIndexOf("\\"));
            lblImageLocation.Text = loc;
            lblImageDimension.Text = imageHandler.CurrentBitmap.Width + " x " + imageHandler.CurrentBitmap.Height;
            lblImageSize.Text = (fileInfo.Length / 1024.0).ToString("0.0") + " KB";
            lblImageCreatedOn.Text = fileInfo.CreationTime.ToString("dddd MMMM dd, yyyy");
            //long[] myValues = GetHistogram((Bitmap)Bitmap.FromFile(Program.orgfilepath));
            //histogramaDesenat1.DrawHistogram(myValues);
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
        private void button2_Click(object sender, EventArgs e)
        {
            Program.tarimage = imagetobase64(pictureBox1.Image, ImageFormat.Png);
            S_3_BlockDivision obj = new S_3_BlockDivision();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
