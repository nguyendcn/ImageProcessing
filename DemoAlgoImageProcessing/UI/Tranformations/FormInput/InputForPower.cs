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
    public partial class InputForPower : Form
    {
        public InputForPower()
        {
            InitializeComponent();
        }

        public bool isCancel = true;
        public string image_1;
        public string image_2;
        public string image_3;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.image_1 = txt_C1.Text + ", " + txt_L1.Text;
            this.image_2 = txt_C2.Text + ", " + txt_L2.Text;
            this.image_3 = txt_C3.Text + ", " + txt_L3.Text;
            this.isCancel = false;

            this.Dispose();
            this.Close();
        }
    }
}
