namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerAplication = new System.Windows.Forms.SplitContainer();
            this.StartComparison = new System.Windows.Forms.Button();
            this.AddImage3 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImageComparison = new System.Windows.Forms.CheckBox();
            this.AddImage2 = new System.Windows.Forms.Button();
            this.buttonStartAlgorithmLbph = new System.Windows.Forms.Button();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAlgorithmLbph = new System.Windows.Forms.CheckBox();
            this.checkBoxLinearGradient = new System.Windows.Forms.CheckBox();
            this.numericUpDownContrast = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAdjustContrast = new System.Windows.Forms.CheckBox();
            this.checkBoxGrayScale = new System.Windows.Forms.CheckBox();
            this.addImage = new System.Windows.Forms.Button();
            this.splitContainerImages = new System.Windows.Forms.SplitContainer();
            this.labelBefore = new System.Windows.Forms.Label();
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.labelAfter = new System.Windows.Forms.Label();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAplication)).BeginInit();
            this.splitContainerAplication.Panel1.SuspendLayout();
            this.splitContainerAplication.Panel2.SuspendLayout();
            this.splitContainerAplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).BeginInit();
            this.splitContainerImages.Panel1.SuspendLayout();
            this.splitContainerImages.Panel2.SuspendLayout();
            this.splitContainerImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAplication
            // 
            this.splitContainerAplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAplication.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerAplication.Name = "splitContainerAplication";
            // 
            // splitContainerAplication.Panel1
            // 
            this.splitContainerAplication.Panel1.Controls.Add(this.StartComparison);
            this.splitContainerAplication.Panel1.Controls.Add(this.AddImage3);
            this.splitContainerAplication.Panel1.Controls.Add(this.SaveButton);
            this.splitContainerAplication.Panel1.Controls.Add(this.ImageComparison);
            this.splitContainerAplication.Panel1.Controls.Add(this.AddImage2);
            this.splitContainerAplication.Panel1.Controls.Add(this.buttonStartAlgorithmLbph);
            this.splitContainerAplication.Panel1.Controls.Add(this.numericUpDownRadius);
            this.splitContainerAplication.Panel1.Controls.Add(this.checkBoxAlgorithmLbph);
            this.splitContainerAplication.Panel1.Controls.Add(this.checkBoxLinearGradient);
            this.splitContainerAplication.Panel1.Controls.Add(this.numericUpDownContrast);
            this.splitContainerAplication.Panel1.Controls.Add(this.checkBoxAdjustContrast);
            this.splitContainerAplication.Panel1.Controls.Add(this.checkBoxGrayScale);
            this.splitContainerAplication.Panel1.Controls.Add(this.addImage);
            // 
            // splitContainerAplication.Panel2
            // 
            this.splitContainerAplication.Panel2.Controls.Add(this.splitContainerImages);
            this.splitContainerAplication.Size = new System.Drawing.Size(1282, 896);
            this.splitContainerAplication.SplitterDistance = 426;
            this.splitContainerAplication.SplitterWidth = 5;
            this.splitContainerAplication.TabIndex = 0;
            this.splitContainerAplication.Text = "splitContainer1";
            // 
            // StartComparison
            // 
            this.StartComparison.Enabled = false;
            this.StartComparison.Location = new System.Drawing.Point(288, 260);
            this.StartComparison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartComparison.Name = "StartComparison";
            this.StartComparison.Size = new System.Drawing.Size(50, 31);
            this.StartComparison.TabIndex = 12;
            this.StartComparison.Text = "Start";
            this.StartComparison.UseVisualStyleBackColor = true;
            this.StartComparison.Click += new System.EventHandler(this.StartComparison_Click);
            // 
            // AddImage3
            // 
            this.AddImage3.Enabled = false;
            this.AddImage3.Location = new System.Drawing.Point(95, 260);
            this.AddImage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddImage3.Name = "AddImage3";
            this.AddImage3.Size = new System.Drawing.Size(86, 31);
            this.AddImage3.TabIndex = 11;
            this.AddImage3.Text = "Add Image";
            this.AddImage3.UseVisualStyleBackColor = true;
            this.AddImage3.Click += new System.EventHandler(this.AddImage3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(95, 4);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 31);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImageComparison
            // 
            this.ImageComparison.AutoSize = true;
            this.ImageComparison.Location = new System.Drawing.Point(14, 228);
            this.ImageComparison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageComparison.Name = "ImageComparison";
            this.ImageComparison.Size = new System.Drawing.Size(157, 24);
            this.ImageComparison.TabIndex = 9;
            this.ImageComparison.Text = "Image Comparison";
            this.ImageComparison.UseVisualStyleBackColor = true;
            this.ImageComparison.CheckedChanged += new System.EventHandler(this.ImageComparison_CheckedChanged);
            // 
            // AddImage2
            // 
            this.AddImage2.Enabled = false;
            this.AddImage2.Location = new System.Drawing.Point(3, 260);
            this.AddImage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddImage2.Name = "AddImage2";
            this.AddImage2.Size = new System.Drawing.Size(86, 31);
            this.AddImage2.TabIndex = 8;
            this.AddImage2.Text = "Add Image";
            this.AddImage2.UseVisualStyleBackColor = true;
            this.AddImage2.Click += new System.EventHandler(this.AddImage2_Click);
            // 
            // buttonStartAlgorithmLbph
            // 
            this.buttonStartAlgorithmLbph.Location = new System.Drawing.Point(288, 144);
            this.buttonStartAlgorithmLbph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStartAlgorithmLbph.Name = "buttonStartAlgorithmLbph";
            this.buttonStartAlgorithmLbph.Size = new System.Drawing.Size(50, 31);
            this.buttonStartAlgorithmLbph.TabIndex = 7;
            this.buttonStartAlgorithmLbph.Text = "Start";
            this.buttonStartAlgorithmLbph.UseVisualStyleBackColor = true;
            this.buttonStartAlgorithmLbph.Click += new System.EventHandler(this.buttonStartAlgorithmLbph_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(144, 144);
            this.numericUpDownRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownRadius.TabIndex = 6;
            this.numericUpDownRadius.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBoxAlgorithmLbph
            // 
            this.checkBoxAlgorithmLbph.AutoSize = true;
            this.checkBoxAlgorithmLbph.Location = new System.Drawing.Point(14, 145);
            this.checkBoxAlgorithmLbph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAlgorithmLbph.Name = "checkBoxAlgorithmLbph";
            this.checkBoxAlgorithmLbph.Size = new System.Drawing.Size(137, 24);
            this.checkBoxAlgorithmLbph.TabIndex = 5;
            this.checkBoxAlgorithmLbph.Text = "Algorithm LBPH";
            this.checkBoxAlgorithmLbph.UseVisualStyleBackColor = true;
            this.checkBoxAlgorithmLbph.CheckedChanged += new System.EventHandler(this.checkBoxAlgorithmLbph_CheckedChanged);
            // 
            // checkBoxLinearGradient
            // 
            this.checkBoxLinearGradient.AutoSize = true;
            this.checkBoxLinearGradient.Location = new System.Drawing.Point(14, 111);
            this.checkBoxLinearGradient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLinearGradient.Name = "checkBoxLinearGradient";
            this.checkBoxLinearGradient.Size = new System.Drawing.Size(132, 24);
            this.checkBoxLinearGradient.TabIndex = 4;
            this.checkBoxLinearGradient.Text = "Linear Gradient";
            this.checkBoxLinearGradient.UseVisualStyleBackColor = true;
            // 
            // numericUpDownContrast
            // 
            this.numericUpDownContrast.Location = new System.Drawing.Point(144, 75);
            this.numericUpDownContrast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownContrast.Name = "numericUpDownContrast";
            this.numericUpDownContrast.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownContrast.TabIndex = 3;
            this.numericUpDownContrast.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownContrast.ValueChanged += new System.EventHandler(this.numericUpDownContrast_ValueChanged);
            // 
            // checkBoxAdjustContrast
            // 
            this.checkBoxAdjustContrast.AutoSize = true;
            this.checkBoxAdjustContrast.Location = new System.Drawing.Point(14, 76);
            this.checkBoxAdjustContrast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAdjustContrast.Name = "checkBoxAdjustContrast";
            this.checkBoxAdjustContrast.Size = new System.Drawing.Size(132, 24);
            this.checkBoxAdjustContrast.TabIndex = 2;
            this.checkBoxAdjustContrast.Text = "Adjust Contrast";
            this.checkBoxAdjustContrast.UseVisualStyleBackColor = true;
            this.checkBoxAdjustContrast.CheckedChanged += new System.EventHandler(this.checkBoxAdjustContrast_CheckedChanged);
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.AutoSize = true;
            this.checkBoxGrayScale.Location = new System.Drawing.Point(14, 43);
            this.checkBoxGrayScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(100, 24);
            this.checkBoxGrayScale.TabIndex = 1;
            this.checkBoxGrayScale.Text = "Gray Scale";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            this.checkBoxGrayScale.CheckedChanged += new System.EventHandler(this.checkBoxGrayScale_CheckedChanged);
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(3, 4);
            this.addImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(86, 31);
            this.addImage.TabIndex = 0;
            this.addImage.Text = "Add Image";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // splitContainerImages
            // 
            this.splitContainerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerImages.Name = "splitContainerImages";
            // 
            // splitContainerImages.Panel1
            // 
            this.splitContainerImages.Panel1.Controls.Add(this.labelBefore);
            this.splitContainerImages.Panel1.Controls.Add(this.pictureBoxBefore);
            // 
            // splitContainerImages.Panel2
            // 
            this.splitContainerImages.Panel2.Controls.Add(this.labelAfter);
            this.splitContainerImages.Panel2.Controls.Add(this.pictureBoxAfter);
            this.splitContainerImages.Size = new System.Drawing.Size(851, 896);
            this.splitContainerImages.SplitterDistance = 282;
            this.splitContainerImages.SplitterWidth = 5;
            this.splitContainerImages.TabIndex = 0;
            this.splitContainerImages.Text = "splitContainer2";
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Location = new System.Drawing.Point(3, 4);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(53, 20);
            this.labelBefore.TabIndex = 0;
            this.labelBefore.Text = "Before";
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBefore.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(282, 896);
            this.pictureBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBefore.TabIndex = 1;
            this.pictureBoxBefore.TabStop = false;
            this.pictureBoxBefore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBefore_MouseClick);
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(3, 4);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(42, 20);
            this.labelAfter.TabIndex = 0;
            this.labelAfter.Text = "After";
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAfter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAfter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(564, 896);
            this.pictureBoxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAfter.TabIndex = 1;
            this.pictureBoxAfter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 896);
            this.Controls.Add(this.splitContainerAplication);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Process Image";
            this.splitContainerAplication.Panel1.ResumeLayout(false);
            this.splitContainerAplication.Panel1.PerformLayout();
            this.splitContainerAplication.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAplication)).EndInit();
            this.splitContainerAplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).EndInit();
            this.splitContainerImages.Panel1.ResumeLayout(false);
            this.splitContainerImages.Panel1.PerformLayout();
            this.splitContainerImages.Panel2.ResumeLayout(false);
            this.splitContainerImages.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).EndInit();
            this.splitContainerImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAplication;
        private System.Windows.Forms.CheckBox checkBoxGrayScale;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.SplitContainer splitContainerImages;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.CheckBox checkBoxAdjustContrast;
        private System.Windows.Forms.NumericUpDown numericUpDownContrast;
        private System.Windows.Forms.CheckBox checkBoxLinearGradient;
        private System.Windows.Forms.CheckBox checkBoxAlgorithmLbph;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Button buttonStartAlgorithmLbph;
        private System.Windows.Forms.Button AddImage2;
        private System.Windows.Forms.CheckBox ImageComparison;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddImage3;
        private System.Windows.Forms.Button StartComparison;
    }
}

