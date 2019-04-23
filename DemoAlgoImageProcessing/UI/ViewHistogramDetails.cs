using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoAlgoImageProcessing.UI
{
    public partial class ViewHistogramDetails : Form
    {
        public ViewHistogramDetails(System.Windows.Forms.DataVisualization.Charting.SeriesCollection chrt, string title)
        {
            InitializeComponent();
            this.Text = title;
            this.chr_Histo.Series.Clear();
            for (int s_item = 0; s_item < chrt.Count; s_item++)
            {
                this.chr_Histo.Series.Add(chrt[s_item]);
            }
        }
    }
}
