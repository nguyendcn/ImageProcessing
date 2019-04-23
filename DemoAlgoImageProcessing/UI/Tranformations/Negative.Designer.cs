namespace DemoAlgoImageProcessing.UI.Tranformations
{
    partial class Negative
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picb_Origition = new System.Windows.Forms.PictureBox();
            this.picb_Destination = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chr_Origition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chr_Destination = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Origition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Origition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Destination)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 192);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 378);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picb_Origition);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picb_Destination);
            this.splitContainer1.Size = new System.Drawing.Size(700, 378);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // picb_Origition
            // 
            this.picb_Origition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_Origition.Location = new System.Drawing.Point(0, 0);
            this.picb_Origition.Name = "picb_Origition";
            this.picb_Origition.Size = new System.Drawing.Size(340, 378);
            this.picb_Origition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_Origition.TabIndex = 0;
            this.picb_Origition.TabStop = false;
            // 
            // picb_Destination
            // 
            this.picb_Destination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_Destination.Location = new System.Drawing.Point(0, 0);
            this.picb_Destination.Name = "picb_Destination";
            this.picb_Destination.Size = new System.Drawing.Size(356, 378);
            this.picb_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_Destination.TabIndex = 1;
            this.picb_Destination.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 192);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chr_Origition);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chr_Destination);
            this.splitContainer2.Size = new System.Drawing.Size(697, 192);
            this.splitContainer2.SplitterDistance = 338;
            this.splitContainer2.TabIndex = 1;
            // 
            // chr_Origition
            // 
            chartArea1.Name = "ChartArea1";
            this.chr_Origition.ChartAreas.Add(chartArea1);
            this.chr_Origition.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chr_Origition.Legends.Add(legend1);
            this.chr_Origition.Location = new System.Drawing.Point(0, 0);
            this.chr_Origition.Name = "chr_Origition";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr_Origition.Series.Add(series1);
            this.chr_Origition.Size = new System.Drawing.Size(338, 192);
            this.chr_Origition.TabIndex = 0;
            this.chr_Origition.Text = "chart1";
            // 
            // chr_Destination
            // 
            chartArea2.Name = "ChartArea1";
            this.chr_Destination.ChartAreas.Add(chartArea2);
            this.chr_Destination.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chr_Destination.Legends.Add(legend2);
            this.chr_Destination.Location = new System.Drawing.Point(0, 0);
            this.chr_Destination.Name = "chr_Destination";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chr_Destination.Series.Add(series2);
            this.chr_Destination.Size = new System.Drawing.Size(355, 192);
            this.chr_Destination.TabIndex = 1;
            this.chr_Destination.Text = "chart2";
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "openFileDialog1";
            // 
            // Negative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Negative";
            this.Size = new System.Drawing.Size(700, 570);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_Origition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chr_Origition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Destination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Origition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Destination;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picb_Origition;
        private System.Windows.Forms.PictureBox picb_Destination;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
    }
}
