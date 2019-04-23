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
                
                //handing by Logarit
                
            }
            else if(dr == DialogResult.Cancel)
            {
                MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
    }
}
