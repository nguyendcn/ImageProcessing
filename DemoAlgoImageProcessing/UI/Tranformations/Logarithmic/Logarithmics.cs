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

namespace DemoAlgoImageProcessing.UI.Tranformations.Logarithmic
{
    public partial class Logarithmics : UserControl
    {
        private int c_1;
        private int c_2;
        private int c_3;

        public Logarithmics()
        {
            InitializeComponent();
        }

        Bitmap bm_ori;
        private void Logarithmic_Load(object sender, EventArgs e)
        {
            DialogResult dr = ofd_OpenFile.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(this.ofd_OpenFile.FileName);
                bm_ori = (Bitmap)bm.Clone();
                bm_ori.RGB2GrayScale();
                picb_Original.Image = bm_ori;

                //display histogram
                bm_ori.DisplayHistogarm(this.chr_Original);

                //Get c value from form.
                InputForLogarit inputForLogarit = new InputForLogarit();
                inputForLogarit.ShowDialog();

                if(inputForLogarit.isCancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<int> list_c = new List<int> { inputForLogarit.c_1, inputForLogarit.c_2, inputForLogarit.c_3 };
                List<Bitmap> list_bm = new List<Bitmap> { (Bitmap)this.bm_ori.Clone(), (Bitmap)this.bm_ori.Clone(), (Bitmap)this.bm_ori.Clone() };
                int index_ImageBest = -1;

                for(int index = 0; index < list_c.Count; index++)
                {
                    Handing.Tranformations.Logarithmic.Getresult(list_bm[index], list_c[index]);
                }

                index_ImageBest = Handing.Histogram.GetBestImageUseHistogram(list_bm);

                this.picb_1.Image = list_bm[0];
                this.picb_2.Image = list_bm[1];
                this.picb_3.Image = list_bm[2];

                this.lbl_1.Text = "C: " + list_c[0];
                this.lbl_2.Text = "C: " + list_c[1];
                this.lbl_3.Text = "C: " + list_c[2];

                if(index_ImageBest == 0)
                {
                    lbl_1.Text += "__This is the best image.";
                }
                else if (index_ImageBest == 1)
                {
                    lbl_2.Text += "__This is the best image.";
                }
                else if (index_ImageBest == 2)
                {
                    lbl_3.Text += "__This is the best image.";
                }

                //Display histogram
                list_bm[0].DisplayHistogarm(this.chr_1);
                list_bm[1].DisplayHistogarm(this.chr_2);
                list_bm[2].DisplayHistogarm(this.chr_3);

            }
            else if(dr == DialogResult.Cancel)
            {
                MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
