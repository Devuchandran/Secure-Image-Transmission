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
    public partial class S_9_Embedding : Form
    {
        connection ob = new connection();
        connection con = new connection();
        public S_9_Embedding(Bitmap secret,string cipher)
        {
            InitializeComponent();
            pictureBox1.Image = (Bitmap)secret;
            richTextBox2.Text = cipher;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Secret Image embedded into the target image......");
            pictureBox3.Image = Base64ToImage(Program.tarimage);
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

        private void button2_Click(object sender, EventArgs e)
        {
           // FileHandler fl=new FileHandler();
            using (StreamWriter writer = new StreamWriter(Application.StartupPath + "\\ enc.txt"))
            {

                writer.WriteLine(Program.cipher + "@#@#@#" + Program.omimage);


            }

            //string text=fl.embeddimage();
            Steganography obj=new Steganography();

            Bitmap finalbmp = obj.embedText(Program.cipher + "@#@#@#" + Program.omimage, (Bitmap)pictureBox3.Image);
            pictureBox3.Image = (Bitmap)finalbmp;
            MessageBox.Show("Cipher embedded into the image......");

        }
        public string getofficerusername()
        {
            int c = 0;
            ob.dr = ob.ret_dr("select ousername from officer");
            while (ob.dr.Read())
            {
                comboBox1.Items.Add(ob.dr[0].ToString());
            }
            return c.ToString();
        }
        public string getid()
        {
            int c = 0;
            con.dr = con.ret_dr("select isnull(max(mid),700)+1 from message");
            if (con.dr.Read())
            {
                c = Convert.ToInt32(con.dr[0].ToString());
            }
            return c.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string mid = "";
            textBox1.Text = Program.uname1;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {

                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox3.Image.Save(sfd.FileName, format);
              //  MessageBox.Show(sfd.FileName);
                mid = getid();
                int status = 0;
                string query = "insert into message values(" + mid + ",'" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + sfd.FileName + "',"+Program.suspectid+",'" + textBox2.Text + "'," + status + ")";
                con.exec1(query);
                MessageBox.Show("Details Sended Successfully");

            }




            
            


          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void S_9_Embedding_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.uname1;
            getofficerusername();
        }
    }
}
