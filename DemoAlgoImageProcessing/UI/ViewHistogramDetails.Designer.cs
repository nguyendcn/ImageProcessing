﻿namespace DemoAlgoImageProcessing.UI
{
    partial class ViewHistogramDetails
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chr_Histo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Histo)).BeginInit();
            this.SuspendLayout();
            // 
            // chr_Histo
            // 
            this.chr_Histo.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chr_Histo.ChartAreas.Add(chartArea1);
            this.chr_Histo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chr_Histo.Legends.Add(legend1);
            this.chr_Histo.Location = new System.Drawing.Point(0, 0);
            this.chr_Histo.Name = "chr_Histo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr_Histo.Series.Add(series1);
            this.chr_Histo.Size = new System.Drawing.Size(434, 261);
            this.chr_Histo.TabIndex = 0;
            this.chr_Histo.Text = "chart1";
            // 
            // ViewHistogramDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.chr_Histo);
            this.Name = "ViewHistogramDetails";
            this.Text = "ViewHistogramDetails";
            ((System.ComponentModel.ISupportInitialize)(this.chr_Histo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Histo;
    }
}