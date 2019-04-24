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
    public partial class InputForLogarit : Form
    {
        public string c_1;
        public string c_2;
        public string c_3;
        public bool isCancel = true;

        public InputForLogarit()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.c_1 = txt_C1.Text;
            this.c_2 = txt_C2.Text;
            this.c_3 = txt_C3.Text;
            this.isCancel = false;

            this.Dispose();
            this.Close();
        }
    }
}
