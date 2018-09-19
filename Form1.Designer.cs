namespace INFOIBV
{
    partial class INFOIBV
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
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrix1 = new System.Windows.Forms.TextBox();
            this.matrix6 = new System.Windows.Forms.TextBox();
            this.matrix2 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.matrix8 = new System.Windows.Forms.TextBox();
            this.matrix7 = new System.Windows.Forms.TextBox();
            this.matrix3 = new System.Windows.Forms.TextBox();
            this.matrix4 = new System.Windows.Forms.TextBox();
            this.matrix18 = new System.Windows.Forms.TextBox();
            this.matrix17 = new System.Windows.Forms.TextBox();
            this.matrix16 = new System.Windows.Forms.TextBox();
            this.matrix23 = new System.Windows.Forms.TextBox();
            this.matrix22 = new System.Windows.Forms.TextBox();
            this.matrix21 = new System.Windows.Forms.TextBox();
            this.matrix19 = new System.Windows.Forms.TextBox();
            this.matrix14 = new System.Windows.Forms.TextBox();
            this.matrix9 = new System.Windows.Forms.TextBox();
            this.matrix20 = new System.Windows.Forms.TextBox();
            this.matrix15 = new System.Windows.Forms.TextBox();
            this.matrix10 = new System.Windows.Forms.TextBox();
            this.matrix5 = new System.Windows.Forms.TextBox();
            this.matrix24 = new System.Windows.Forms.TextBox();
            this.matrix25 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(16, 15);
            this.LoadImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(131, 28);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load image...";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Bitmap files (*.bmp;*.gif;*.jpg;*.png;*.tiff;*.jpeg)|*.bmp;*.gif;*.jpg;*.png;*.ti" +
    "ff;*.jpeg";
            this.openImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // imageFileName
            // 
            this.imageFileName.Location = new System.Drawing.Point(155, 17);
            this.imageFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageFileName.Name = "imageFileName";
            this.imageFileName.ReadOnly = true;
            this.imageFileName.Size = new System.Drawing.Size(368, 22);
            this.imageFileName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(856, 15);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(137, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Bitmap file (*.bmp)|*.bmp";
            this.saveImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1264, 14);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save as BMP...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(708, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(683, 630);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1001, 17);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(255, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "negative",
            "grayscale",
            "contrastadjustment",
            "gaussian",
            "threshold",
            "linear",
            "median",
            "edge detection"});
            this.comboBox1.Location = new System.Drawing.Point(688, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(581, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 31);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sigma:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kernel:";
            this.label2.Visible = false;
            // 
            // matrix1
            // 
            this.matrix1.Location = new System.Drawing.Point(1475, 151);
            this.matrix1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(29, 22);
            this.matrix1.TabIndex = 14;
            this.matrix1.Text = "0";
            // 
            // matrix6
            // 
            this.matrix6.Location = new System.Drawing.Point(1475, 183);
            this.matrix6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix6.Name = "matrix6";
            this.matrix6.Size = new System.Drawing.Size(29, 22);
            this.matrix6.TabIndex = 15;
            this.matrix6.Text = "0";
            // 
            // matrix2
            // 
            this.matrix2.Location = new System.Drawing.Point(1513, 151);
            this.matrix2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(29, 22);
            this.matrix2.TabIndex = 16;
            this.matrix2.Text = "0";
            // 
            // matrix13
            // 
            this.matrix13.Location = new System.Drawing.Point(1552, 215);
            this.matrix13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix13.Name = "matrix13";
            this.matrix13.Size = new System.Drawing.Size(29, 22);
            this.matrix13.TabIndex = 19;
            this.matrix13.Text = "0";
            // 
            // matrix12
            // 
            this.matrix12.Location = new System.Drawing.Point(1513, 215);
            this.matrix12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix12.Name = "matrix12";
            this.matrix12.Size = new System.Drawing.Size(29, 22);
            this.matrix12.TabIndex = 20;
            this.matrix12.Text = "0";
            // 
            // matrix11
            // 
            this.matrix11.Location = new System.Drawing.Point(1475, 215);
            this.matrix11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix11.Name = "matrix11";
            this.matrix11.Size = new System.Drawing.Size(29, 22);
            this.matrix11.TabIndex = 21;
            this.matrix11.Text = "0";
            // 
            // matrix8
            // 
            this.matrix8.Location = new System.Drawing.Point(1552, 183);
            this.matrix8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix8.Name = "matrix8";
            this.matrix8.Size = new System.Drawing.Size(29, 22);
            this.matrix8.TabIndex = 22;
            this.matrix8.Text = "0";
            // 
            // matrix7
            // 
            this.matrix7.Location = new System.Drawing.Point(1513, 183);
            this.matrix7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix7.Name = "matrix7";
            this.matrix7.Size = new System.Drawing.Size(29, 22);
            this.matrix7.TabIndex = 23;
            this.matrix7.Text = "0";
            // 
            // matrix3
            // 
            this.matrix3.Location = new System.Drawing.Point(1552, 151);
            this.matrix3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(29, 22);
            this.matrix3.TabIndex = 24;
            this.matrix3.Text = "0";
            // 
            // matrix4
            // 
            this.matrix4.Location = new System.Drawing.Point(1591, 151);
            this.matrix4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(29, 22);
            this.matrix4.TabIndex = 25;
            this.matrix4.Text = "0";
            // 
            // matrix18
            // 
            this.matrix18.Location = new System.Drawing.Point(1552, 247);
            this.matrix18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix18.Name = "matrix18";
            this.matrix18.Size = new System.Drawing.Size(29, 22);
            this.matrix18.TabIndex = 26;
            this.matrix18.Text = "0";
            // 
            // matrix17
            // 
            this.matrix17.Location = new System.Drawing.Point(1513, 247);
            this.matrix17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix17.Name = "matrix17";
            this.matrix17.Size = new System.Drawing.Size(29, 22);
            this.matrix17.TabIndex = 27;
            this.matrix17.Text = "0";
            // 
            // matrix16
            // 
            this.matrix16.Location = new System.Drawing.Point(1475, 247);
            this.matrix16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix16.Name = "matrix16";
            this.matrix16.Size = new System.Drawing.Size(29, 22);
            this.matrix16.TabIndex = 28;
            this.matrix16.Text = "0";
            // 
            // matrix23
            // 
            this.matrix23.Location = new System.Drawing.Point(1552, 279);
            this.matrix23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix23.Name = "matrix23";
            this.matrix23.Size = new System.Drawing.Size(29, 22);
            this.matrix23.TabIndex = 29;
            this.matrix23.Text = "0";
            // 
            // matrix22
            // 
            this.matrix22.Location = new System.Drawing.Point(1513, 279);
            this.matrix22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix22.Name = "matrix22";
            this.matrix22.Size = new System.Drawing.Size(29, 22);
            this.matrix22.TabIndex = 30;
            this.matrix22.Text = "0";
            // 
            // matrix21
            // 
            this.matrix21.Location = new System.Drawing.Point(1475, 279);
            this.matrix21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix21.Name = "matrix21";
            this.matrix21.Size = new System.Drawing.Size(29, 22);
            this.matrix21.TabIndex = 31;
            this.matrix21.Text = "0";
            // 
            // matrix19
            // 
            this.matrix19.Location = new System.Drawing.Point(1591, 247);
            this.matrix19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix19.Name = "matrix19";
            this.matrix19.Size = new System.Drawing.Size(29, 22);
            this.matrix19.TabIndex = 32;
            this.matrix19.Text = "0";
            // 
            // matrix14
            // 
            this.matrix14.Location = new System.Drawing.Point(1591, 215);
            this.matrix14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix14.Name = "matrix14";
            this.matrix14.Size = new System.Drawing.Size(29, 22);
            this.matrix14.TabIndex = 33;
            this.matrix14.Text = "0";
            // 
            // matrix9
            // 
            this.matrix9.Location = new System.Drawing.Point(1591, 183);
            this.matrix9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix9.Name = "matrix9";
            this.matrix9.Size = new System.Drawing.Size(29, 22);
            this.matrix9.TabIndex = 34;
            this.matrix9.Text = "0";
            // 
            // matrix20
            // 
            this.matrix20.Location = new System.Drawing.Point(1629, 247);
            this.matrix20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix20.Name = "matrix20";
            this.matrix20.Size = new System.Drawing.Size(29, 22);
            this.matrix20.TabIndex = 35;
            this.matrix20.Text = "0";
            // 
            // matrix15
            // 
            this.matrix15.Location = new System.Drawing.Point(1629, 215);
            this.matrix15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix15.Name = "matrix15";
            this.matrix15.Size = new System.Drawing.Size(29, 22);
            this.matrix15.TabIndex = 36;
            this.matrix15.Text = "0";
            // 
            // matrix10
            // 
            this.matrix10.Location = new System.Drawing.Point(1629, 183);
            this.matrix10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix10.Name = "matrix10";
            this.matrix10.Size = new System.Drawing.Size(29, 22);
            this.matrix10.TabIndex = 37;
            this.matrix10.Text = "0";
            // 
            // matrix5
            // 
            this.matrix5.Location = new System.Drawing.Point(1629, 151);
            this.matrix5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix5.Name = "matrix5";
            this.matrix5.Size = new System.Drawing.Size(29, 22);
            this.matrix5.TabIndex = 38;
            this.matrix5.Text = "0";
            // 
            // matrix24
            // 
            this.matrix24.Location = new System.Drawing.Point(1591, 279);
            this.matrix24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix24.Name = "matrix24";
            this.matrix24.Size = new System.Drawing.Size(29, 22);
            this.matrix24.TabIndex = 39;
            this.matrix24.Text = "0";
            // 
            // matrix25
            // 
            this.matrix25.Location = new System.Drawing.Point(1629, 279);
            this.matrix25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix25.Name = "matrix25";
            this.matrix25.Size = new System.Drawing.Size(29, 22);
            this.matrix25.TabIndex = 40;
            this.matrix25.Text = "0";
            // 
            // INFOIBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 709);
            this.Controls.Add(this.matrix25);
            this.Controls.Add(this.matrix24);
            this.Controls.Add(this.matrix5);
            this.Controls.Add(this.matrix10);
            this.Controls.Add(this.matrix15);
            this.Controls.Add(this.matrix20);
            this.Controls.Add(this.matrix9);
            this.Controls.Add(this.matrix14);
            this.Controls.Add(this.matrix19);
            this.Controls.Add(this.matrix21);
            this.Controls.Add(this.matrix22);
            this.Controls.Add(this.matrix23);
            this.Controls.Add(this.matrix16);
            this.Controls.Add(this.matrix17);
            this.Controls.Add(this.matrix18);
            this.Controls.Add(this.matrix4);
            this.Controls.Add(this.matrix3);
            this.Controls.Add(this.matrix7);
            this.Controls.Add(this.matrix8);
            this.Controls.Add(this.matrix11);
            this.Controls.Add(this.matrix12);
            this.Controls.Add(this.matrix13);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix6);
            this.Controls.Add(this.matrix1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageFileName);
            this.Controls.Add(this.LoadImageButton);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "INFOIBV";
            this.ShowIcon = false;
            this.Text = "INFOIBV";
            this.Load += new System.EventHandler(this.INFOIBV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.TextBox imageFileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matrix1;
        private System.Windows.Forms.TextBox matrix6;
        private System.Windows.Forms.TextBox matrix2;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.TextBox matrix8;
        private System.Windows.Forms.TextBox matrix7;
        private System.Windows.Forms.TextBox matrix3;
        private System.Windows.Forms.TextBox matrix4;
        private System.Windows.Forms.TextBox matrix18;
        private System.Windows.Forms.TextBox matrix17;
        private System.Windows.Forms.TextBox matrix16;
        private System.Windows.Forms.TextBox matrix23;
        private System.Windows.Forms.TextBox matrix22;
        private System.Windows.Forms.TextBox matrix21;
        private System.Windows.Forms.TextBox matrix19;
        private System.Windows.Forms.TextBox matrix14;
        private System.Windows.Forms.TextBox matrix9;
        private System.Windows.Forms.TextBox matrix20;
        private System.Windows.Forms.TextBox matrix15;
        private System.Windows.Forms.TextBox matrix10;
        private System.Windows.Forms.TextBox matrix5;
        private System.Windows.Forms.TextBox matrix24;
        private System.Windows.Forms.TextBox matrix25;
    }
}

