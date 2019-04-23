using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Histogram_Click(object sender, EventArgs e)
        {
            this.demoHistogram.Visible = false;
        }

        private void btn_ViewDemoHis_Click(object sender, EventArgs e)
        {
            this.demoHistogram.Visible = true;
            this.demoHistogram.BringToFront();
        }

        private void demoHistogram_Load(object sender, EventArgs e)
        {

        }
    }
}
