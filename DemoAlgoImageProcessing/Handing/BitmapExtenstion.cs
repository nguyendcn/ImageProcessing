using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoAlgoImageProcessing.Handing
{
    public static class BitmapExtenstion
    {
        /// <summary>
        /// Convert image RGB to image grey.
        /// </summary>
        /// <param name="image">Image need convert.</param>
        unsafe
        public static void RGB2GrayScale(this Bitmap image)
        {

            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            //(RGB)(RGB)(RGB)(RGB)...
            int padding = bitmapData.Stride - image.Width * 3;
            //Đưa con trỏ về pixel đầu tiên
            byte* p = (byte*)bitmapData.Scan0;
            // Duyệt pixel chuyển RGB->Grayscale
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    // Công thức RGB->Grayscale
                    //double t = p[0] * 0.299 + p[1] * 0.587 + p[2] * 0.114;
                    double t = (p[0] + p[1] + p[2]) / 3;
                    // Gán cho 3 màu RGB
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    // Nhảy
                    p += 3;
                }
                p += padding;
            }
            image.UnlockBits(bitmapData);

        }

        /// <summary>
        /// Display histogram of this image to control char. 
        /// </summary>
        /// <param name="image">Image will be display</param>
        /// <returns>Control type Char</returns>
        unsafe
        public static void DisplayHistogarm(this Bitmap image, Chart chr)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            int[] hist = Histogram.InitHisArr();

            hist = Histogram.CalHistogram(image, bitmapData, hist);

            //fill to control chart in form.
            if (chr.Series.Count == 0)
            {
                chr.Series.Add("Grey level");
            }
            else
            {
                for (int i = 0; i < 256; i++)
                {
                    chr.Series[0].Points.AddXY(string.Empty, hist[i]);
                }
            }

            image.UnlockBits(bitmapData);
        }

        /// <summary>
        /// Equal the histogram
        /// </summary>
        /// <param name="image"></param>
        unsafe
        public static void Equalization(this Bitmap image)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            #region values
            int rows = bitmapData.Width;
            int cols = bitmapData.Height;
            int area = rows * cols;
            int dm = 256;
            int k;
            int[] hist;
            int[] sum_of_hist = new int[256];
            int sum = 0;
            int padding = bitmapData.Stride - image.Width * 3;
            #endregion

            hist = Histogram.InitHisArr();

            hist = Histogram.CalHistogram(image, bitmapData, hist);

            for (int i = 0; i < dm; i++)
            {
                sum += hist[i];
                sum_of_hist[i] = sum;
            }

            byte *p = (byte*)bitmapData.Scan0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    k = p[0];
                    double temp = ((dm * 1.0 / area) * sum_of_hist[k]) - 1.0;
                    p[0] = (byte)temp;
                    p[1] = (byte)temp;
                    p[2] = (byte)temp;
                    p += 3;
                }
                p += padding;
            }

            image.UnlockBits(bitmapData);
        }
    }
}
