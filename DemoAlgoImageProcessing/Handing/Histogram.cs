
using System.Drawing;
using System.Drawing.Imaging;

namespace DemoAlgoImageProcessing.Handing
{
    public static class Histogram
    {
        /// <summary>
        /// Init array container index of histogram.
        /// </summary>
        /// <returns>array int[] length = 256 grey level.</returns>
        public static int[] InitHisArr()
        {
            int[] hist = new int[256];
            for (int i = 0; i < 256; i++)
            {
                hist[i] = 0;
            }
            return hist;
        }

        /// <summary>
        /// Calculator gray level.
        /// </summary>
        /// <param name="image"> Image type Bitmap.</param>
        /// <param name="bm_dt">BitmapData</param>
        /// <param name="hist">Hist array container result.</param>
        /// <returns>Histogram result.</returns>
        unsafe
        public static int[] CalHistogram(Bitmap image, BitmapData bm_dt, int[] hist)
        {
            int padding = bm_dt.Stride - image.Width * 3;
            byte* p = (byte*)bm_dt.Scan0;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    hist[p[0]]++;
                    p += 3;
                }
                p += padding;
            }
            return hist;
        }
    }
}
