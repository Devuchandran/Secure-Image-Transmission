﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SecureTransferMI
{
    public partial class S_7_ImageRanking : Form {
        // This flag is used to stop auto-processing while [Randomize] button is being pressed.
        bool isRandomizing;
        Bitmap originalImage;
        readonly OpenFileDialog dOpenFile = new OpenFileDialog();
        readonly SaveFileDialog dSaveFile = new SaveFileDialog();
        readonly BackgroundWorker worker;


        public S_7_ImageRanking(Bitmap bmp) {
            InitializeComponent();
            SetProgressVisible(false);
            pictureBox1.Image = (Bitmap)bmp;
            SetOptionsEnabled(false);
            cAlgorithm.SelectedIndex = (int)SortAlgorithm.WholeImage;
            cOrder.SelectedIndex = (int)SortOrder.Descending;
            cMetric.SelectedIndex = (int)SortMetric.Intensity;
            cSampling.SelectedIndex = (int)SamplingMode.Mean;
            lImageSize.Text = "";

            dOpenFile.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|All Files|*.*";
            dSaveFile.Filter =
                "PNG Image|*.png|BMP Image|*.bmp|JPEG Image|*.jpg;*.jpeg|TIFF Image|*.tif;*.tiff|All Files|*.*";

           
           TryLoadFile(Program.OrginalFilePath);
            

            cOrder.SelectedIndexChanged += ProcessIfNotRandomizing;
            cSampling.SelectedIndexChanged += ProcessIfNotRandomizing;
            cMetric.SelectedIndexChanged += ProcessIfNotRandomizing;
            cAlgorithm.SelectedIndexChanged += ProcessIfNotRandomizing;
            nSegmentHeight.ValueChanged += ProcessIfNotRandomizing;
            nSegmentWidth.ValueChanged += ProcessIfNotRandomizing;
            tbThreshold.ValueChanged += ProcessIfNotRandomizing;

            worker = new BackgroundWorker {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            worker.DoWork += WorkerOnDoWork;
            worker.ProgressChanged += WorkerOnProgressChanged;
            worker.RunWorkerCompleted += WorkerOnRunWorkerCompleted;
        }


        Image currentTaskImage;
        SortingTask currentTask;

        bool runAfterCancel = false;


        void WorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                currentTask.OriginalImage.Dispose();
                if (currentTaskImage != null)
                {
                    currentTaskImage.Dispose();
                }
            }
            else if (!runAfterCancel)
            {
                Image oldImage = pictureBox.Image;
                pictureBox.Image = currentTaskImage;

                // Free resources used by the previous rendering
                if (oldImage != null && oldImage != originalImage)
                {
                    oldImage.Dispose();
                }

                // We're done! Unlock the interface.
                SetProgressVisible(false);
            }
            currentTaskImage = null;
            currentTask = null;
            if (runAfterCancel)
            {
                runAfterCancel = false;
                bProcess.PerformClick();
            }
        }


        void WorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.Value = e.ProgressPercentage;
            if (e.UserState != null)
            {
                //lProgress.Text = e.UserState.ToString();
            }
        }


        void WorkerOnDoWork(object sender, DoWorkEventArgs e)
        {
            worker.ReportProgress(10, "Sorting...");
            currentTask.Start();
            worker.ReportProgress(50, "Rendering...");
            currentTaskImage = currentTask.MakeResult();
        }


        void PixelSorter_Shown(object sender, EventArgs e)
        {
            bOpenFile.PerformClick();
        }


        void SetProgressVisible(bool val)
        {
            pbProgress.Visible = val;
            //lProgress.Visible = val;
        }


        void SetOptionsEnabled(bool val)
        {
            nSegmentWidth.Enabled = val;
            nSegmentHeight.Enabled = val;
            cAlgorithm.Enabled = val;
            cOrder.Enabled = val;
            cMetric.Enabled = val;
            cSampling.Enabled = val;
            bProcess.Enabled = val;
            bSave.Enabled = val;
            bRevert.Enabled = val;
            lImageSize.Visible = val;
           // bRandomize.Enabled = val;
        }


        void SetImage(Bitmap img)
        {
            if (originalImage != null && originalImage != img)
            {
                originalImage.Dispose();
            }
            originalImage = img;
            SetOptionsEnabled(img != null);
            pictureBox.Image = img;
            if (img != null)
            {
                lImageSize.Text = String.Format("{0} x {1}", img.Width, img.Height);
                nSegmentHeight.Maximum = img.Height;
                nSegmentWidth.Maximum = img.Width;
            }
        }


        void bOpenFile_Click(object sender, EventArgs e)
        {
            if (dOpenFile.ShowDialog() == DialogResult.OK)
            {
                TryLoadFile(dOpenFile.FileName);
            }
        }


        void TryLoadFile(string fileName)
        {
            try
            {
                SetImage(new Bitmap(Image.FromFile(fileName)));
                tImageFile.Text = fileName;

                // scroll caret to the right
                tImageFile.SelectionStart = tImageFile.Text.ToCharArray().Length;
                tImageFile.SelectionLength = 0;
            }
            catch (Exception ex)
            {
                SetImage(null);
                tImageFile.Text = "";
                MessageBox.Show(ex.ToString(),
                                "Error loading image",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        void bSave_Click(object sender, EventArgs e)
        {
            if (dSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image.Save(dSaveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),
                                    "Error saving image",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


        void bRevert_Click(object sender, EventArgs e)
        {
            SetImage(originalImage);
        }


        void bProcess_Click(object sender, EventArgs e)
        {
            // cancel whatever task is in progress
            if (currentTask != null)
            {
                runAfterCancel = true;
                worker.CancelAsync();
                currentTask.CancelAsync();
                return;
            }

            SortAlgorithm algo = (SortAlgorithm)cAlgorithm.SelectedIndex;
            SortOrder order = (SortOrder)cOrder.SelectedIndex;
            SortMetric metric = (SortMetric)cMetric.SelectedIndex;
            SamplingMode sampling = (SamplingMode)cSampling.SelectedIndex;
            int segmentWidth = (int)nSegmentWidth.Value;
            int segmentHeight = (int)nSegmentHeight.Value;
            double threshold = tbThreshold.Value / 100d;

            pbProgress.Value = 0;
            SetProgressVisible(true);

            currentTask = new SortingTask(algo,
                                          order,
                                          metric,
                                          sampling,
                                          segmentWidth,
                                          segmentHeight,
                                          (Bitmap)originalImage.Clone(),
                                          threshold);
            currentTask.ProgressChanged += (o, args) => worker.ReportProgress(args.ProgressPercentage);

            worker.RunWorkerAsync();
        }


        void bRandomize_Click(object sender, EventArgs e)
        {
            isRandomizing = true;
            Random rand = new Random();
            while (true)
            {
                cAlgorithm.SelectedIndex = rand.Next(cAlgorithm.Items.Count);
                cOrder.SelectedIndex = rand.Next(cOrder.Items.Count);
                cMetric.SelectedIndex = rand.Next(cMetric.Items.Count);
                cSampling.SelectedIndex = rand.Next(cSampling.Items.Count);
                nSegmentHeight.Value = GetRandomSegmentSize(rand, originalImage.Height);
                nSegmentWidth.Value = GetRandomSegmentSize(rand, originalImage.Width);
                tbThreshold.Value = rand.Next(tbThreshold.Minimum, tbThreshold.Maximum + 1);

                // make sure no inconsistent settings are ever produced
                bool isRowOrColumn = ((SortAlgorithm)cAlgorithm.SelectedIndex == SortAlgorithm.Row) ||
                                     ((SortAlgorithm)cAlgorithm.SelectedIndex == SortAlgorithm.Column);
                bool isThresholded = ((SortOrder)cOrder.SelectedIndex == SortOrder.AscendingThresholded) ||
                                     ((SortOrder)cOrder.SelectedIndex == SortOrder.DescendingThresholded);
                bool isOneSegment = (nSegmentHeight.Value == originalImage.Height) &&
                                    (nSegmentWidth.Value == originalImage.Width);
                if (!isOneSegment && (!isThresholded || isRowOrColumn))
                {
                    break;
                }
            }
            isRandomizing = false;
            bProcess.PerformClick();
        }


        int GetRandomSegmentSize(Random rand, int max)
        {
            int medianSegmentSize = (int)Math.Sqrt(max);
            int segHeight = rand.Next(1, medianSegmentSize);
            if (rand.NextDouble() > .5)
            {
                segHeight = max / segHeight;
            }
            return segHeight;
        }


        void ProcessIfNotRandomizing(object sender, EventArgs e)
        {
            bool isSegment = ((SortAlgorithm)cAlgorithm.SelectedIndex == SortAlgorithm.Segment);
            bool isRandom = ((SortOrder)cOrder.SelectedIndex == SortOrder.Random);
            bool is1X1 = (nSegmentHeight.Value == 1) && (nSegmentWidth.Value == 1);
            bool isRowOrColumn = ((SortAlgorithm)cAlgorithm.SelectedIndex == SortAlgorithm.Row) ||
                                 ((SortAlgorithm)cAlgorithm.SelectedIndex == SortAlgorithm.Column);
            bool isThresholded = isRowOrColumn &&
                                 ((SortOrder)cOrder.SelectedIndex == SortOrder.AscendingThresholded) ||
                                 ((SortOrder)cOrder.SelectedIndex == SortOrder.DescendingThresholded);

            cMetric.Enabled = !isRandom;
            cSampling.Enabled = !(is1X1 || isSegment || isRandom);
            tbThreshold.Enabled = isThresholded;
            label1.Enabled = isThresholded;

            if (!isRandomizing)
                bProcess.PerformClick();
        }

        private void cAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
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
            Program.miximage = imagetobase64(pictureBox.Image, ImageFormat.Png);
            S_8_HuffmanCoding obj = new S_8_HuffmanCoding((Bitmap)pictureBox.Image);
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
