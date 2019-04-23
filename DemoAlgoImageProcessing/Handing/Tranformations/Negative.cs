using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace DemoAlgoImageProcessing.Handing.Tranformations
{
    /// <summary>
    /// Algo Negative
    /// </summary>
    public static class Negative
    {
        /// <summary>
        /// Get result after handing by Negative.
        /// </summary>
        /// <param name="bm">Image type Bitmap will be handing.</param>
        /// <returns></returns>
        unsafe
        public static Bitmap GetResult(Bitmap bm)
        {
            Bitmap image = (Bitmap)bm.Clone();

            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);

            image = CalByPixel(image, bitmapData);

            image.UnlockBits(bitmapData);

            return image;
        }

        /// <summary>
        /// Cal step by step with all of pixel
        /// </summary>
        /// <param name="bm"></param>
        /// <param name="bm_dt"></param>
        /// <returns></returns>
        unsafe
        private static Bitmap CalByPixel(Bitmap bm, BitmapData bm_dt)
        {
            double newValue, oldValue;
            int padding = bm_dt.Stride - bm.Width * 3;
            byte* p = (byte*)bm_dt.Scan0;
            for (int i = 0; i < bm.Height; i++)
            {
                for (int j = 0; j < bm.Width; j++)
                {
                    oldValue = p[0] / 255.0;
                    newValue = (1.0 - oldValue) * 255;
                    p[0] = (byte)newValue;
                    p[1] = (byte)newValue;
                    p[2] = (byte)newValue;
                    p += 3;
                }
                p += padding;
            }
            return bm;
        }
    }
}
