using DemoAlgoImageProcessing.Handing;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing.UI.Tranformations
{
    public partial class Negative : UserControl
    {
        Bitmap bm_ori;
        public Negative()
        {
            InitializeComponent();
        }

        private void Negative_Load(object sender, EventArgs e)
        {
            if (ofd_OpenFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(this.ofd_OpenFile.FileName);
                bm_ori = (Bitmap)bm.Clone();
                bm_ori.RGB2GrayScale();
                picb_Origition.Image = bm_ori;

                //display histogram
                bm_ori.DisplayHistogarm(this.chr_Origition);

                //handing by Negative
                bm = Handing.Tranformations.Negative.GetResult(bm_ori);
                picb_Destination.Image = bm;
                bm.DisplayHistogarm(this.chr_Destination);
            }
            else if (ofd_OpenFile.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picb_Origition_Click(object sender, EventArgs e)
        {
            Negative_Load(sender, e);
        }

        private void chr_Origition_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_Origition.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, "Original");
            frm_vhd.Show();
        }

        private void chr_Destination_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_Destination.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, "Destination");
            frm_vhd.Show();
        }
    }
}
