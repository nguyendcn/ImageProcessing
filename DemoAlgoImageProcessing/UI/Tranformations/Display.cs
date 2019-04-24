using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAlgoImageProcessing.Handing;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoAlgoImageProcessing.UI.Tranformations
{
    public partial class Display : UserControl
    {
        public List<string> list_param;
        public List<Bitmap> list_bm;

        public Display(List<string> list_param, List<Bitmap> list_bm)
        {
            InitializeComponent();

            this.list_bm = list_bm;
            this.list_param = list_param;
        }

        private void Logarithmic_Load(object sender, EventArgs e)
        {
            int index_BestImage = Histogram.GetBestImageUseHistogram(list_bm);
            foreach(Control ctr in this.tableLayoutPanel1.Controls)
            {
                if(ctr is Label)
                {
                    int id = Convert.ToInt32(ctr.Tag);
                    if (id == 0)
                    {
                        ctr.Text = "Original";
                    }
                    else
                    {
                        ctr.Text = "C: " + list_param[Convert.ToInt32(ctr.Tag)];
                    }

                    if (id == index_BestImage)
                    {
                        ctr.Text += "____This is best image.";
                    }
                }
                else if(ctr is PictureBox)
                {
                    PictureBox pcb = ctr as PictureBox;
                    int id = Convert.ToInt32(ctr.Tag);
                    pcb.Image = list_bm[id];
                }
                else if(ctr is System.Windows.Forms.DataVisualization.Charting.Chart)
                {
                    Chart chr = ctr as Chart;
                    int id = Convert.ToInt32(ctr.Tag);
                    list_bm[id].DisplayHistogarm(chr);
                }
            }
        }

        private void chr_1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_1.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, lbl_1.Text);
            frm_vhd.Show();
        }

        private void chr_Original_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_Original.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, "Original");
            frm_vhd.Show();
        }

        private void chr_2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_2.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, lbl_2.Text);
            frm_vhd.Show();
        }

        private void chr_3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_3.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, lbl_3.Text);
            frm_vhd.Show();
        }
    }
}
