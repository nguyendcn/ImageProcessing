namespace DemoAlgoImageProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.picb_Seg = new System.Windows.Forms.PictureBox();
            this.btn_Seg = new System.Windows.Forms.Button();
            this.picb_Tranf = new System.Windows.Forms.PictureBox();
            this.btn_Tranformations = new System.Windows.Forms.Button();
            this.picb_Histo = new System.Windows.Forms.PictureBox();
            this.btn_Histogram = new System.Windows.Forms.Button();
            this.picb_Spatial = new System.Windows.Forms.PictureBox();
            this.btn_Spatial = new System.Windows.Forms.Button();
            this.picb_Index = new System.Windows.Forms.PictureBox();
            this.btn_Index = new System.Windows.Forms.Button();
            this.picb_ShowImage = new System.Windows.Forms.PictureBox();
            this.pnl_Index = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picb_Morphology = new System.Windows.Forms.PictureBox();
            this.btn_Morphology = new System.Windows.Forms.Button();
            this.pnl_Histogram = new System.Windows.Forms.Panel();
            this.btn_ViewDemoHis = new System.Windows.Forms.Button();
            this.pnl_Tranformations = new System.Windows.Forms.Panel();
            this.pnl_ContainerFuncTranformations = new System.Windows.Forms.Panel();
            this.pnl_ContainerOptionTransformation = new System.Windows.Forms.Panel();
            this.btn_Gray_Level_Slicing = new System.Windows.Forms.Button();
            this.btn_BitPlaneSlicing = new System.Windows.Forms.Button();
            this.btn_Logarithmic = new System.Windows.Forms.Button();
            this.btn_Power = new System.Windows.Forms.Button();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.pnl_SpatialFilter = new System.Windows.Forms.Panel();
            this.pnl_ContainerFuncSpatial = new System.Windows.Forms.Panel();
            this.pnl_ContainerOptionSpatial = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_MaxFilter = new System.Windows.Forms.Button();
            this.btn_MedianFilter = new System.Windows.Forms.Button();
            this.btn_AverageFilter = new System.Windows.Forms.Button();
            this.btn_AvgWeight = new System.Windows.Forms.Button();
            this.btn_LaplacianFilter = new System.Windows.Forms.Button();
            this.btn_SobelFilter = new System.Windows.Forms.Button();
            this.demoHistogram = new DemoAlgoImageProcessing.UI.ViewHistogramDemo();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Seg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Tranf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Histo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Spatial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ShowImage)).BeginInit();
            this.pnl_Index.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Morphology)).BeginInit();
            this.pnl_Histogram.SuspendLayout();
            this.pnl_Tranformations.SuspendLayout();
            this.pnl_ContainerOptionTransformation.SuspendLayout();
            this.pnl_SpatialFilter.SuspendLayout();
            this.pnl_ContainerOptionSpatial.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "ofd_OpenFile";
            this.ofd_OpenFile.Filter = "Image file (*.JPG)|*.JPG";
            this.ofd_OpenFile.Title = "Select Image";
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImage.Location = new System.Drawing.Point(380, 436);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(176, 73);
            this.btn_AddImage.TabIndex = 2;
            this.btn_AddImage.Text = "Insert Image";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            // 
            // picb_Seg
            // 
            this.picb_Seg.BackColor = System.Drawing.Color.Transparent;
            this.picb_Seg.Location = new System.Drawing.Point(2, 287);
            this.picb_Seg.Name = "picb_Seg";
            this.picb_Seg.Size = new System.Drawing.Size(10, 56);
            this.picb_Seg.TabIndex = 14;
            this.picb_Seg.TabStop = false;
            // 
            // btn_Seg
            // 
            this.btn_Seg.BackColor = System.Drawing.Color.Transparent;
            this.btn_Seg.CausesValidation = false;
            this.btn_Seg.FlatAppearance.BorderSize = 0;
            this.btn_Seg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seg.ForeColor = System.Drawing.Color.White;
            this.btn_Seg.Image = ((System.Drawing.Image)(resources.GetObject("btn_Seg.Image")));
            this.btn_Seg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Seg.Location = new System.Drawing.Point(12, 287);
            this.btn_Seg.Name = "btn_Seg";
            this.btn_Seg.Size = new System.Drawing.Size(94, 56);
            this.btn_Seg.TabIndex = 13;
            this.btn_Seg.Text = "Segmentation";
            this.btn_Seg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Seg.UseVisualStyleBackColor = false;
            // 
            // picb_Tranf
            // 
            this.picb_Tranf.BackColor = System.Drawing.Color.Transparent;
            this.picb_Tranf.Location = new System.Drawing.Point(2, 163);
            this.picb_Tranf.Name = "picb_Tranf";
            this.picb_Tranf.Size = new System.Drawing.Size(10, 56);
            this.picb_Tranf.TabIndex = 12;
            this.picb_Tranf.TabStop = false;
            // 
            // btn_Tranformations
            // 
            this.btn_Tranformations.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tranformations.CausesValidation = false;
            this.btn_Tranformations.FlatAppearance.BorderSize = 0;
            this.btn_Tranformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tranformations.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tranformations.ForeColor = System.Drawing.Color.White;
            this.btn_Tranformations.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tranformations.Image")));
            this.btn_Tranformations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Tranformations.Location = new System.Drawing.Point(12, 163);
            this.btn_Tranformations.Name = "btn_Tranformations";
            this.btn_Tranformations.Size = new System.Drawing.Size(94, 56);
            this.btn_Tranformations.TabIndex = 11;
            this.btn_Tranformations.Text = "Tranformation";
            this.btn_Tranformations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Tranformations.UseVisualStyleBackColor = false;
            this.btn_Tranformations.Click += new System.EventHandler(this.btn_Tranformations_Click);
            // 
            // picb_Histo
            // 
            this.picb_Histo.BackColor = System.Drawing.Color.Transparent;
            this.picb_Histo.Location = new System.Drawing.Point(2, 101);
            this.picb_Histo.Name = "picb_Histo";
            this.picb_Histo.Size = new System.Drawing.Size(10, 56);
            this.picb_Histo.TabIndex = 10;
            this.picb_Histo.TabStop = false;
            // 
            // btn_Histogram
            // 
            this.btn_Histogram.BackColor = System.Drawing.Color.Transparent;
            this.btn_Histogram.CausesValidation = false;
            this.btn_Histogram.FlatAppearance.BorderSize = 0;
            this.btn_Histogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Histogram.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Histogram.ForeColor = System.Drawing.Color.White;
            this.btn_Histogram.Image = ((System.Drawing.Image)(resources.GetObject("btn_Histogram.Image")));
            this.btn_Histogram.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Histogram.Location = new System.Drawing.Point(12, 101);
            this.btn_Histogram.Name = "btn_Histogram";
            this.btn_Histogram.Size = new System.Drawing.Size(94, 56);
            this.btn_Histogram.TabIndex = 9;
            this.btn_Histogram.Text = "Histogram";
            this.btn_Histogram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Histogram.UseVisualStyleBackColor = false;
            this.btn_Histogram.Click += new System.EventHandler(this.btn_Histogram_Click);
            // 
            // picb_Spatial
            // 
            this.picb_Spatial.BackColor = System.Drawing.Color.Transparent;
            this.picb_Spatial.Location = new System.Drawing.Point(2, 225);
            this.picb_Spatial.Name = "picb_Spatial";
            this.picb_Spatial.Size = new System.Drawing.Size(10, 56);
            this.picb_Spatial.TabIndex = 8;
            this.picb_Spatial.TabStop = false;
            // 
            // btn_Spatial
            // 
            this.btn_Spatial.BackColor = System.Drawing.Color.Transparent;
            this.btn_Spatial.CausesValidation = false;
            this.btn_Spatial.FlatAppearance.BorderSize = 0;
            this.btn_Spatial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spatial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spatial.ForeColor = System.Drawing.Color.White;
            this.btn_Spatial.Image = ((System.Drawing.Image)(resources.GetObject("btn_Spatial.Image")));
            this.btn_Spatial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Spatial.Location = new System.Drawing.Point(12, 225);
            this.btn_Spatial.Name = "btn_Spatial";
            this.btn_Spatial.Size = new System.Drawing.Size(94, 56);
            this.btn_Spatial.TabIndex = 7;
            this.btn_Spatial.Text = "Spatial Filter";
            this.btn_Spatial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Spatial.UseVisualStyleBackColor = false;
            this.btn_Spatial.Click += new System.EventHandler(this.btn_Spatial_Click);
            // 
            // picb_Index
            // 
            this.picb_Index.BackColor = System.Drawing.Color.Red;
            this.picb_Index.Location = new System.Drawing.Point(2, 39);
            this.picb_Index.Name = "picb_Index";
            this.picb_Index.Size = new System.Drawing.Size(10, 56);
            this.picb_Index.TabIndex = 6;
            this.picb_Index.TabStop = false;
            // 
            // btn_Index
            // 
            this.btn_Index.BackColor = System.Drawing.Color.Transparent;
            this.btn_Index.CausesValidation = false;
            this.btn_Index.FlatAppearance.BorderSize = 0;
            this.btn_Index.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Index.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Index.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Index.ForeColor = System.Drawing.Color.White;
            this.btn_Index.Image = ((System.Drawing.Image)(resources.GetObject("btn_Index.Image")));
            this.btn_Index.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Index.Location = new System.Drawing.Point(12, 39);
            this.btn_Index.Name = "btn_Index";
            this.btn_Index.Size = new System.Drawing.Size(94, 56);
            this.btn_Index.TabIndex = 2;
            this.btn_Index.Text = "Index";
            this.btn_Index.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Index.UseVisualStyleBackColor = false;
            this.btn_Index.Click += new System.EventHandler(this.btn_Index_Click);
            // 
            // picb_ShowImage
            // 
            this.picb_ShowImage.BackColor = System.Drawing.SystemColors.Info;
            this.picb_ShowImage.Location = new System.Drawing.Point(244, 3);
            this.picb_ShowImage.Name = "picb_ShowImage";
            this.picb_ShowImage.Size = new System.Drawing.Size(424, 418);
            this.picb_ShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_ShowImage.TabIndex = 1;
            this.picb_ShowImage.TabStop = false;
            // 
            // pnl_Index
            // 
            this.pnl_Index.Controls.Add(this.btn_AddImage);
            this.pnl_Index.Controls.Add(this.picb_ShowImage);
            this.pnl_Index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Index.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Index.Location = new System.Drawing.Point(0, 0);
            this.pnl_Index.Name = "pnl_Index";
            this.pnl_Index.Size = new System.Drawing.Size(1040, 588);
            this.pnl_Index.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.picb_Morphology);
            this.panel1.Controls.Add(this.btn_Morphology);
            this.panel1.Controls.Add(this.picb_Seg);
            this.panel1.Controls.Add(this.btn_Seg);
            this.panel1.Controls.Add(this.picb_Tranf);
            this.panel1.Controls.Add(this.btn_Tranformations);
            this.panel1.Controls.Add(this.picb_Histo);
            this.panel1.Controls.Add(this.btn_Histogram);
            this.panel1.Controls.Add(this.picb_Spatial);
            this.panel1.Controls.Add(this.btn_Spatial);
            this.panel1.Controls.Add(this.picb_Index);
            this.panel1.Controls.Add(this.btn_Index);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 588);
            this.panel1.TabIndex = 9;
            // 
            // picb_Morphology
            // 
            this.picb_Morphology.BackColor = System.Drawing.Color.Transparent;
            this.picb_Morphology.Location = new System.Drawing.Point(2, 349);
            this.picb_Morphology.Name = "picb_Morphology";
            this.picb_Morphology.Size = new System.Drawing.Size(10, 56);
            this.picb_Morphology.TabIndex = 16;
            this.picb_Morphology.TabStop = false;
            // 
            // btn_Morphology
            // 
            this.btn_Morphology.BackColor = System.Drawing.Color.Transparent;
            this.btn_Morphology.CausesValidation = false;
            this.btn_Morphology.FlatAppearance.BorderSize = 0;
            this.btn_Morphology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Morphology.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Morphology.ForeColor = System.Drawing.Color.White;
            this.btn_Morphology.Image = ((System.Drawing.Image)(resources.GetObject("btn_Morphology.Image")));
            this.btn_Morphology.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Morphology.Location = new System.Drawing.Point(12, 349);
            this.btn_Morphology.Name = "btn_Morphology";
            this.btn_Morphology.Size = new System.Drawing.Size(94, 56);
            this.btn_Morphology.TabIndex = 15;
            this.btn_Morphology.Text = "Morphology";
            this.btn_Morphology.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Morphology.UseVisualStyleBackColor = false;
            // 
            // pnl_Histogram
            // 
            this.pnl_Histogram.Controls.Add(this.btn_ViewDemoHis);
            this.pnl_Histogram.Controls.Add(this.demoHistogram);
            this.pnl_Histogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Histogram.Location = new System.Drawing.Point(0, 0);
            this.pnl_Histogram.Name = "pnl_Histogram";
            this.pnl_Histogram.Size = new System.Drawing.Size(1040, 588);
            this.pnl_Histogram.TabIndex = 3;
            this.pnl_Histogram.Visible = false;
            // 
            // btn_ViewDemoHis
            // 
            this.btn_ViewDemoHis.Location = new System.Drawing.Point(349, 418);
            this.btn_ViewDemoHis.Name = "btn_ViewDemoHis";
            this.btn_ViewDemoHis.Size = new System.Drawing.Size(84, 48);
            this.btn_ViewDemoHis.TabIndex = 0;
            this.btn_ViewDemoHis.Text = "View Demo";
            this.btn_ViewDemoHis.UseVisualStyleBackColor = true;
            this.btn_ViewDemoHis.Click += new System.EventHandler(this.btn_ViewDemoHis_Click);
            // 
            // pnl_Tranformations
            // 
            this.pnl_Tranformations.Controls.Add(this.pnl_ContainerFuncTranformations);
            this.pnl_Tranformations.Controls.Add(this.pnl_ContainerOptionTransformation);
            this.pnl_Tranformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tranformations.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tranformations.Name = "pnl_Tranformations";
            this.pnl_Tranformations.Size = new System.Drawing.Size(1040, 588);
            this.pnl_Tranformations.TabIndex = 3;
            // 
            // pnl_ContainerFuncTranformations
            // 
            this.pnl_ContainerFuncTranformations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_ContainerFuncTranformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerFuncTranformations.Location = new System.Drawing.Point(0, 47);
            this.pnl_ContainerFuncTranformations.Name = "pnl_ContainerFuncTranformations";
            this.pnl_ContainerFuncTranformations.Size = new System.Drawing.Size(1040, 541);
            this.pnl_ContainerFuncTranformations.TabIndex = 1;
            // 
            // pnl_ContainerOptionTransformation
            // 
            this.pnl_ContainerOptionTransformation.Controls.Add(this.btn_Gray_Level_Slicing);
            this.pnl_ContainerOptionTransformation.Controls.Add(this.btn_BitPlaneSlicing);
            this.pnl_ContainerOptionTransformation.Controls.Add(this.btn_Logarithmic);
            this.pnl_ContainerOptionTransformation.Controls.Add(this.btn_Power);
            this.pnl_ContainerOptionTransformation.Controls.Add(this.btn_Negative);
            this.pnl_ContainerOptionTransformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ContainerOptionTransformation.Location = new System.Drawing.Point(0, 0);
            this.pnl_ContainerOptionTransformation.Name = "pnl_ContainerOptionTransformation";
            this.pnl_ContainerOptionTransformation.Size = new System.Drawing.Size(1040, 47);
            this.pnl_ContainerOptionTransformation.TabIndex = 0;
            // 
            // btn_Gray_Level_Slicing
            // 
            this.btn_Gray_Level_Slicing.Location = new System.Drawing.Point(421, 7);
            this.btn_Gray_Level_Slicing.Name = "btn_Gray_Level_Slicing";
            this.btn_Gray_Level_Slicing.Size = new System.Drawing.Size(102, 32);
            this.btn_Gray_Level_Slicing.TabIndex = 4;
            this.btn_Gray_Level_Slicing.Text = "Gray Level Slicing";
            this.btn_Gray_Level_Slicing.UseVisualStyleBackColor = true;
            this.btn_Gray_Level_Slicing.Click += new System.EventHandler(this.btn_Gray_Level_Slicing_Click);
            // 
            // btn_BitPlaneSlicing
            // 
            this.btn_BitPlaneSlicing.Location = new System.Drawing.Point(310, 7);
            this.btn_BitPlaneSlicing.Name = "btn_BitPlaneSlicing";
            this.btn_BitPlaneSlicing.Size = new System.Drawing.Size(93, 32);
            this.btn_BitPlaneSlicing.TabIndex = 3;
            this.btn_BitPlaneSlicing.Text = "Bit Plane Slicing";
            this.btn_BitPlaneSlicing.UseVisualStyleBackColor = true;
            this.btn_BitPlaneSlicing.Click += new System.EventHandler(this.btn_BitPlaneSlicing_Click);
            // 
            // btn_Logarithmic
            // 
            this.btn_Logarithmic.Location = new System.Drawing.Point(115, 7);
            this.btn_Logarithmic.Name = "btn_Logarithmic";
            this.btn_Logarithmic.Size = new System.Drawing.Size(78, 32);
            this.btn_Logarithmic.TabIndex = 2;
            this.btn_Logarithmic.Text = "Logarithmic";
            this.btn_Logarithmic.UseVisualStyleBackColor = true;
            this.btn_Logarithmic.Click += new System.EventHandler(this.Btn_Logarithmic_Click);
            // 
            // btn_Power
            // 
            this.btn_Power.Location = new System.Drawing.Point(212, 7);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(78, 32);
            this.btn_Power.TabIndex = 1;
            this.btn_Power.Text = "Power";
            this.btn_Power.UseVisualStyleBackColor = true;
            this.btn_Power.Click += new System.EventHandler(this.btn_Power_Click);
            // 
            // btn_Negative
            // 
            this.btn_Negative.Location = new System.Drawing.Point(18, 7);
            this.btn_Negative.Name = "btn_Negative";
            this.btn_Negative.Size = new System.Drawing.Size(78, 32);
            this.btn_Negative.TabIndex = 0;
            this.btn_Negative.Text = "Negative";
            this.btn_Negative.UseVisualStyleBackColor = true;
            this.btn_Negative.Click += new System.EventHandler(this.btn_Negative_Click);
            // 
            // pnl_SpatialFilter
            // 
            this.pnl_SpatialFilter.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_SpatialFilter.Controls.Add(this.pnl_ContainerFuncSpatial);
            this.pnl_SpatialFilter.Controls.Add(this.pnl_ContainerOptionSpatial);
            this.pnl_SpatialFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SpatialFilter.Location = new System.Drawing.Point(106, 0);
            this.pnl_SpatialFilter.Name = "pnl_SpatialFilter";
            this.pnl_SpatialFilter.Size = new System.Drawing.Size(934, 588);
            this.pnl_SpatialFilter.TabIndex = 3;
            // 
            // pnl_ContainerFuncSpatial
            // 
            this.pnl_ContainerFuncSpatial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_ContainerFuncSpatial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerFuncSpatial.Location = new System.Drawing.Point(0, 51);
            this.pnl_ContainerFuncSpatial.Name = "pnl_ContainerFuncSpatial";
            this.pnl_ContainerFuncSpatial.Size = new System.Drawing.Size(934, 537);
            this.pnl_ContainerFuncSpatial.TabIndex = 1;
            // 
            // pnl_ContainerOptionSpatial
            // 
            this.pnl_ContainerOptionSpatial.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_SobelFilter);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_LaplacianFilter);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_AvgWeight);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_AverageFilter);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_MedianFilter);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_MaxFilter);
            this.pnl_ContainerOptionSpatial.Controls.Add(this.btn_Min);
            this.pnl_ContainerOptionSpatial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ContainerOptionSpatial.Location = new System.Drawing.Point(0, 0);
            this.pnl_ContainerOptionSpatial.Name = "pnl_ContainerOptionSpatial";
            this.pnl_ContainerOptionSpatial.Size = new System.Drawing.Size(934, 51);
            this.pnl_ContainerOptionSpatial.TabIndex = 0;
            // 
            // btn_Min
            // 
            this.btn_Min.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(120, 7);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(78, 32);
            this.btn_Min.TabIndex = 0;
            this.btn_Min.Text = "Min";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_MaxFilter
            // 
            this.btn_MaxFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaxFilter.Location = new System.Drawing.Point(219, 7);
            this.btn_MaxFilter.Name = "btn_MaxFilter";
            this.btn_MaxFilter.Size = new System.Drawing.Size(78, 32);
            this.btn_MaxFilter.TabIndex = 1;
            this.btn_MaxFilter.Text = "Max";
            this.btn_MaxFilter.UseVisualStyleBackColor = true;
            this.btn_MaxFilter.Click += new System.EventHandler(this.btn_MaxFilter_Click);
            // 
            // btn_MedianFilter
            // 
            this.btn_MedianFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedianFilter.Location = new System.Drawing.Point(315, 7);
            this.btn_MedianFilter.Name = "btn_MedianFilter";
            this.btn_MedianFilter.Size = new System.Drawing.Size(78, 32);
            this.btn_MedianFilter.TabIndex = 2;
            this.btn_MedianFilter.Text = "Median";
            this.btn_MedianFilter.UseVisualStyleBackColor = true;
            this.btn_MedianFilter.Click += new System.EventHandler(this.btn_MedianFilter_Click);
            // 
            // btn_AverageFilter
            // 
            this.btn_AverageFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AverageFilter.Location = new System.Drawing.Point(411, 7);
            this.btn_AverageFilter.Name = "btn_AverageFilter";
            this.btn_AverageFilter.Size = new System.Drawing.Size(78, 32);
            this.btn_AverageFilter.TabIndex = 3;
            this.btn_AverageFilter.Text = "Average";
            this.btn_AverageFilter.UseVisualStyleBackColor = true;
            this.btn_AverageFilter.Click += new System.EventHandler(this.btn_AverageFilter_Click);
            // 
            // btn_AvgWeight
            // 
            this.btn_AvgWeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvgWeight.Location = new System.Drawing.Point(519, 7);
            this.btn_AvgWeight.Name = "btn_AvgWeight";
            this.btn_AvgWeight.Size = new System.Drawing.Size(78, 32);
            this.btn_AvgWeight.TabIndex = 4;
            this.btn_AvgWeight.Text = "Avg Weight";
            this.btn_AvgWeight.UseVisualStyleBackColor = true;
            this.btn_AvgWeight.Click += new System.EventHandler(this.btn_AvgWeight_Click);
            // 
            // btn_LaplacianFilter
            // 
            this.btn_LaplacianFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LaplacianFilter.Location = new System.Drawing.Point(627, 7);
            this.btn_LaplacianFilter.Name = "btn_LaplacianFilter";
            this.btn_LaplacianFilter.Size = new System.Drawing.Size(78, 32);
            this.btn_LaplacianFilter.TabIndex = 5;
            this.btn_LaplacianFilter.Text = "Laplacian";
            this.btn_LaplacianFilter.UseVisualStyleBackColor = true;
            // 
            // btn_SobelFilter
            // 
            this.btn_SobelFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SobelFilter.Location = new System.Drawing.Point(724, 7);
            this.btn_SobelFilter.Name = "btn_SobelFilter";
            this.btn_SobelFilter.Size = new System.Drawing.Size(78, 32);
            this.btn_SobelFilter.TabIndex = 6;
            this.btn_SobelFilter.Text = "Sobel";
            this.btn_SobelFilter.UseVisualStyleBackColor = true;
            // 
            // demoHistogram
            // 
            this.demoHistogram.Location = new System.Drawing.Point(3, 12);
            this.demoHistogram.Name = "demoHistogram";
            this.demoHistogram.Size = new System.Drawing.Size(934, 305);
            this.demoHistogram.TabIndex = 0;
            this.demoHistogram.Visible = false;
            this.demoHistogram.Load += new System.EventHandler(this.demoHistogram_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 588);
            this.Controls.Add(this.pnl_SpatialFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Tranformations);
            this.Controls.Add(this.pnl_Index);
            this.Controls.Add(this.pnl_Histogram);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picb_Seg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Tranf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Histo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Spatial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ShowImage)).EndInit();
            this.pnl_Index.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_Morphology)).EndInit();
            this.pnl_Histogram.ResumeLayout(false);
            this.pnl_Tranformations.ResumeLayout(false);
            this.pnl_ContainerOptionTransformation.ResumeLayout(false);
            this.pnl_SpatialFilter.ResumeLayout(false);
            this.pnl_ContainerOptionSpatial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox picb_Seg;
        private System.Windows.Forms.Button btn_Seg;
        private System.Windows.Forms.PictureBox picb_Tranf;
        private System.Windows.Forms.Button btn_Tranformations;
        private System.Windows.Forms.PictureBox picb_Histo;
        private System.Windows.Forms.Button btn_Histogram;
        private System.Windows.Forms.PictureBox picb_Spatial;
        private System.Windows.Forms.Button btn_Spatial;
        private System.Windows.Forms.PictureBox picb_Index;
        private System.Windows.Forms.Button btn_Index;
        private System.Windows.Forms.PictureBox picb_ShowImage;
        private System.Windows.Forms.Panel pnl_Index;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Histogram;
        private System.Windows.Forms.Panel pnl_Tranformations;
        private System.Windows.Forms.Button btn_ViewDemoHis;
        private System.Windows.Forms.Panel pnl_SpatialFilter;
        private UI.ViewHistogramDemo demoHistogram;
        private System.Windows.Forms.Panel pnl_ContainerOptionTransformation;
        private System.Windows.Forms.Panel pnl_ContainerFuncTranformations;
        private System.Windows.Forms.Button btn_Gray_Level_Slicing;
        private System.Windows.Forms.Button btn_BitPlaneSlicing;
        private System.Windows.Forms.Button btn_Logarithmic;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.Button btn_Negative;
        private System.Windows.Forms.PictureBox picb_Morphology;
        private System.Windows.Forms.Button btn_Morphology;
        private System.Windows.Forms.Panel pnl_ContainerFuncSpatial;
        private System.Windows.Forms.Panel pnl_ContainerOptionSpatial;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_SobelFilter;
        private System.Windows.Forms.Button btn_LaplacianFilter;
        private System.Windows.Forms.Button btn_AvgWeight;
        private System.Windows.Forms.Button btn_AverageFilter;
        private System.Windows.Forms.Button btn_MedianFilter;
        private System.Windows.Forms.Button btn_MaxFilter;
    }
}