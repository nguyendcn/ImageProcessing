using DemoAlgoImageProcessing.Handing;
using DemoAlgoImageProcessing.Handing.SpatialFilter;
using DemoAlgoImageProcessing.Handing.SpatialFilter.Type;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing.UI.SpatialFilter
{
    public partial class Display : UserControl
    {
        //handing type current 
        public Define modeCurrent;
        public Bitmap bm_ori = null;
        public Bitmap bm_des;

        public Display(Bitmap bm, Define mode)
        {
            InitializeComponent();

            this.bm_ori = bm;
            this.modeCurrent = mode;
            if(bm_ori != null)
            {
                this.picb_Original.Image = this.bm_ori;
                //Display histogram for original image
                ((Bitmap)bm_ori.Clone()).DisplayHistogarm(this.chr_Ori);
            }

            this.cmb_Matrix.Items.Add("3x3");
            this.cmb_Matrix.Items.Add("5x5");
            this.cmb_Matrix.Items.Add("9x9");
            this.cmb_Matrix.SelectedIndex = 0;

            this.cmb_Border.Items.Add("Replicate Border");
            this.cmb_Border.Items.Add("Wrap Color");
            this.cmb_Border.SelectedIndex = 0;

            if(this.modeCurrent == Define.AvgWeight)
            {
                this.cmb_Matrix.Enabled = false;
            }
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Matrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rehanding with new option border type
            HandingByModeFilter(this.modeCurrent);

            ShowResult();
        }

        private void cmb_Border_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rehanding with new option border type
            HandingByModeFilter(this.modeCurrent);

            ShowResult();
        }

        /// <summary>
        /// Display image handed and histogram of this.
        /// </summary>
        private void ShowResult()
        {
            if (this.bm_des != null)
            {
                foreach (var series in this.chr_Des.Series)
                {
                    series.Points.Clear();
                }
                this.picb_Destination.Image = this.bm_des;
                ((Bitmap)this.bm_des.Clone()).DisplayHistogarm(this.chr_Des);
            }
        }

        private void HandingByModeFilter(Define mode)
        {
            //Rehanding with new option matrix
            if (this.modeCurrent == Define.Min)
            {
                this.bm_des = Handing.SpatialFilter.Min.GetResult(bm_ori, (Bitmap)bm_ori.Clone(),
                            (Matrix)((cmb_Matrix.SelectedIndex + 3) + (int)Math.Pow(cmb_Matrix.SelectedIndex, 2)),
                            (Replicate)cmb_Border.SelectedIndex);
            }
            else if (this.modeCurrent == Define.Max)
            {
                this.bm_des = Handing.SpatialFilter.Max.GetResult(bm_ori, (Bitmap)bm_ori.Clone(),
                            (Matrix)((cmb_Matrix.SelectedIndex + 3) + (int)Math.Pow(cmb_Matrix.SelectedIndex, 2)),
                            (Replicate)cmb_Border.SelectedIndex);
            }
            else if(this.modeCurrent == Define.Median)
            {
                this.bm_des = Handing.SpatialFilter.Median.GetResult(bm_ori, (Bitmap)bm_ori.Clone(),
                            (Matrix)((cmb_Matrix.SelectedIndex + 3) + (int)Math.Pow(cmb_Matrix.SelectedIndex, 2)),
                            (Replicate)cmb_Border.SelectedIndex);
            }
            else if(this.modeCurrent == Define.Average)
            {
                this.bm_des = Handing.SpatialFilter.Average.GetResult(bm_ori, (Bitmap)bm_ori.Clone(),
                            (Matrix)((cmb_Matrix.SelectedIndex + 3) + (int)Math.Pow(cmb_Matrix.SelectedIndex, 2)),
                            (Replicate)cmb_Border.SelectedIndex);
            }
            else if(this.modeCurrent == Define.AvgWeight)
            {
                this.bm_des = Handing.SpatialFilter.AvgWeight.GetResult(bm_ori, (Bitmap)bm_ori.Clone(),
                            (Matrix)((cmb_Matrix.SelectedIndex + 3) + (int)Math.Pow(cmb_Matrix.SelectedIndex, 2)),
                            (Replicate)cmb_Border.SelectedIndex);
            }
        }
    }
}

