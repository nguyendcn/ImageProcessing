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

namespace DemoAlgoImageProcessing.UI
{
    public partial class ViewHistogramDemo : UserControl
    {
        public ViewHistogramDemo()
        {
            InitializeComponent();
        }

        private Bitmap bm_ori = null;

        private void Btn_AddImage_Click(object sender, EventArgs e)
        {
            if(ofd_OpenFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(this.ofd_OpenFile.FileName);
                bm_ori = (Bitmap)bm.Clone();
                bm_ori.RGB2GrayScale();
                pic_Original.Image = bm_ori;

                //display histogram
                bm.DisplayHistogarm(this.chr_HisOri);
            }
        }

        private void btn_EquaHisto_Click(object sender, EventArgs e)
        {
            if(this.bm_ori != null)
            {
                Bitmap bm_cl = (Bitmap)bm_ori.Clone();
                bm_cl.Equalization();
                bm_cl.DisplayHistogarm(this.chr_HisDis);
                this.picb_Destination.Image = bm_cl;
            }
        }

        private void chr_HisOri_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesCollection sc = this.chr_HisOri.Series;
            if (sc == null)
                return;
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(sc, "Haha");
            frm_vhd.Show();
        }

        private void chr_HisDis_Click(object sender, EventArgs e)
        {
            ViewHistogramDetails frm_vhd = new ViewHistogramDetails(this.chr_HisDis.Series, "Hahadsafs");
            frm_vhd.Show();
        }
    }
}
