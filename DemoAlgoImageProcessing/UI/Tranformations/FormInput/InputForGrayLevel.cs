using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing.UI.Tranformations.FormInput
{
    public partial class InputForGrayLevel : Form
    {
        public bool isCancel = true;
        public string img_1;
        public string img_2;
        public string img_3;

        public InputForGrayLevel()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            img_1 = txt_Img1T1.Text + ", " + txt_Img1T2.Text;
            img_2 = txt_Img2T1.Text + ", " + txt_Img2T2.Text;
            img_3 = txt_Img3T1.Text + ", " + txt_Img3T2.Text;
            isCancel = false;

            this.Dispose();
            this.Close();
        }
    }
}
