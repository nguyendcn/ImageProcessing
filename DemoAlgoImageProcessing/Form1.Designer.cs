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
            this.picb_GLS = new System.Windows.Forms.PictureBox();
            this.btn_GLS = new System.Windows.Forms.Button();
            this.picb_Bit = new System.Windows.Forms.PictureBox();
            this.btn_Tranformations = new System.Windows.Forms.Button();
            this.picb_Loga = new System.Windows.Forms.PictureBox();
            this.btn_Histogram = new System.Windows.Forms.Button();
            this.picb_PLaw = new System.Windows.Forms.PictureBox();
            this.btn_PLaw = new System.Windows.Forms.Button();
            this.picb_btnIndex = new System.Windows.Forms.PictureBox();
            this.btn_Index = new System.Windows.Forms.Button();
            this.picb_ShowImage = new System.Windows.Forms.PictureBox();
            this.pnl_Index = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Histogram = new System.Windows.Forms.Panel();
            this.btn_ViewDemoHis = new System.Windows.Forms.Button();
            this.pnl_Tranformations = new System.Windows.Forms.Panel();
            this.pnl_ContainerOptionTransformation = new System.Windows.Forms.Panel();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.btn_Power = new System.Windows.Forms.Button();
            this.btn_Logarithmic = new System.Windows.Forms.Button();
            this.btn_BitPlaneSlicing = new System.Windows.Forms.Button();
            this.btn_Gray_Level_Slicing = new System.Windows.Forms.Button();
            this.pnl_ContainerFuncTranformations = new System.Windows.Forms.Panel();
            this.demoHistogram = new DemoAlgoImageProcessing.UI.ViewHistogramDemo();
            ((System.ComponentModel.ISupportInitialize)(this.picb_GLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Bit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Loga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_PLaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_btnIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ShowImage)).BeginInit();
            this.pnl_Index.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Histogram.SuspendLayout();
            this.pnl_Tranformations.SuspendLayout();
            this.pnl_ContainerOptionTransformation.SuspendLayout();
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
            // picb_GLS
            // 
            this.picb_GLS.BackColor = System.Drawing.Color.Transparent;
            this.picb_GLS.Location = new System.Drawing.Point(2, 287);
            this.picb_GLS.Name = "picb_GLS";
            this.picb_GLS.Size = new System.Drawing.Size(10, 56);
            this.picb_GLS.TabIndex = 14;
            this.picb_GLS.TabStop = false;
            // 
            // btn_GLS
            // 
            this.btn_GLS.BackColor = System.Drawing.Color.Transparent;
            this.btn_GLS.CausesValidation = false;
            this.btn_GLS.FlatAppearance.BorderSize = 0;
            this.btn_GLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GLS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GLS.ForeColor = System.Drawing.Color.White;
            this.btn_GLS.Image = ((System.Drawing.Image)(resources.GetObject("btn_GLS.Image")));
            this.btn_GLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GLS.Location = new System.Drawing.Point(12, 287);
            this.btn_GLS.Name = "btn_GLS";
            this.btn_GLS.Size = new System.Drawing.Size(94, 56);
            this.btn_GLS.TabIndex = 13;
            this.btn_GLS.Text = "GLS";
            this.btn_GLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GLS.UseVisualStyleBackColor = false;
            // 
            // picb_Bit
            // 
            this.picb_Bit.BackColor = System.Drawing.Color.Transparent;
            this.picb_Bit.Location = new System.Drawing.Point(2, 163);
            this.picb_Bit.Name = "picb_Bit";
            this.picb_Bit.Size = new System.Drawing.Size(10, 56);
            this.picb_Bit.TabIndex = 12;
            this.picb_Bit.TabStop = false;
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
            // 
            // picb_Loga
            // 
            this.picb_Loga.BackColor = System.Drawing.Color.Transparent;
            this.picb_Loga.Location = new System.Drawing.Point(2, 101);
            this.picb_Loga.Name = "picb_Loga";
            this.picb_Loga.Size = new System.Drawing.Size(10, 56);
            this.picb_Loga.TabIndex = 10;
            this.picb_Loga.TabStop = false;
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
            // picb_PLaw
            // 
            this.picb_PLaw.BackColor = System.Drawing.Color.Transparent;
            this.picb_PLaw.Location = new System.Drawing.Point(2, 225);
            this.picb_PLaw.Name = "picb_PLaw";
            this.picb_PLaw.Size = new System.Drawing.Size(10, 56);
            this.picb_PLaw.TabIndex = 8;
            this.picb_PLaw.TabStop = false;
            // 
            // btn_PLaw
            // 
            this.btn_PLaw.BackColor = System.Drawing.Color.Transparent;
            this.btn_PLaw.CausesValidation = false;
            this.btn_PLaw.FlatAppearance.BorderSize = 0;
            this.btn_PLaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PLaw.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PLaw.ForeColor = System.Drawing.Color.White;
            this.btn_PLaw.Image = ((System.Drawing.Image)(resources.GetObject("btn_PLaw.Image")));
            this.btn_PLaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PLaw.Location = new System.Drawing.Point(12, 225);
            this.btn_PLaw.Name = "btn_PLaw";
            this.btn_PLaw.Size = new System.Drawing.Size(94, 56);
            this.btn_PLaw.TabIndex = 7;
            this.btn_PLaw.Text = "PLaw";
            this.btn_PLaw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PLaw.UseVisualStyleBackColor = false;
            // 
            // picb_btnIndex
            // 
            this.picb_btnIndex.BackColor = System.Drawing.Color.Red;
            this.picb_btnIndex.Location = new System.Drawing.Point(2, 39);
            this.picb_btnIndex.Name = "picb_btnIndex";
            this.picb_btnIndex.Size = new System.Drawing.Size(10, 56);
            this.picb_btnIndex.TabIndex = 6;
            this.picb_btnIndex.TabStop = false;
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
            this.panel1.Controls.Add(this.picb_GLS);
            this.panel1.Controls.Add(this.btn_GLS);
            this.panel1.Controls.Add(this.picb_Bit);
            this.panel1.Controls.Add(this.btn_Tranformations);
            this.panel1.Controls.Add(this.picb_Loga);
            this.panel1.Controls.Add(this.btn_Histogram);
            this.panel1.Controls.Add(this.picb_PLaw);
            this.panel1.Controls.Add(this.btn_PLaw);
            this.panel1.Controls.Add(this.picb_btnIndex);
            this.panel1.Controls.Add(this.btn_Index);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 588);
            this.panel1.TabIndex = 9;
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
            this.pnl_Tranformations.Location = new System.Drawing.Point(106, 0);
            this.pnl_Tranformations.Name = "pnl_Tranformations";
            this.pnl_Tranformations.Size = new System.Drawing.Size(934, 588);
            this.pnl_Tranformations.TabIndex = 3;
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
            this.pnl_ContainerOptionTransformation.Size = new System.Drawing.Size(934, 47);
            this.pnl_ContainerOptionTransformation.TabIndex = 0;
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
            // btn_Power
            // 
            this.btn_Power.Location = new System.Drawing.Point(212, 7);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(78, 32);
            this.btn_Power.TabIndex = 1;
            this.btn_Power.Text = "Power";
            this.btn_Power.UseVisualStyleBackColor = true;
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
            // btn_BitPlaneSlicing
            // 
            this.btn_BitPlaneSlicing.Location = new System.Drawing.Point(310, 7);
            this.btn_BitPlaneSlicing.Name = "btn_BitPlaneSlicing";
            this.btn_BitPlaneSlicing.Size = new System.Drawing.Size(93, 32);
            this.btn_BitPlaneSlicing.TabIndex = 3;
            this.btn_BitPlaneSlicing.Text = "Bit Plane Slicing";
            this.btn_BitPlaneSlicing.UseVisualStyleBackColor = true;
            // 
            // btn_Gray_Level_Slicing
            // 
            this.btn_Gray_Level_Slicing.Location = new System.Drawing.Point(421, 7);
            this.btn_Gray_Level_Slicing.Name = "btn_Gray_Level_Slicing";
            this.btn_Gray_Level_Slicing.Size = new System.Drawing.Size(102, 32);
            this.btn_Gray_Level_Slicing.TabIndex = 4;
            this.btn_Gray_Level_Slicing.Text = "Gray Level Slicing";
            this.btn_Gray_Level_Slicing.UseVisualStyleBackColor = true;
            // 
            // pnl_ContainerFuncTranformations
            // 
            this.pnl_ContainerFuncTranformations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_ContainerFuncTranformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerFuncTranformations.Location = new System.Drawing.Point(0, 47);
            this.pnl_ContainerFuncTranformations.Name = "pnl_ContainerFuncTranformations";
            this.pnl_ContainerFuncTranformations.Size = new System.Drawing.Size(934, 541);
            this.pnl_ContainerFuncTranformations.TabIndex = 1;
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
            this.Controls.Add(this.pnl_Tranformations);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Index);
            this.Controls.Add(this.pnl_Histogram);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picb_GLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Bit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Loga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_PLaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_btnIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ShowImage)).EndInit();
            this.pnl_Index.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_Histogram.ResumeLayout(false);
            this.pnl_Tranformations.ResumeLayout(false);
            this.pnl_ContainerOptionTransformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox picb_GLS;
        private System.Windows.Forms.Button btn_GLS;
        private System.Windows.Forms.PictureBox picb_Bit;
        private System.Windows.Forms.Button btn_Tranformations;
        private System.Windows.Forms.PictureBox picb_Loga;
        private System.Windows.Forms.Button btn_Histogram;
        private System.Windows.Forms.PictureBox picb_PLaw;
        private System.Windows.Forms.Button btn_PLaw;
        private System.Windows.Forms.PictureBox picb_btnIndex;
        private System.Windows.Forms.Button btn_Index;
        private System.Windows.Forms.PictureBox picb_ShowImage;
        private System.Windows.Forms.Panel pnl_Index;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Histogram;
        private System.Windows.Forms.Panel pnl_Tranformations;
        private System.Windows.Forms.Button btn_ViewDemoHis;
        private UI.ViewHistogramDemo demoHistogram;
        private System.Windows.Forms.Panel pnl_ContainerOptionTransformation;
        private System.Windows.Forms.Panel pnl_ContainerFuncTranformations;
        private System.Windows.Forms.Button btn_Gray_Level_Slicing;
        private System.Windows.Forms.Button btn_BitPlaneSlicing;
        private System.Windows.Forms.Button btn_Logarithmic;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.Button btn_Negative;
    }
}