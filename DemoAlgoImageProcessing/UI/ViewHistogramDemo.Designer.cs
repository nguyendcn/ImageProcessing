namespace DemoAlgoImageProcessing.UI
{
    partial class ViewHistogramDemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pic_Original = new System.Windows.Forms.PictureBox();
            this.chr_HisOri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picb_Destination = new System.Windows.Forms.PictureBox();
            this.chr_HisDis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_EquaHisto = new System.Windows.Forms.Button();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_HisOri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_HisDis)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Original
            // 
            this.pic_Original.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_Original.Location = new System.Drawing.Point(0, 0);
            this.pic_Original.Name = "pic_Original";
            this.pic_Original.Size = new System.Drawing.Size(357, 357);
            this.pic_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Original.TabIndex = 0;
            this.pic_Original.TabStop = false;
            // 
            // chr_HisOri
            // 
            chartArea3.Name = "ChartArea1";
            this.chr_HisOri.ChartAreas.Add(chartArea3);
            this.chr_HisOri.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Name = "Legend1";
            this.chr_HisOri.Legends.Add(legend3);
            this.chr_HisOri.Location = new System.Drawing.Point(0, 366);
            this.chr_HisOri.Name = "chr_HisOri";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chr_HisOri.Series.Add(series3);
            this.chr_HisOri.Size = new System.Drawing.Size(357, 226);
            this.chr_HisOri.TabIndex = 1;
            this.chr_HisOri.Text = "chart1";
            // 
            // picb_Destination
            // 
            this.picb_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.picb_Destination.Location = new System.Drawing.Point(0, 0);
            this.picb_Destination.Name = "picb_Destination";
            this.picb_Destination.Size = new System.Drawing.Size(348, 357);
            this.picb_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_Destination.TabIndex = 2;
            this.picb_Destination.TabStop = false;
            // 
            // chr_HisDis
            // 
            chartArea4.Name = "ChartArea1";
            this.chr_HisDis.ChartAreas.Add(chartArea4);
            this.chr_HisDis.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.chr_HisDis.Legends.Add(legend4);
            this.chr_HisDis.Location = new System.Drawing.Point(0, 366);
            this.chr_HisDis.Name = "chr_HisDis";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chr_HisDis.Series.Add(series4);
            this.chr_HisDis.Size = new System.Drawing.Size(348, 226);
            this.chr_HisDis.TabIndex = 3;
            this.chr_HisDis.Text = "chart2";
            // 
            // btn_EquaHisto
            // 
            this.btn_EquaHisto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EquaHisto.Location = new System.Drawing.Point(0, 0);
            this.btn_EquaHisto.Name = "btn_EquaHisto";
            this.btn_EquaHisto.Size = new System.Drawing.Size(107, 42);
            this.btn_EquaHisto.TabIndex = 4;
            this.btn_EquaHisto.Text = "Equal His";
            this.btn_EquaHisto.UseVisualStyleBackColor = true;
            this.btn_EquaHisto.Click += new System.EventHandler(this.btn_EquaHisto_Click);
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddImage.Location = new System.Drawing.Point(0, 235);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(107, 42);
            this.btn_AddImage.TabIndex = 5;
            this.btn_AddImage.Text = "Add Image";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.Btn_AddImage_Click);
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "Choose Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chr_HisOri);
            this.panel1.Controls.Add(this.pic_Original);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 592);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chr_HisDis);
            this.panel2.Controls.Add(this.picb_Destination);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(464, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 592);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_AddImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(357, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 277);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_EquaHisto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(357, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 277);
            this.panel4.TabIndex = 8;
            // 
            // ViewHistogramDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewHistogramDemo";
            this.Size = new System.Drawing.Size(812, 592);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_HisOri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_HisDis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_HisOri;
        private System.Windows.Forms.PictureBox picb_Destination;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_HisDis;
        private System.Windows.Forms.Button btn_EquaHisto;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
