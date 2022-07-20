using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;

namespace SecureTransferMI
{
    public partial class S_5_MosaicTarget : Form
    {
        public S_5_MosaicTarget()
        {
            InitializeComponent();
            pictureBox2.Image = (Bitmap)Bitmap.FromFile(Program.TargetFilePath);
            pictureBox3.Image = (Bitmap)Bitmap.FromFile(Program.TargetFilePath);
            pictureBox1.Image = (Bitmap)Program.om;
        }
        private Pixellate filter = new Pixellate(8);
        public IFilter Filter
        {
            get { return filter; }
        }
        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            widthBox.Text = widthTrackBar.Value.ToString();
            if (syncCheck.Checked)
            {
                heightTrackBar.Value = widthTrackBar.Value;
                heightBox.Text = widthBox.Text;
            }

            filter.PixelWidth = int.Parse(widthBox.Text);
            pictureBox3.Image = filter.Apply((Bitmap)Bitmap.FromFile(Program.TargetFilePath));
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            heightBox.Text = heightTrackBar.Value.ToString();
            if (syncCheck.Checked)
            {
                widthTrackBar.Value = heightTrackBar.Value;
                widthBox.Text = heightBox.Text;
            }
            filter.PixelHeight = int.Parse(heightBox.Text);
            pictureBox3.Image = filter.Apply((Bitmap)Bitmap.FromFile(Program.TargetFilePath));

        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.PixelHeight = int.Parse(heightBox.Text);
                
            }
            catch (Exception)
            {
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filter.Apply((Bitmap)Bitmap.FromFile(Program.TargetFilePath));

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)Bitmap.FromFile(Program.TargetFilePath);
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
        private void button3_Click(object sender, EventArgs e)
        {
            Program.tarimage = imagetobase64(pictureBox2.Image, ImageFormat.Png);
            Program.Targetmosaicvalue = widthBox.Text;
            Program.tm = (Bitmap)pictureBox2.Image;
            S_6_StandardDeviation obj = new S_6_StandardDeviation();
            ActiveForm.Hide();
            obj.Show();
        }





    }
}
