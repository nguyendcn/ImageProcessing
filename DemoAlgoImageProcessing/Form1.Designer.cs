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
            this.btn_Bit = new System.Windows.Forms.Button();
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
            this.demoHistogram = new UI.ViewHistogramDemo();
            ((System.ComponentModel.ISupportInitialize)(this.picb_GLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Bit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Loga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_PLaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_btnIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ShowImage)).BeginInit();
            this.pnl_Index.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Histogram.SuspendLayout();
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
            // btn_Bit
            // 
            this.btn_Bit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bit.CausesValidation = false;
            this.btn_Bit.FlatAppearance.BorderSize = 0;
            this.btn_Bit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bit.ForeColor = System.Drawing.Color.White;
            this.btn_Bit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bit.Image")));
            this.btn_Bit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bit.Location = new System.Drawing.Point(12, 163);
            this.btn_Bit.Name = "btn_Bit";
            this.btn_Bit.Size = new System.Drawing.Size(94, 56);
            this.btn_Bit.TabIndex = 11;
            this.btn_Bit.Text = "Bit";
            this.btn_Bit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Bit.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.btn_Bit);
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
            // demoHistogram
            //
            this.demoHistogram.Location = new System.Drawing.Point(0, 0);
            this.demoHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // pnl_Histogram
            // 
            this.pnl_Histogram.Controls.Add(this.demoHistogram);
            this.pnl_Histogram.Controls.Add(this.btn_ViewDemoHis);
            this.pnl_Histogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Histogram.Location = new System.Drawing.Point(106, 0);
            this.pnl_Histogram.Name = "pnl_Histogram";
            this.pnl_Histogram.Size = new System.Drawing.Size(934, 588);
            this.pnl_Histogram.TabIndex = 3;
            // 
            // btn_ViewDemoHis
            // 
            this.btn_ViewDemoHis.Location = new System.Drawing.Point(349, 418);
            this.btn_ViewDemoHis.Name = "btn_ViewDemoHis";
            this.btn_ViewDemoHis.Size = new System.Drawing.Size(84, 48);
            this.btn_ViewDemoHis.TabIndex = 0;
            this.btn_ViewDemoHis.Text = "View Demo";
            this.btn_ViewDemoHis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 588);
            this.Controls.Add(this.pnl_Histogram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Index);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox picb_GLS;
        private System.Windows.Forms.Button btn_GLS;
        private System.Windows.Forms.PictureBox picb_Bit;
        private System.Windows.Forms.Button btn_Bit;
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
        private System.Windows.Forms.Button btn_ViewDemoHis;
        private UI.ViewHistogramDemo demoHistogram;
    }
}