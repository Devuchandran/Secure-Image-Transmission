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
    public partial class S_3_BlockDivision : Form
    {
        public S_3_BlockDivision()
        {
            InitializeComponent();
            pictureBox1.Image = (Bitmap)Bitmap.FromFile(Program.OrginalFilePath);
            pictureBox2.Image = (Bitmap)Bitmap.FromFile(Program.TargetFilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
             int cellSize = 10;
             int px = pictureBox1.Width;
             int v = pictureBox1.Height;
             int numOfCells = 5000;
           
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

        
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox2.Image);
            int cellSize = 10;
            int px = pictureBox2.Width;
            int v = pictureBox2.Height;
            int numOfCells = 5000;

            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_4_Mosaic obj = new S_4_Mosaic();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
