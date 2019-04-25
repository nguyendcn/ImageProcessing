using DemoAlgoImageProcessing.Handing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HideFunc()
        {
            this.pnl_Histogram.Visible = false;
            this.pnl_Index.Visible = false;
            this.pnl_Tranformations.Visible = false;

            this.picb_Index.BackColor = this.picb_Histo.BackColor = this.picb_Tranf.BackColor = Color.Transparent;
            this.btn_Index.BackColor = this.btn_Histogram.BackColor = this.btn_Tranformations.BackColor = Color.Transparent;
        }


        private void btn_Index_Click(object sender, EventArgs e)
        {
            HideFunc();
            this.pnl_Index.Visible = true;
            this.pnl_Index.BringToFront();

            this.picb_Index.BackColor = Color.Red;
            //this.btn_Index.BackColor = Color.White;
        }

        private void btn_Histogram_Click(object sender, EventArgs e)
        {
            HideFunc();
            this.demoHistogram.Visible = false;
            this.pnl_Histogram.Visible = true;
            this.pnl_Histogram.BringToFront();

            this.picb_Histo.BackColor = Color.Red;
           // this.btn_Histogram.BackColor = Color.White;
        }

        private void btn_Tranformations_Click(object sender, EventArgs e)
        {
            HideFunc();
            this.pnl_Tranformations.Visible = true;
            this.pnl_Tranformations.BringToFront();

            this.picb_Tranf.BackColor = Color.Red;
            //this.btn_Tranformations.BackColor = Color.White;
        }

        private void btn_ViewDemoHis_Click(object sender, EventArgs e)
        {
            this.demoHistogram.Visible = true;
            this.demoHistogram.Dock = DockStyle.Fill;
            this.demoHistogram.BringToFront();
        }

        

        private void demoHistogram_Load(object sender, EventArgs e)
        {

        }

        private void btn_Negative_Click(object sender, EventArgs e)
        {
            //Check is exists
            bool isExist = false;
            foreach (Control ctr in this.pnl_ContainerFuncTranformations.Controls)
            {
                if (ctr is UI.Tranformations.Negative)
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
                negative.BringToFront();
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
                if (dialogResult == DialogResult.OK)
                {
                    //Get input c
                    list_c = Handing.Tranformations.Logarithmic.EnterInput();

                    //Get image original
                    Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                    bm_temp.RGB2GrayScale();
                    list_bm.Add(bm_temp);

                    //Add more image to process
                    for (int index = 0; index < list_c.Count; index++)
                    {
                        list_bm.Add((Bitmap)list_bm[0].Clone());
                    }

                    //Handing
                    for (int index = 0; index < list_c.Count; index++)
                    {
                        Handing.Tranformations.Logarithmic.Getresult(list_bm[index + 1], int.Parse(list_c[index]));
                    }

                    list_c.Insert(0, string.Empty);

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_c, list_bm);
                    dis.Tag = "Logarithmic";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                    dis.BringToFront();
                }
                else if (dialogResult == DialogResult.Cancel)
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
            if (TransIsExists("Power"))
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

                    list_clamda.Insert(0, string.Empty);

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_clamda, list_bm);
                    dis.Tag = "Power";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                    dis.BringToFront();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btn_BitPlaneSlicing_Click(object sender, EventArgs e)
        {
            if (TransIsExists("BitPlane"))
            {

            }
            else
            {
                List<string> list_level;
                List<Bitmap> list_bm = new List<Bitmap>();

                DialogResult dialogResult = ofd_OpenFile.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    //Get input level
                    list_level = Handing.Tranformations.BitPlaneSlicing.EnterInput();

                    //Get image original
                    Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                    bm_temp.RGB2GrayScale();
                    list_bm.Add(bm_temp);

                    //Add more image to process
                    for (int index = 0; index < list_level.Count; index++)
                    {
                        list_bm.Add((Bitmap)list_bm[0].Clone());
                    }

                    //Handing
                    for (int index = 0; index < list_level.Count; index++)
                    {
                        Handing.Tranformations.BitPlaneSlicing.GetResult(list_bm[index + 1], int.Parse(list_level[index]));
                    }

                    list_level.Insert(0, string.Empty);

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_level, list_bm);
                    dis.Tag = "BitPlane";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                    dis.BringToFront();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btn_Gray_Level_Slicing_Click(object sender, EventArgs e)
        {
            if (TransIsExists("GrayLevel"))
            {

            }
            else
            {
                List<string> list_tf_tl;
                List<Bitmap> list_bm = new List<Bitmap>();

                DialogResult dialogResult = ofd_OpenFile.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    //Get input c
                    list_tf_tl = Handing.Tranformations.GrayLevel.EnterInput();

                    //Get image original
                    Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                    bm_temp.RGB2GrayScale();
                    list_bm.Add(bm_temp);

                    //Add more image to process
                    for (int index = 0; index < list_tf_tl.Count; index++)
                    {
                        list_bm.Add((Bitmap)list_bm[0].Clone());
                    }

                    //Handing
                    for (int index = 0; index < list_tf_tl.Count; index++)
                    {
                        string[] arr = list_tf_tl[index].Split(',');
                        Handing.Tranformations.GrayLevel.GrayLevelSlicing(list_bm[index + 1], int.Parse(arr[0]), int.Parse(arr[1]));
                    }

                    list_tf_tl.Insert(0, string.Empty);

                    //init control to display
                    UI.Tranformations.Display dis = new UI.Tranformations.Display(list_tf_tl, list_bm);
                    dis.Tag = "GrayLevel";
                    dis.Dock = DockStyle.Fill;
                    this.pnl_ContainerFuncTranformations.Controls.Add(dis);
                    dis.BringToFront();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Whent close this box you will be can't see the result. You can click to area left to try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btn_Spatial_Click(object sender, EventArgs e)
        {
            this.pnl_SpatialFilter.BringToFront();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            //Check is exist

            //not exist
            DialogResult dr = this.ofd_OpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                bm_temp.RGB2GrayScale();

                UI.SpatialFilter.Display display = new UI.SpatialFilter.Display(bm_temp, Handing.SpatialFilter.Define.Min);
                display.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncSpatial.Controls.Add(display);
                display.BringToFront();
            }
            
        }

        private void btn_MaxFilter_Click(object sender, EventArgs e)
        {
            //Check is exist

            //not exist
            DialogResult dr = this.ofd_OpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                bm_temp.RGB2GrayScale();

                UI.SpatialFilter.Display display = new UI.SpatialFilter.Display(bm_temp, Handing.SpatialFilter.Define.Max);
                display.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncSpatial.Controls.Add(display);
                display.BringToFront();
            }
        }

        private void btn_MedianFilter_Click(object sender, EventArgs e)
        {
            //Check is exist

            //not exist
            DialogResult dr = this.ofd_OpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                bm_temp.RGB2GrayScale();

                UI.SpatialFilter.Display display = new UI.SpatialFilter.Display(bm_temp, Handing.SpatialFilter.Define.Median);
                display.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncSpatial.Controls.Add(display);
                display.BringToFront();
            }
        }

        private void btn_AverageFilter_Click(object sender, EventArgs e)
        {
            //Check is exist

            //not exist
            DialogResult dr = this.ofd_OpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                bm_temp.RGB2GrayScale();

                UI.SpatialFilter.Display display = new UI.SpatialFilter.Display(bm_temp, Handing.SpatialFilter.Define.Average);
                display.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncSpatial.Controls.Add(display);
                display.BringToFront();
            }
        }

        private void btn_AvgWeight_Click(object sender, EventArgs e)
        {
            //Check is exist

            //not exist
            DialogResult dr = this.ofd_OpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap bm_temp = new Bitmap(ofd_OpenFile.FileName);
                bm_temp.RGB2GrayScale();

                UI.SpatialFilter.Display display = new UI.SpatialFilter.Display(bm_temp, Handing.SpatialFilter.Define.AvgWeight);
                display.Dock = DockStyle.Fill;
                this.pnl_ContainerFuncSpatial.Controls.Add(display);
                display.BringToFront();
            }
        }
    }
}
