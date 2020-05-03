using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace imageOperations
{
    public partial class Form1 : Form
    {
        Bitmap[] ExtFaces;
        int faceNo = 0;
        private Bitmap bmp = new Bitmap(800, 500);
        private Image<Bgr, byte> imgInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
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
                    labelPersonNumber.Text = "0";
                    listView1.Items.Clear();
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

        private void ButtonGrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                GrayImage();
                pictureBox.Image = bmp;
                this.Refresh();
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
            }
        }

        private void ButtonBitmap_Click(object sender, EventArgs e)
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
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                pictureBox.Image = bmp;
                this.Refresh();
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
            }
        }

        private void ButtonBorderDetection_Click(object sender, EventArgs e)
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
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
            }
        }

        public void GrayImage()
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

        private void ButtonFaceDetection_Click(object sender, EventArgs e)
        {
            try
            {
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }

                DetectFaceHaar();
                listView1.Items.Clear();
                Populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonEyeDetection_Click(object sender, EventArgs e)
        {
            try
            {
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }
                DetectEyeHaar();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonFaceEye_Click(object sender, EventArgs e)
        {
            try
            {
                labelPersonNumber.Text = "0";
                listView1.Items.Clear();
                imgInput = new Image<Bgr, byte>(textBoxFileName.Text);
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }
                DetectFaceEyeHaar();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DetectFaceHaar()
        {
            try
            {
                int personNumber = 0;
                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");

                CascadeClassifier classifierFace = new CascadeClassifier(facePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();//
                double scale = Convert.ToDouble(textBoxScale.Text);
                int neig = Convert.ToInt32(numericNeig.Value);
                int border = Convert.ToInt32(numericBorder.Value);
                double r, g, b;
                r = Convert.ToDouble(panelBorderColor.BackColor.R);
                g = Convert.ToDouble(panelBorderColor.BackColor.G);
                b = Convert.ToDouble(panelBorderColor.BackColor.B);

                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, scale, neig);
                if (faces.Length > 0)
                {
                    Bitmap bmpInput = imgGray.ToBitmap();
                    Bitmap ExtractedFace; // empty
                    Graphics FaceCanvas;
                    ExtFaces = new Bitmap[faces.Length];
                    faceNo = 0;
                    foreach (var face in faces)
                    {
                        personNumber += 1;
                        imgInput.Draw(face, new Bgr(b, g, r), border);
                        ExtractedFace = new Bitmap(face.Width, face.Height);
                        FaceCanvas = Graphics.FromImage(ExtractedFace);
                        FaceCanvas.DrawImage(bmpInput, 0, 0, face, GraphicsUnit.Pixel);
                        ExtFaces[faceNo] = ExtractedFace;
                        faceNo++;
                    }
                    pictureBox.Image = imgInput.Bitmap;
                }
                labelPersonNumber.Text = Convert.ToString(personNumber);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DetectEyeHaar()
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
                if (faces.Length > 0)
                {
                    Bitmap bmpInput = imgGray.ToBitmap();
                    Graphics FaceCanvas;
                    ExtFaces = new Bitmap[faces.Length];
                    Bitmap ExtractedFace; // empty
                    faceNo = 0;
                    foreach (var face in faces)
                    {
                        personNumber += 1;
                        ExtractedFace = new Bitmap(face.Width, face.Height);
                        FaceCanvas = Graphics.FromImage(ExtractedFace);
                        FaceCanvas.DrawImage(bmpInput, 0, 0, face, GraphicsUnit.Pixel);
                        ExtFaces[faceNo] = ExtractedFace;
                        faceNo++;

                        imgGray.ROI = face;
                        Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, scale, neig);
                        foreach (var eye in eyes)
                        {
                            var Eye = eye;
                            Eye.X += face.X;
                            Eye.Y += face.Y;
                            imgInput.Draw(Eye, new Bgr(0, 255, 0), border);
                        }
                    }
                    pictureBox.Image = imgInput.Bitmap;
                    labelPersonNumber.Text = Convert.ToString(personNumber);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DetectFaceEyeHaar()
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
                if (faces.Length > 0)
                {
                    Bitmap bmpInput = imgGray.ToBitmap();
                    Graphics FaceCanvas;
                    ExtFaces = new Bitmap[faces.Length];
                    Bitmap ExtractedFace; // empty
                    faceNo = 0;
                    foreach (var face in faces)
                    {
                        personNumber += 1;
                        imgInput.Draw(face, new Bgr(0, 0, 255), border);

                        ExtractedFace = new Bitmap(face.Width, face.Height);
                        FaceCanvas = Graphics.FromImage(ExtractedFace);
                        FaceCanvas.DrawImage(bmpInput, 0, 0, face, GraphicsUnit.Pixel);
                        ExtFaces[faceNo] = ExtractedFace;
                        faceNo++;

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
                    pictureBox.Image = imgInput.Bitmap;
                    labelPersonNumber.Text = Convert.ToString(personNumber);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void TextBoxScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void PanelBorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();
            Color.ShowDialog();
            panelBorderColor.BackColor = Color.Color;
        }

        private void Populate()
        {
            ImageList imgs = new ImageList
            {
                ImageSize = new Size(150, 150)
            };

            for (int i = 0; i < ExtFaces.Length; i++)
            {
                imgs.Images.Add(ExtFaces[i]);
                listView1.Items.Add("" + (i + 1) + " yüz", i);
            }
            listView1.SmallImageList = imgs;
        }
    }
}