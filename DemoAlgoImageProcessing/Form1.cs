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

        private void btn_Negative_Click(object sender, EventArgs e)
        {
            //Check is exists
            bool isExist = false;
            foreach(Control ctr in this.pnl_ContainerFuncTranformations.Controls)
            {
                if(ctr is UI.Tranformations.Negative)
                {
                    ctr.Visible = true;
                    ctr.BringToFront();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                UI.Tranformations.Negative negative = new UI.Tranformations.Negative();
                negative.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncTranformations.Controls.Add(negative);
            }
        }

        private void Btn_Logarithmic_Click(object sender, EventArgs e)
        {
            //Check is exists
            bool isExist = false;
            foreach (Control ctr in this.pnl_ContainerFuncTranformations.Controls)
            {
                if (ctr is UI.Tranformations.Logarithmic.Logarithmics)
                {
                    ctr.Visible = true;
                    ctr.BringToFront();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                UI.Tranformations.Logarithmic.Logarithmics logarithmics = new UI.Tranformations.Logarithmic.Logarithmics();
                logarithmics.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncTranformations.Controls.Add(logarithmics);
            }
        }
    }
}
