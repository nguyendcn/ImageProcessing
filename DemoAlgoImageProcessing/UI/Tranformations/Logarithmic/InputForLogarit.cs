using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing.UI.Tranformations.Logarithmic
{
    public partial class InputForLogarit : Form
    {
        public int c_1;
        public int c_2;
        public int c_3;
        public bool isCancel = true;

        public InputForLogarit()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.c_1 = Convert.ToInt32(txt_C1.Text);
            this.c_2 = Convert.ToInt32(txt_C2.Text);
            this.c_3 = Convert.ToInt32(txt_C3.Text);
            this.isCancel = false;

            this.Dispose();
            this.Close();
        }
    }
}
