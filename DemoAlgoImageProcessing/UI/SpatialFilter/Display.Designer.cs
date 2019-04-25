namespace DemoAlgoImageProcessing.UI.SpatialFilter
{
    partial class Display
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picb_Original = new System.Windows.Forms.PictureBox();
            this.picb_Destination = new System.Windows.Forms.PictureBox();
            this.chr_Ori = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chr_Des = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Border = new System.Windows.Forms.ComboBox();
            this.cmb_Matrix = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Ori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Des)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picb_Original, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picb_Destination, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chr_Ori, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chr_Des, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.02637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.97363F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picb_Original
            // 
            this.picb_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_Original.Location = new System.Drawing.Point(3, 3);
            this.picb_Original.Name = "picb_Original";
            this.picb_Original.Size = new System.Drawing.Size(341, 285);
            this.picb_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_Original.TabIndex = 0;
            this.picb_Original.TabStop = false;
            // 
            // picb_Destination
            // 
            this.picb_Destination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_Destination.Location = new System.Drawing.Point(439, 3);
            this.picb_Destination.Name = "picb_Destination";
            this.picb_Destination.Size = new System.Drawing.Size(342, 285);
            this.picb_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_Destination.TabIndex = 1;
            this.picb_Destination.TabStop = false;
            // 
            // chr_Ori
            // 
            chartArea1.Name = "ChartArea1";
            this.chr_Ori.ChartAreas.Add(chartArea1);
            this.chr_Ori.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chr_Ori.Legends.Add(legend1);
            this.chr_Ori.Location = new System.Drawing.Point(3, 294);
            this.chr_Ori.Name = "chr_Ori";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr_Ori.Series.Add(series1);
            this.chr_Ori.Size = new System.Drawing.Size(341, 196);
            this.chr_Ori.TabIndex = 2;
            this.chr_Ori.Text = "chart1";
            // 
            // chr_Des
            // 
            chartArea2.Name = "ChartArea1";
            this.chr_Des.ChartAreas.Add(chartArea2);
            this.chr_Des.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chr_Des.Legends.Add(legend2);
            this.chr_Des.Location = new System.Drawing.Point(439, 294);
            this.chr_Des.Name = "chr_Des";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chr_Des.Series.Add(series2);
            this.chr_Des.Size = new System.Drawing.Size(342, 196);
            this.chr_Des.TabIndex = 3;
            this.chr_Des.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_Border);
            this.panel1.Controls.Add(this.cmb_Matrix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(350, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 285);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Border";
            // 
            // cmb_Border
            // 
            this.cmb_Border.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Border.FormattingEnabled = true;
            this.cmb_Border.Location = new System.Drawing.Point(0, 187);
            this.cmb_Border.Name = "cmb_Border";
            this.cmb_Border.Size = new System.Drawing.Size(83, 23);
            this.cmb_Border.TabIndex = 1;
            this.cmb_Border.SelectedIndexChanged += new System.EventHandler(this.cmb_Border_SelectedIndexChanged);
            // 
            // cmb_Matrix
            // 
            this.cmb_Matrix.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Matrix.FormattingEnabled = true;
            this.cmb_Matrix.Location = new System.Drawing.Point(0, 102);
            this.cmb_Matrix.Name = "cmb_Matrix";
            this.cmb_Matrix.Size = new System.Drawing.Size(83, 23);
            this.cmb_Matrix.TabIndex = 0;
            this.cmb_Matrix.SelectedIndexChanged += new System.EventHandler(this.cmb_Matrix_SelectedIndexChanged);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(784, 493);
            this.Load += new System.EventHandler(this.Display_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Ori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Des)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picb_Original;
        private System.Windows.Forms.PictureBox picb_Destination;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Ori;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Des;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Border;
        private System.Windows.Forms.ComboBox cmb_Matrix;
    }
}
