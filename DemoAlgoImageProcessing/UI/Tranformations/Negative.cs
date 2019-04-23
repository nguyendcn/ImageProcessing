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

namespace DemoAlgoImageProcessing.UI.Tranformations
{
    public partial class Negative : UserControl
    {
        Bitmap bm_ori;
        public Negative()
        {
            InitializeComponent();

            if(ofd_OpenFile.ShowDialog() == DialogResult.OK)
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
            else if(ofd_OpenFile.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Warning", "Whent close this box you will be can't see the result. You can click to area left to try again.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
