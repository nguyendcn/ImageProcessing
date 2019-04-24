
using System.Collections.Generic;
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

        unsafe
        private static int CountNotEqua0(Bitmap image)
        {
            int count = 0;
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            int[] hist = new int[256];

            int padding = bitmapData.Stride - image.Width * 3;
            byte* p = (byte*)bitmapData.Scan0;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    hist[p[0]]++;
                    p += 3;
                }
                p += padding;
            }

            for (int i = 0; i < 256; i++)
                count = hist[i] != 0 ? (count + 1) : count;

            image.UnlockBits(bitmapData);
            return count;
        }

        /// <summary>
        /// Get image best from list image by used histogram.
        /// </summary>
        /// <param name="list">List image.</param>
        /// <returns>Index of image best from list image.</returns>
        public static int GetBestImageUseHistogram(List<Bitmap> list)
        {
            int max = int.MinValue;
            int pos = -1;
            for (int i = 0; i < list.Count; i++)
            {
                Bitmap temp = (Bitmap)list[i].Clone();
                int count = CountNotEqua0(temp);
                if (max < count)
                {
                    max = count;
                    pos = i;
                }
            }
            return pos;
        }
    }
}
