using DemoAlgoImageProcessing.Handing;
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
                if (ctr.Tag.Equals("Logarithmic"))
                {
                    ctr.Visible = true;
                    ctr.BringToFront();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                List<string> list_c;
                List<Bitmap> list_bm = new List<Bitmap>();

                DialogResult dialogResult = ofd_OpenFile.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    //Get input c
                    list_c = Handing.Tranformations.Logarithmic.EnterInput();

                    //Get image original
                    Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                    bm_temp.RGB2GrayScale();
                    list_bm.Add(bm_temp);

                    //Add more image to process
                    for(int index = 0; index < list_c.Count; index++)
                    {
                        list_bm.Add((Bitmap)list_bm[0].Clone());
                    }

                    //Handing
                    for(int index = 0; index < list_c.Count; index++)
                    {
                        Handing.Tranformations.Logarithmic.Getresult(list_bm[index + 1], int.Parse(list_c[index]));
                    }

                    list_c.Insert(0, "");

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_c, list_bm);
                    dis.Tag = "Logarithmic";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private bool TransIsExists(object tagName)
        {
            foreach (Control ctr in this.pnl_ContainerFuncTranformations.Controls)
            {
                if (ctr.Tag.Equals(tagName))
                {
                    ctr.Visible = true;
                    ctr.BringToFront();
                    return true;
                }
            }
            return false;
        }
        private void btn_Power_Click(object sender, EventArgs e)
        {
            if(TransIsExists("Power"))
            {

            }
            else
            {
                List<string> list_clamda;
                List<Bitmap> list_bm = new List<Bitmap>();

                DialogResult dialogResult = ofd_OpenFile.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    //Get input c
                    list_clamda = Handing.Tranformations.Power.EnterInput();

                    //Get image original
                    Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                    bm_temp.RGB2GrayScale();
                    list_bm.Add(bm_temp);

                    //Add more image to process
                    for (int index = 0; index < list_clamda.Count; index++)
                    {
                        list_bm.Add((Bitmap)list_bm[0].Clone());
                    }

                    //Handing
                    for (int index = 0; index < list_clamda.Count; index++)
                    {
                        string[] arr = list_clamda[index].Split(',');
                        Handing.Tranformations.Power.PowerLaw(list_bm[index + 1], double.Parse(arr[1]), int.Parse(arr[0]));
                    }

                    list_clamda.Insert(0, "");

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_clamda, list_bm);
                    dis.Tag = "Power";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
           
        }
    }
}
