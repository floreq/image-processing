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
            this.ScaleButton = new System.Windows.Forms.Button();
            this.CompareAndSaveResults = new System.Windows.Forms.Button();
            this.PathToResults = new System.Windows.Forms.Label();
            this.PathToCSV = new System.Windows.Forms.TextBox();
            this.ConvertEveryPicture = new System.Windows.Forms.Button();
            this.PathWhereToSavePictures = new System.Windows.Forms.Label();
            this.PathToFolderWithPictures = new System.Windows.Forms.Label();
            this.PathToSaveImages = new System.Windows.Forms.TextBox();
            this.PathOfFolder = new System.Windows.Forms.TextBox();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGammaCorection = new System.Windows.Forms.CheckBox();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SaveName = new System.Windows.Forms.TextBox();
            this.CompareOutput = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
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
            this.splitContainerAplication.Panel1.Controls.Add(this.ScaleButton);
            this.splitContainerAplication.Panel1.Controls.Add(this.CompareAndSaveResults);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathToResults);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathToCSV);
            this.splitContainerAplication.Panel1.Controls.Add(this.ConvertEveryPicture);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathWhereToSavePictures);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathToFolderWithPictures);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathToSaveImages);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathOfFolder);
            this.splitContainerAplication.Panel1.Controls.Add(this.numericUpDownGamma);
            this.splitContainerAplication.Panel1.Controls.Add(this.checkBoxGammaCorection);
            this.splitContainerAplication.Panel1.Controls.Add(this.SavePath);
            this.splitContainerAplication.Panel1.Controls.Add(this.PathLabel);
            this.splitContainerAplication.Panel1.Controls.Add(this.NameLabel);
            this.splitContainerAplication.Panel1.Controls.Add(this.SaveName);
            this.splitContainerAplication.Panel1.Controls.Add(this.CompareOutput);
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
            this.splitContainerAplication.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerAplication_Panel1_Paint);
            // 
            // splitContainerAplication.Panel2
            // 
            this.splitContainerAplication.Panel2.Controls.Add(this.splitContainerImages);
            this.splitContainerAplication.Size = new System.Drawing.Size(3144, 1610);
            this.splitContainerAplication.SplitterDistance = 1625;
            this.splitContainerAplication.SplitterWidth = 5;
            this.splitContainerAplication.TabIndex = 0;
            this.splitContainerAplication.Text = "splitContainer1";
            // 
            // ScaleButton
            // 
            this.ScaleButton.Enabled = false;
            this.ScaleButton.Location = new System.Drawing.Point(394, 800);
            this.ScaleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(109, 39);
            this.ScaleButton.TabIndex = 30;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.Click += new System.EventHandler(this.ScaleButton_Click_1);
            // 
            // CompareAndSaveResults
            // 
            this.CompareAndSaveResults.Location = new System.Drawing.Point(231, 924);
            this.CompareAndSaveResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompareAndSaveResults.Name = "CompareAndSaveResults";
            this.CompareAndSaveResults.Size = new System.Drawing.Size(289, 39);
            this.CompareAndSaveResults.TabIndex = 29;
            this.CompareAndSaveResults.Text = "Compare and save";
            this.CompareAndSaveResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CompareAndSaveResults.UseVisualStyleBackColor = true;
            this.CompareAndSaveResults.Click += new System.EventHandler(this.CompareAndSaveResults_Click);
            // 
            // PathToResults
            // 
            this.PathToResults.AutoSize = true;
            this.PathToResults.Location = new System.Drawing.Point(21, 880);
            this.PathToResults.Name = "PathToResults";
            this.PathToResults.Size = new System.Drawing.Size(79, 20);
            this.PathToResults.TabIndex = 28;
            this.PathToResults.Text = "Path to csv";
            // 
            // PathToCSV
            // 
            this.PathToCSV.Location = new System.Drawing.Point(231, 875);
            this.PathToCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PathToCSV.Name = "PathToCSV";
            this.PathToCSV.Size = new System.Drawing.Size(288, 27);
            this.PathToCSV.TabIndex = 27;
            this.PathToCSV.TextChanged += new System.EventHandler(this.PathToCSV_TextChanged);
            // 
            // ConvertEveryPicture
            // 
            this.ConvertEveryPicture.Enabled = false;
            this.ConvertEveryPicture.Location = new System.Drawing.Point(231, 800);
            this.ConvertEveryPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConvertEveryPicture.Name = "ConvertEveryPicture";
            this.ConvertEveryPicture.Size = new System.Drawing.Size(109, 39);
            this.ConvertEveryPicture.TabIndex = 26;
            this.ConvertEveryPicture.Text = "Convert all";
            this.ConvertEveryPicture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConvertEveryPicture.UseVisualStyleBackColor = true;
            this.ConvertEveryPicture.Click += new System.EventHandler(this.ConvertEveryPicture_Click);
            // 
            // PathWhereToSavePictures
            // 
            this.PathWhereToSavePictures.AutoSize = true;
            this.PathWhereToSavePictures.Location = new System.Drawing.Point(18, 756);
            this.PathWhereToSavePictures.Name = "PathWhereToSavePictures";
            this.PathWhereToSavePictures.Size = new System.Drawing.Size(145, 20);
            this.PathWhereToSavePictures.TabIndex = 25;
            this.PathWhereToSavePictures.Text = "Path to empty folder";
            this.PathWhereToSavePictures.Click += new System.EventHandler(this.PathWhereToSavePictures_Click);
            // 
            // PathToFolderWithPictures
            // 
            this.PathToFolderWithPictures.AutoSize = true;
            this.PathToFolderWithPictures.Location = new System.Drawing.Point(18, 709);
            this.PathToFolderWithPictures.Name = "PathToFolderWithPictures";
            this.PathToFolderWithPictures.Size = new System.Drawing.Size(111, 20);
            this.PathToFolderWithPictures.TabIndex = 24;
            this.PathToFolderWithPictures.Text = "Path to pictures";
            // 
            // PathToSaveImages
            // 
            this.PathToSaveImages.Location = new System.Drawing.Point(231, 751);
            this.PathToSaveImages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PathToSaveImages.Name = "PathToSaveImages";
            this.PathToSaveImages.Size = new System.Drawing.Size(288, 27);
            this.PathToSaveImages.TabIndex = 23;
            this.PathToSaveImages.TextChanged += new System.EventHandler(this.PathToSaveImages_TextChanged);
            // 
            // PathOfFolder
            // 
            this.PathOfFolder.Location = new System.Drawing.Point(231, 704);
            this.PathOfFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PathOfFolder.Name = "PathOfFolder";
            this.PathOfFolder.Size = new System.Drawing.Size(288, 27);
            this.PathOfFolder.TabIndex = 22;
            this.PathOfFolder.TextChanged += new System.EventHandler(this.PathOfFolder_TextChanged);
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.DecimalPlaces = 2;
            this.numericUpDownGamma.Enabled = false;
            this.numericUpDownGamma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownGamma.Location = new System.Drawing.Point(206, 354);
            this.numericUpDownGamma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGamma.Maximum = new decimal(new int[] {
            799,
            0,
            0,
            131072});
            this.numericUpDownGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(171, 27);
            this.numericUpDownGamma.TabIndex = 20;
            this.numericUpDownGamma.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownGamma.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownGamma.ValueChanged += new System.EventHandler(this.numericUpDownGamma_ValueChanged);
            // 
            // checkBoxGammaCorection
            // 
            this.checkBoxGammaCorection.AutoSize = true;
            this.checkBoxGammaCorection.Enabled = false;
            this.checkBoxGammaCorection.Location = new System.Drawing.Point(21, 355);
            this.checkBoxGammaCorection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxGammaCorection.Name = "checkBoxGammaCorection";
            this.checkBoxGammaCorection.Size = new System.Drawing.Size(151, 24);
            this.checkBoxGammaCorection.TabIndex = 19;
            this.checkBoxGammaCorection.Text = "Gamma Corection";
            this.checkBoxGammaCorection.UseVisualStyleBackColor = true;
            this.checkBoxGammaCorection.CheckedChanged += new System.EventHandler(this.checkBoxGammaCorection_CheckedChanged);
            // 
            // SavePath
            // 
            this.SavePath.Location = new System.Drawing.Point(231, 114);
            this.SavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(288, 27);
            this.SavePath.TabIndex = 18;
            this.SavePath.TextChanged += new System.EventHandler(this.SavePath_TextChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(18, 116);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(165, 20);
            this.PathLabel.TabIndex = 17;
            this.PathLabel.Text = "Path of new image save";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(18, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(164, 20);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name of image to save";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(231, 65);
            this.SaveName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(288, 27);
            this.SaveName.TabIndex = 14;
            this.SaveName.TextChanged += new System.EventHandler(this.SaveName_TextChanged);
            // 
            // CompareOutput
            // 
            this.CompareOutput.AutoSize = true;
            this.CompareOutput.Location = new System.Drawing.Point(20, 595);
            this.CompareOutput.Name = "CompareOutput";
            this.CompareOutput.Size = new System.Drawing.Size(0, 15);
            this.CompareOutput.TabIndex = 13;
            this.CompareOutput.Click += new System.EventHandler(this.CompareOutput_Click);
            // 
            // StartComparison
            // 
            this.StartComparison.Enabled = false;
            this.StartComparison.Location = new System.Drawing.Point(370, 526);
            this.StartComparison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartComparison.Name = "StartComparison";
            this.StartComparison.Size = new System.Drawing.Size(61, 39);
            this.StartComparison.TabIndex = 12;
            this.StartComparison.Text = "Start";
            this.StartComparison.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartComparison.UseVisualStyleBackColor = true;
            this.StartComparison.Click += new System.EventHandler(this.StartComparison_Click);
            // 
            // AddImage3
            // 
            this.AddImage3.Enabled = false;
            this.AddImage3.Location = new System.Drawing.Point(134, 530);
            this.AddImage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddImage3.Name = "AddImage3";
            this.AddImage3.Size = new System.Drawing.Size(109, 39);
            this.AddImage3.TabIndex = 11;
            this.AddImage3.Text = "Add Image";
            this.AddImage3.UseVisualStyleBackColor = true;
            this.AddImage3.Click += new System.EventHandler(this.AddImage3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(231, 161);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 39);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImageComparison
            // 
            this.ImageComparison.AutoSize = true;
            this.ImageComparison.Location = new System.Drawing.Point(21, 489);
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
            this.AddImage2.Location = new System.Drawing.Point(20, 530);
            this.AddImage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddImage2.Name = "AddImage2";
            this.AddImage2.Size = new System.Drawing.Size(109, 39);
            this.AddImage2.TabIndex = 8;
            this.AddImage2.Text = "Add Image";
            this.AddImage2.UseVisualStyleBackColor = true;
            this.AddImage2.Click += new System.EventHandler(this.AddImage2_Click);
            // 
            // buttonStartAlgorithmLbph
            // 
            this.buttonStartAlgorithmLbph.Enabled = false;
            this.buttonStartAlgorithmLbph.Location = new System.Drawing.Point(370, 435);
            this.buttonStartAlgorithmLbph.Name = "buttonStartAlgorithmLbph";
            this.buttonStartAlgorithmLbph.Size = new System.Drawing.Size(61, 39);
            this.buttonStartAlgorithmLbph.TabIndex = 7;
            this.buttonStartAlgorithmLbph.Text = "Start";
            this.buttonStartAlgorithmLbph.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartAlgorithmLbph.UseVisualStyleBackColor = true;
            this.buttonStartAlgorithmLbph.Click += new System.EventHandler(this.buttonStartAlgorithmLbph_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Enabled = false;
            this.numericUpDownRadius.Location = new System.Drawing.Point(190, 436);
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
            this.numericUpDownRadius.Size = new System.Drawing.Size(171, 27);
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
            this.checkBoxAlgorithmLbph.Enabled = false;
            this.checkBoxAlgorithmLbph.Location = new System.Drawing.Point(21, 436);
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
            this.checkBoxLinearGradient.Enabled = false;
            this.checkBoxLinearGradient.Location = new System.Drawing.Point(21, 400);
            this.checkBoxLinearGradient.Name = "checkBoxLinearGradient";
            this.checkBoxLinearGradient.Size = new System.Drawing.Size(132, 24);
            this.checkBoxLinearGradient.TabIndex = 4;
            this.checkBoxLinearGradient.Text = "Linear Gradient";
            this.checkBoxLinearGradient.UseVisualStyleBackColor = true;
            // 
            // numericUpDownContrast
            // 
            this.numericUpDownContrast.Enabled = false;
            this.numericUpDownContrast.Location = new System.Drawing.Point(190, 306);
            this.numericUpDownContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownContrast.Name = "numericUpDownContrast";
            this.numericUpDownContrast.Size = new System.Drawing.Size(171, 27);
            this.numericUpDownContrast.TabIndex = 3;
            this.numericUpDownContrast.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownContrast.ValueChanged += new System.EventHandler(this.numericUpDownContrast_ValueChanged);
            // 
            // checkBoxAdjustContrast
            // 
            this.checkBoxAdjustContrast.AutoSize = true;
            this.checkBoxAdjustContrast.Enabled = false;
            this.checkBoxAdjustContrast.Location = new System.Drawing.Point(21, 309);
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
            this.checkBoxGrayScale.Enabled = false;
            this.checkBoxGrayScale.Location = new System.Drawing.Point(21, 270);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(100, 24);
            this.checkBoxGrayScale.TabIndex = 1;
            this.checkBoxGrayScale.Text = "Gray Scale";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            this.checkBoxGrayScale.CheckedChanged += new System.EventHandler(this.checkBoxGrayScale_CheckedChanged);
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(18, 15);
            this.addImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(109, 39);
            this.addImage.TabIndex = 0;
            this.addImage.Text = "Add Image";
            this.addImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.splitContainerImages.Size = new System.Drawing.Size(1514, 1610);
            this.splitContainerImages.SplitterDistance = 775;
            this.splitContainerImages.SplitterWidth = 5;
            this.splitContainerImages.TabIndex = 0;
            this.splitContainerImages.Text = "splitContainer2";
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Location = new System.Drawing.Point(4, 5);
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
            this.pictureBoxBefore.Size = new System.Drawing.Size(775, 1610);
            this.pictureBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBefore.TabIndex = 1;
            this.pictureBoxBefore.TabStop = false;
            this.pictureBoxBefore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBefore_MouseClick);
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(4, 5);
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
            this.pictureBoxAfter.Size = new System.Drawing.Size(734, 1610);
            this.pictureBoxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAfter.TabIndex = 1;
            this.pictureBoxAfter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2515, 1288);
            this.Controls.Add(this.splitContainerAplication);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Process Image";
            this.splitContainerAplication.Panel1.ResumeLayout(false);
            this.splitContainerAplication.Panel1.PerformLayout();
            this.splitContainerAplication.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAplication)).EndInit();
            this.splitContainerAplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
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
        private System.Windows.Forms.Label CompareOutput;
        private System.Windows.Forms.TextBox SaveName;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxGammaCorection;
        private System.Windows.Forms.NumericUpDown numericUpDownGamma;
        private System.Windows.Forms.TextBox PathOfFolder;
        private System.Windows.Forms.TextBox PathToSaveImages;
        private System.Windows.Forms.Label PathWhereToSavePictures;
        private System.Windows.Forms.Label PathToFolderWithPictures;
        private System.Windows.Forms.Button ConvertEveryPicture;
        private System.Windows.Forms.TextBox PathToCSV;
        private System.Windows.Forms.Label PathToResults;
        private System.Windows.Forms.Button CompareAndSaveResults;
        private System.Windows.Forms.Button ScaleButton;
    }
}

