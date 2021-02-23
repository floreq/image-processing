namespace ImagesProcessing
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
            this.buttonImages = new System.Windows.Forms.Button();
            this.groupBoxDetectTarget = new System.Windows.Forms.GroupBox();
            this.radioButtonNotDetectTarget = new System.Windows.Forms.RadioButton();
            this.radioButtonDetectTarget = new System.Windows.Forms.RadioButton();
            this.buttonProcessedImagesPath = new System.Windows.Forms.Button();
            this.textBoxProcessedImagesPath = new System.Windows.Forms.TextBox();
            this.buttonStartProcessing = new System.Windows.Forms.Button();
            this.groupBoxImageCorections = new System.Windows.Forms.GroupBox();
            this.numericUpDownGammaCorection = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAdjustContrast = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGammaCorection = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturation = new System.Windows.Forms.CheckBox();
            this.checkBoxAdjustConstrast = new System.Windows.Forms.CheckBox();
            this.textBoxImages = new System.Windows.Forms.TextBox();
            this.checkBoxRezieImage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.labelImageHeight = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.checkBoxLBPH = new System.Windows.Forms.CheckBox();
            this.numericUpDownLbphRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxCrossValid = new System.Windows.Forms.CheckBox();
            this.groupBoxDetectTarget.SuspendLayout();
            this.groupBoxImageCorections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaCorection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdjustContrast)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLbphRadius)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImages
            // 
            this.buttonImages.Location = new System.Drawing.Point(13, 13);
            this.buttonImages.Name = "buttonImages";
            this.buttonImages.Size = new System.Drawing.Size(215, 23);
            this.buttonImages.TabIndex = 0;
            this.buttonImages.Text = "Select Images to process";
            this.buttonImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImages.UseVisualStyleBackColor = true;
            this.buttonImages.Click += new System.EventHandler(this.buttonImages_Click);
            // 
            // groupBoxDetectTarget
            // 
            this.groupBoxDetectTarget.Controls.Add(this.radioButtonNotDetectTarget);
            this.groupBoxDetectTarget.Controls.Add(this.radioButtonDetectTarget);
            this.groupBoxDetectTarget.Location = new System.Drawing.Point(13, 172);
            this.groupBoxDetectTarget.Name = "groupBoxDetectTarget";
            this.groupBoxDetectTarget.Size = new System.Drawing.Size(215, 48);
            this.groupBoxDetectTarget.TabIndex = 1;
            this.groupBoxDetectTarget.TabStop = false;
            this.groupBoxDetectTarget.Text = "Crop to Face";
            // 
            // radioButtonNotDetectTarget
            // 
            this.radioButtonNotDetectTarget.AutoSize = true;
            this.radioButtonNotDetectTarget.Checked = true;
            this.radioButtonNotDetectTarget.Location = new System.Drawing.Point(57, 20);
            this.radioButtonNotDetectTarget.Name = "radioButtonNotDetectTarget";
            this.radioButtonNotDetectTarget.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNotDetectTarget.TabIndex = 1;
            this.radioButtonNotDetectTarget.TabStop = true;
            this.radioButtonNotDetectTarget.Text = "No";
            this.radioButtonNotDetectTarget.UseVisualStyleBackColor = true;
            this.radioButtonNotDetectTarget.CheckedChanged += new System.EventHandler(this.radioButtonNotDetectTarget_CheckedChanged);
            // 
            // radioButtonDetectTarget
            // 
            this.radioButtonDetectTarget.AutoSize = true;
            this.radioButtonDetectTarget.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDetectTarget.Name = "radioButtonDetectTarget";
            this.radioButtonDetectTarget.Size = new System.Drawing.Size(43, 17);
            this.radioButtonDetectTarget.TabIndex = 0;
            this.radioButtonDetectTarget.Text = "Yes";
            this.radioButtonDetectTarget.UseVisualStyleBackColor = true;
            this.radioButtonDetectTarget.CheckedChanged += new System.EventHandler(this.radioButtonDetectTarget_CheckedChanged);
            // 
            // buttonProcessedImagesPath
            // 
            this.buttonProcessedImagesPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcessedImagesPath.Location = new System.Drawing.Point(13, 43);
            this.buttonProcessedImagesPath.Name = "buttonProcessedImagesPath";
            this.buttonProcessedImagesPath.Size = new System.Drawing.Size(215, 23);
            this.buttonProcessedImagesPath.TabIndex = 2;
            this.buttonProcessedImagesPath.Text = "Select Path to save Processed Images";
            this.buttonProcessedImagesPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcessedImagesPath.UseVisualStyleBackColor = true;
            this.buttonProcessedImagesPath.Click += new System.EventHandler(this.buttonProcessedImagesPath_Click);
            // 
            // textBoxProcessedImagesPath
            // 
            this.textBoxProcessedImagesPath.Location = new System.Drawing.Point(234, 45);
            this.textBoxProcessedImagesPath.Name = "textBoxProcessedImagesPath";
            this.textBoxProcessedImagesPath.ReadOnly = true;
            this.textBoxProcessedImagesPath.Size = new System.Drawing.Size(215, 20);
            this.textBoxProcessedImagesPath.TabIndex = 3;
            this.textBoxProcessedImagesPath.Text = "No Path Selected";
            // 
            // buttonStartProcessing
            // 
            this.buttonStartProcessing.Location = new System.Drawing.Point(12, 332);
            this.buttonStartProcessing.Name = "buttonStartProcessing";
            this.buttonStartProcessing.Size = new System.Drawing.Size(216, 23);
            this.buttonStartProcessing.TabIndex = 4;
            this.buttonStartProcessing.Text = "Start Processing";
            this.buttonStartProcessing.UseVisualStyleBackColor = true;
            this.buttonStartProcessing.Click += new System.EventHandler(this.buttonStartProcessing_Click);
            // 
            // groupBoxImageCorections
            // 
            this.groupBoxImageCorections.Controls.Add(this.numericUpDownGammaCorection);
            this.groupBoxImageCorections.Controls.Add(this.numericUpDownSaturation);
            this.groupBoxImageCorections.Controls.Add(this.numericUpDownAdjustContrast);
            this.groupBoxImageCorections.Controls.Add(this.checkBoxGammaCorection);
            this.groupBoxImageCorections.Controls.Add(this.checkBoxSaturation);
            this.groupBoxImageCorections.Controls.Add(this.checkBoxAdjustConstrast);
            this.groupBoxImageCorections.Location = new System.Drawing.Point(12, 72);
            this.groupBoxImageCorections.Name = "groupBoxImageCorections";
            this.groupBoxImageCorections.Size = new System.Drawing.Size(216, 94);
            this.groupBoxImageCorections.TabIndex = 5;
            this.groupBoxImageCorections.TabStop = false;
            this.groupBoxImageCorections.Text = "Image Corections";
            // 
            // numericUpDownGammaCorection
            // 
            this.numericUpDownGammaCorection.DecimalPlaces = 1;
            this.numericUpDownGammaCorection.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGammaCorection.Location = new System.Drawing.Point(120, 64);
            this.numericUpDownGammaCorection.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGammaCorection.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownGammaCorection.Name = "numericUpDownGammaCorection";
            this.numericUpDownGammaCorection.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownGammaCorection.TabIndex = 8;
            this.numericUpDownGammaCorection.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownGammaCorection.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numericUpDownSaturation
            // 
            this.numericUpDownSaturation.Location = new System.Drawing.Point(120, 41);
            this.numericUpDownSaturation.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSaturation.Name = "numericUpDownSaturation";
            this.numericUpDownSaturation.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSaturation.TabIndex = 8;
            this.numericUpDownSaturation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownAdjustContrast
            // 
            this.numericUpDownAdjustContrast.Location = new System.Drawing.Point(120, 18);
            this.numericUpDownAdjustContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAdjustContrast.Name = "numericUpDownAdjustContrast";
            this.numericUpDownAdjustContrast.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAdjustContrast.TabIndex = 7;
            this.numericUpDownAdjustContrast.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // checkBoxGammaCorection
            // 
            this.checkBoxGammaCorection.AutoSize = true;
            this.checkBoxGammaCorection.Location = new System.Drawing.Point(6, 65);
            this.checkBoxGammaCorection.Name = "checkBoxGammaCorection";
            this.checkBoxGammaCorection.Size = new System.Drawing.Size(110, 17);
            this.checkBoxGammaCorection.TabIndex = 2;
            this.checkBoxGammaCorection.Text = "Gamma Corection";
            this.checkBoxGammaCorection.UseVisualStyleBackColor = true;
            this.checkBoxGammaCorection.CheckedChanged += new System.EventHandler(this.checkBoxGammaCorection_CheckedChanged);
            // 
            // checkBoxSaturation
            // 
            this.checkBoxSaturation.AutoSize = true;
            this.checkBoxSaturation.Location = new System.Drawing.Point(6, 42);
            this.checkBoxSaturation.Name = "checkBoxSaturation";
            this.checkBoxSaturation.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSaturation.TabIndex = 1;
            this.checkBoxSaturation.Text = "Saturation";
            this.checkBoxSaturation.UseVisualStyleBackColor = true;
            this.checkBoxSaturation.CheckedChanged += new System.EventHandler(this.checkBoxSaturation_CheckedChanged);
            // 
            // checkBoxAdjustConstrast
            // 
            this.checkBoxAdjustConstrast.AutoSize = true;
            this.checkBoxAdjustConstrast.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAdjustConstrast.Name = "checkBoxAdjustConstrast";
            this.checkBoxAdjustConstrast.Size = new System.Drawing.Size(97, 17);
            this.checkBoxAdjustConstrast.TabIndex = 0;
            this.checkBoxAdjustConstrast.Text = "Adjust Contrast";
            this.checkBoxAdjustConstrast.UseVisualStyleBackColor = true;
            this.checkBoxAdjustConstrast.CheckedChanged += new System.EventHandler(this.checkBoxAdjustConstrast_CheckedChanged);
            // 
            // textBoxImages
            // 
            this.textBoxImages.Location = new System.Drawing.Point(234, 15);
            this.textBoxImages.Name = "textBoxImages";
            this.textBoxImages.ReadOnly = true;
            this.textBoxImages.Size = new System.Drawing.Size(215, 20);
            this.textBoxImages.TabIndex = 6;
            this.textBoxImages.Text = "No Images Selected";
            // 
            // checkBoxRezieImage
            // 
            this.checkBoxRezieImage.AutoSize = true;
            this.checkBoxRezieImage.Location = new System.Drawing.Point(7, 16);
            this.checkBoxRezieImage.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRezieImage.Name = "checkBoxRezieImage";
            this.checkBoxRezieImage.Size = new System.Drawing.Size(90, 17);
            this.checkBoxRezieImage.TabIndex = 8;
            this.checkBoxRezieImage.Text = "Resize Image";
            this.checkBoxRezieImage.UseVisualStyleBackColor = true;
            this.checkBoxRezieImage.CheckedChanged += new System.EventHandler(this.checkBoxRezieImage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownWidth);
            this.groupBox1.Controls.Add(this.checkBoxRezieImage);
            this.groupBox1.Controls.Add(this.numericUpDownHeight);
            this.groupBox1.Controls.Add(this.labelImageHeight);
            this.groupBox1.Controls.Add(this.labelImageWidth);
            this.groupBox1.Location = new System.Drawing.Point(13, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(215, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Size";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(76, 36);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownWidth.TabIndex = 9;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(76, 58);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownHeight.TabIndex = 12;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelImageHeight
            // 
            this.labelImageHeight.AutoSize = true;
            this.labelImageHeight.Location = new System.Drawing.Point(4, 60);
            this.labelImageHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImageHeight.Name = "labelImageHeight";
            this.labelImageHeight.Size = new System.Drawing.Size(69, 13);
            this.labelImageHeight.TabIndex = 11;
            this.labelImageHeight.Text = "Height (in px)";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Location = new System.Drawing.Point(4, 37);
            this.labelImageWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(66, 13);
            this.labelImageWidth.TabIndex = 10;
            this.labelImageWidth.Text = "Width (in px)";
            // 
            // checkBoxLBPH
            // 
            this.checkBoxLBPH.AutoSize = true;
            this.checkBoxLBPH.Location = new System.Drawing.Point(6, 19);
            this.checkBoxLBPH.Name = "checkBoxLBPH";
            this.checkBoxLBPH.Size = new System.Drawing.Size(46, 17);
            this.checkBoxLBPH.TabIndex = 10;
            this.checkBoxLBPH.Text = "LBP";
            this.checkBoxLBPH.UseVisualStyleBackColor = true;
            this.checkBoxLBPH.CheckedChanged += new System.EventHandler(this.checkBoxLBPH_CheckedChanged);
            // 
            // numericUpDownLbphRadius
            // 
            this.numericUpDownLbphRadius.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLbphRadius.Location = new System.Drawing.Point(119, 16);
            this.numericUpDownLbphRadius.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownLbphRadius.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownLbphRadius.Name = "numericUpDownLbphRadius";
            this.numericUpDownLbphRadius.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownLbphRadius.TabIndex = 11;
            this.numericUpDownLbphRadius.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownLbphRadius.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxCrossValid);
            this.groupBox2.Controls.Add(this.numericUpDownLbphRadius);
            this.groupBox2.Controls.Add(this.checkBoxLBPH);
            this.groupBox2.Location = new System.Drawing.Point(234, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compare";
            // 
            // checkBoxCrossValid
            // 
            this.checkBoxCrossValid.AutoSize = true;
            this.checkBoxCrossValid.Location = new System.Drawing.Point(6, 42);
            this.checkBoxCrossValid.Name = "checkBoxCrossValid";
            this.checkBoxCrossValid.Size = new System.Drawing.Size(98, 17);
            this.checkBoxCrossValid.TabIndex = 12;
            this.checkBoxCrossValid.Text = "CrossValidation";
            this.checkBoxCrossValid.UseVisualStyleBackColor = true;
            this.checkBoxCrossValid.CheckedChanged += new System.EventHandler(this.checkBoxCrossValid_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxImages);
            this.Controls.Add(this.groupBoxImageCorections);
            this.Controls.Add(this.buttonStartProcessing);
            this.Controls.Add(this.textBoxProcessedImagesPath);
            this.Controls.Add(this.buttonProcessedImagesPath);
            this.Controls.Add(this.groupBoxDetectTarget);
            this.Controls.Add(this.buttonImages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDetectTarget.ResumeLayout(false);
            this.groupBoxDetectTarget.PerformLayout();
            this.groupBoxImageCorections.ResumeLayout(false);
            this.groupBoxImageCorections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaCorection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdjustContrast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLbphRadius)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImages;
        private System.Windows.Forms.GroupBox groupBoxDetectTarget;
        private System.Windows.Forms.Button buttonProcessedImagesPath;
        private System.Windows.Forms.TextBox textBoxProcessedImagesPath;
        private System.Windows.Forms.RadioButton radioButtonDetectTarget;
        private System.Windows.Forms.RadioButton radioButtonNotDetectTarget;
        private System.Windows.Forms.Button buttonStartProcessing;
        private System.Windows.Forms.GroupBox groupBoxImageCorections;
        private System.Windows.Forms.CheckBox checkBoxGammaCorection;
        private System.Windows.Forms.CheckBox checkBoxSaturation;
        private System.Windows.Forms.CheckBox checkBoxAdjustConstrast;
        private System.Windows.Forms.TextBox textBoxImages;
        private System.Windows.Forms.NumericUpDown numericUpDownGammaCorection;
        private System.Windows.Forms.NumericUpDown numericUpDownSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownAdjustContrast;
        private System.Windows.Forms.CheckBox checkBoxRezieImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelImageHeight;
        private System.Windows.Forms.Label labelImageWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.CheckBox checkBoxLBPH;
        private System.Windows.Forms.NumericUpDown numericUpDownLbphRadius;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxCrossValid;
    }
}

