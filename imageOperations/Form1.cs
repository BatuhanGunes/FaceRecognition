using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;



namespace imageOperations
{
    public partial class Form1 : Form
    {

        Bitmap bmp = new Bitmap(800, 500);
        Image<Bgr, byte> imgInput;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.ImageLocation = dialog.FileName;
                    bmp = (Bitmap)Bitmap.FromFile(dialog.FileName);
                    textBoxFileName.Text = dialog.FileName;
                    labelResolution.Text = pictureBox.Width.ToString() + " X " + pictureBox.Height.ToString();
                    this.Refresh();
                }
                else
                {
                    throw new Exception("Dosya Seçilmedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                grayImage();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                int threshold = Convert.ToInt32(numericThreshold.Text);
                

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;

                        if (avg >= threshold)
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
                pictureBox.Image = bmp;
                this.Refresh();
            }       
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }
        
        private void buttonBorderDetection_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {

                int threshold = Convert.ToInt32(numericThreshold.Text);
                int[,] IpikselXY = new int[bmp.Width, bmp.Height];
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);

                // Gray Scale
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;
                        IpikselXY[x, y] = avg;
                    }
                }

                //Object Detection
                for (int y = 1; y < bmp.Height - 1; y++)
                {
                    for (int x = 1; x < bmp.Width - 1; x++)
                    {

                        int IpikselX = (IpikselXY[(x + 1), y] - IpikselXY[(x - 1), y]) / 2;
                        int IpikselY = (IpikselXY[x, (y + 1)] - IpikselXY[x, (y - 1)]) / 2;
                        int IpikselGradient = Convert.ToInt32(Math.Sqrt(Math.Pow(IpikselX, 2) + Math.Pow(IpikselY, 2)));

                        if (IpikselGradient >= threshold)
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                }

                pictureBox.Image = bmp;
                this.Refresh();
            }
        }


        public void grayImage()
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
        }

        private void buttonFaceDetection_Click(object sender, EventArgs e)
        {
            try
            {
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }

                detectFaceHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEyeDetection_Click(object sender, EventArgs e)
        {
            try
            {
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }

                detectEyeHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFaceEye_Click(object sender, EventArgs e)
        {
            try
            {
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }

                detectFaceEyeHaar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void detectFaceHaar()
        {

            try
            {
                int personNumber = 0;
                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");

                CascadeClassifier classifierFace = new CascadeClassifier(facePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                double scale = Convert.ToDouble(textBoxScale.Text);
                int neig = Convert.ToInt32(numericNeig.Value);
                int border = Convert.ToInt32(numericBorder.Value);
                double r, g, b;
                r = Convert.ToDouble(panelBorderColor.BackColor.R);
                g = Convert.ToDouble(panelBorderColor.BackColor.G);
                b = Convert.ToDouble(panelBorderColor.BackColor.B);

                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, scale, neig);
                foreach (var face in faces)
                {
                    personNumber += 1;
                    imgInput.Draw(face, new Bgr(b, g, r), border);
                }
                pictureBox.Image = imgInput.Bitmap;
                labelPersonNumber.Text = Convert.ToString(personNumber);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void detectEyeHaar()
        {
            try
            {
                int personNumber = 0;
                string eyePath = Path.GetFullPath(@"../../data/haarcascade_eye.xml");
                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");

                CascadeClassifier classifierEye = new CascadeClassifier(eyePath);
                CascadeClassifier classifierFace = new CascadeClassifier(facePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                double scale = Convert.ToDouble(textBoxScale.Text);
                int neig = Convert.ToInt32(numericNeig.Value);
                int border = Convert.ToInt32(numericBorder.Value);
                double r, g, b;
                r = Convert.ToDouble(panelBorderColor.BackColor.R);
                g = Convert.ToDouble(panelBorderColor.BackColor.G);
                b = Convert.ToDouble(panelBorderColor.BackColor.B);

                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, scale, neig);
                foreach (var face in faces)
                {
                    
                    personNumber += 1;
                    imgGray.ROI = face;
                    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, scale, neig);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        imgInput.Draw(e, new Bgr(b, g, r), border);
                    }
                }
                labelPersonNumber.Text = Convert.ToString(personNumber);
                pictureBox.Image = imgInput.Bitmap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void detectFaceEyeHaar()
        {
            try
            {
                int personNumber = 0;
                string eyePath = Path.GetFullPath(@"../../data/haarcascade_eye.xml");
                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");

                CascadeClassifier classifierEye = new CascadeClassifier(eyePath);
                CascadeClassifier classifierFace = new CascadeClassifier(facePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                double scale = Convert.ToDouble(textBoxScale.Text);
                int neig = Convert.ToInt32(numericNeig.Value);
                int border = Convert.ToInt32(numericBorder.Value);
                double r, g, b;
                r = Convert.ToDouble(panelBorderColor.BackColor.R);
                g = Convert.ToDouble(panelBorderColor.BackColor.G);
                b = Convert.ToDouble(panelBorderColor.BackColor.B);

                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, scale, neig);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), border);
                    personNumber += 1;
                    imgGray.ROI = face;
                    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, scale, neig);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        imgInput.Draw(e, new Bgr(0, 255, 0), border);
                    }
                }
                labelPersonNumber.Text = Convert.ToString(personNumber);
                pictureBox.Image = imgInput.Bitmap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void textBoxScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void panelBorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();
            Color.ShowDialog();
            panelBorderColor.BackColor = Color.Color;
        }
    }
}
    //  Batuhan Güneş  
    //  201513171055

    //  Muhammed Emin Berkay Kocaoğlu
    //  201513171070

    //  Tutku Argun
    //  201513171010