namespace imageOperations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.buttonFaceEye = new System.Windows.Forms.Button();
            this.buttonFaceDetection = new System.Windows.Forms.Button();
            this.buttonEyeDetection = new System.Windows.Forms.Button();
            this.panelBorderColor = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.numericBorder = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericNeig = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericThreshold = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBitmap = new System.Windows.Forms.Button();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPersonNumber = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonBorderDetection = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.labelResolution);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Location = new System.Drawing.Point(12, 12);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1104, 539);
            this.leftPanel.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(73, 10);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(32, 13);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "0 X 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Çözünürlük :";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1100, 535);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxScale);
            this.panel2.Controls.Add(this.buttonFaceEye);
            this.panel2.Controls.Add(this.buttonFaceDetection);
            this.panel2.Controls.Add(this.buttonEyeDetection);
            this.panel2.Controls.Add(this.panelBorderColor);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.numericBorder);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numericNeig);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(395, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 194);
            this.panel2.TabIndex = 2;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(170, 42);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(67, 20);
            this.textBoxScale.TabIndex = 34;
            this.textBoxScale.Text = "1.1";
            this.textBoxScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxScale_KeyPress);
            // 
            // buttonFaceEye
            // 
            this.buttonFaceEye.Location = new System.Drawing.Point(255, 139);
            this.buttonFaceEye.Name = "buttonFaceEye";
            this.buttonFaceEye.Size = new System.Drawing.Size(200, 24);
            this.buttonFaceEye.TabIndex = 33;
            this.buttonFaceEye.Text = "Aynı Anda Algıla";
            this.buttonFaceEye.UseVisualStyleBackColor = true;
            this.buttonFaceEye.Click += new System.EventHandler(this.ButtonFaceEye_Click);
            // 
            // buttonFaceDetection
            // 
            this.buttonFaceDetection.Location = new System.Drawing.Point(255, 105);
            this.buttonFaceDetection.Name = "buttonFaceDetection";
            this.buttonFaceDetection.Size = new System.Drawing.Size(200, 24);
            this.buttonFaceDetection.TabIndex = 31;
            this.buttonFaceDetection.Text = "Yüzleri Algıla";
            this.buttonFaceDetection.UseVisualStyleBackColor = true;
            this.buttonFaceDetection.Click += new System.EventHandler(this.ButtonFaceDetection_Click);
            // 
            // buttonEyeDetection
            // 
            this.buttonEyeDetection.Location = new System.Drawing.Point(255, 68);
            this.buttonEyeDetection.Name = "buttonEyeDetection";
            this.buttonEyeDetection.Size = new System.Drawing.Size(200, 24);
            this.buttonEyeDetection.TabIndex = 32;
            this.buttonEyeDetection.Text = "Göz/Ağız Algıla";
            this.buttonEyeDetection.UseVisualStyleBackColor = true;
            this.buttonEyeDetection.Click += new System.EventHandler(this.ButtonEyeDetection_Click);
            // 
            // panelBorderColor
            // 
            this.panelBorderColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBorderColor.Location = new System.Drawing.Point(172, 143);
            this.panelBorderColor.Name = "panelBorderColor";
            this.panelBorderColor.Size = new System.Drawing.Size(65, 20);
            this.panelBorderColor.TabIndex = 30;
            this.panelBorderColor.Click += new System.EventHandler(this.PanelBorderColor_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(34, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Çerçeve Kalınlığı :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericBorder
            // 
            this.numericBorder.Location = new System.Drawing.Point(172, 109);
            this.numericBorder.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBorder.Name = "numericBorder";
            this.numericBorder.Size = new System.Drawing.Size(65, 20);
            this.numericBorder.TabIndex = 28;
            this.numericBorder.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(34, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Çerçeve Rengi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Scale Factor :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "min Neighbors :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericNeig
            // 
            this.numericNeig.Location = new System.Drawing.Point(172, 72);
            this.numericNeig.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericNeig.Name = "numericNeig";
            this.numericNeig.Size = new System.Drawing.Size(65, 20);
            this.numericNeig.TabIndex = 22;
            this.numericNeig.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(473, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Haar Cascade";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(18, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Threshold :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericThreshold
            // 
            this.numericThreshold.Location = new System.Drawing.Point(156, 155);
            this.numericThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericThreshold.Name = "numericThreshold";
            this.numericThreshold.Size = new System.Drawing.Size(65, 20);
            this.numericThreshold.TabIndex = 20;
            this.numericThreshold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(191, 125);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(169, 24);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Sıfırla";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonBitmap
            // 
            this.buttonBitmap.Location = new System.Drawing.Point(16, 125);
            this.buttonBitmap.Name = "buttonBitmap";
            this.buttonBitmap.Size = new System.Drawing.Size(169, 24);
            this.buttonBitmap.TabIndex = 12;
            this.buttonBitmap.Text = "Bitmap";
            this.buttonBitmap.UseVisualStyleBackColor = true;
            this.buttonBitmap.Click += new System.EventHandler(this.ButtonBitmap_Click);
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.Location = new System.Drawing.Point(16, 95);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(169, 24);
            this.buttonGrayScale.TabIndex = 11;
            this.buttonGrayScale.Text = "Gray Scale";
            this.buttonGrayScale.UseVisualStyleBackColor = true;
            this.buttonGrayScale.Click += new System.EventHandler(this.ButtonGrayScale_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelPersonNumber);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(884, 562);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 194);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bulunan Yüz Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPersonNumber
            // 
            this.labelPersonNumber.AutoSize = true;
            this.labelPersonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonNumber.Location = new System.Drawing.Point(98, 80);
            this.labelPersonNumber.Name = "labelPersonNumber";
            this.labelPersonNumber.Size = new System.Drawing.Size(36, 39);
            this.labelPersonNumber.TabIndex = 28;
            this.labelPersonNumber.Text = "0";
            this.labelPersonNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(222, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Bilgilendirme";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(14, 141);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(199, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Çıkış";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxFileName);
            this.panel4.Controls.Add(this.buttonUploadImage);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.buttonReset);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.numericThreshold);
            this.panel4.Controls.Add(this.buttonBitmap);
            this.panel4.Controls.Add(this.buttonBorderDetection);
            this.panel4.Controls.Add(this.buttonGrayScale);
            this.panel4.Location = new System.Drawing.Point(12, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 194);
            this.panel4.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(367, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Resim İşlemleri";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBorderDetection
            // 
            this.buttonBorderDetection.Location = new System.Drawing.Point(191, 95);
            this.buttonBorderDetection.Name = "buttonBorderDetection";
            this.buttonBorderDetection.Size = new System.Drawing.Size(169, 24);
            this.buttonBorderDetection.TabIndex = 22;
            this.buttonBorderDetection.Text = "Kenar Tespit";
            this.buttonBorderDetection.UseVisualStyleBackColor = true;
            this.buttonBorderDetection.Click += new System.EventHandler(this.ButtonBorderDetection_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Location = new System.Drawing.Point(1122, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 742);
            this.panel5.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 29);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(220, 706);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(220, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Bulunan Yüzler";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(111, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dosya Yolu :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(114, 55);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(246, 30);
            this.textBoxFileName.TabIndex = 25;
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(16, 37);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(78, 48);
            this.buttonUploadImage.TabIndex = 24;
            this.buttonUploadImage.Text = "Resim Yükle";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBitmap;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericThreshold;
        private System.Windows.Forms.Button buttonBorderDetection;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonEyeDetection;
        private System.Windows.Forms.Button buttonFaceDetection;
        private System.Windows.Forms.Panel panelBorderColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericBorder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericNeig;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPersonNumber;
        private System.Windows.Forms.Button buttonFaceEye;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonUploadImage;
    }
}

