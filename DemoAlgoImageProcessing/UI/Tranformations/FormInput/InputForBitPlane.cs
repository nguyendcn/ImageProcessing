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
    public partial class InputForBitPlane : Form
    {
        public bool isCancel = true;
        public string lvl_1;
        public string lvl_2;
        public string lvl_3;

        public InputForBitPlane()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            lvl_1 = txt_lvl1.Text;
            lvl_2 = txt_lvl2.Text;
            lvl_3 = txt_lvl3.Text;
            isCancel = false;

            this.Dispose();
            this.Close();
        }
    }
}
