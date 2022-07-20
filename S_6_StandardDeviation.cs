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
    public partial class S_6_StandardDeviation : Form
    {
        public static string diffstring = "";
        public S_6_StandardDeviation()
        {
            InitializeComponent();
            pictureBox1.Image = Program.om;
            pictureBox2.Image = Program.tm;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap om = Program.om;
            Bitmap tm = Program.tm;

            int ow = om.Width;
            int oh = om.Height;

            int tw = tm.Width;
            int th = tm.Height;

            int w = 0, h = 0;

            if (ow < tw)
            {
                w = ow;
            }
            else
            {
                w = tw;
            }


            if (oh < th)
            {
                h = oh;
            }
            else
            {
                h = th;
            }
            int[,] diffs = new int[w, h];
            progressBar1.Maximum = w/2 + 1;
            progressBar1.Value = 0;
            for (int x = 0; x < w/2; x++)
            {
                for (int y = 0; y < h/2; y++)
                {
                    // Calculate the pixels' difference.
                    Color color1 = om.GetPixel(x, y);
                    Color color2 = tm.GetPixel(x, y);
                    diffs[x, y] = (int)(
                        Math.Abs(color1.R - color2.R) +
                        Math.Abs(color1.G - color2.G) +
                        Math.Abs(color1.B - color2.B));
                    listBox1.Items.Add(color1.ToString()+"-"+color2.ToString()+"[" + x.ToString() + "," + y.ToString() + "]-->R -" + Math.Abs(color1.R - color2.R).ToString() + ",G -" + Math.Abs(color1.G - color2.G).ToString() + ",B -" + Math.Abs(color1.B - color2.B).ToString());
                   // listBox1.Refresh();
                }
                progressBar1.Value++;
            }
            progressBar1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
            S_7_ImageRanking obj = new S_7_ImageRanking((Bitmap)pictureBox1.Image);
            ActiveForm.Hide();
            obj.Show();
        }


    }
}
