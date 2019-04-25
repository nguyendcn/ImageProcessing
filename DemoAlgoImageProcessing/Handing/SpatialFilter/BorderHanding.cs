using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.SpatialFilter
{
    public static class BorderHanding
    {
        /// <summary>
        /// Handing border by wrap by color.
        /// </summary>
        /// <param name="image">Image need wrap.</param>
        /// <param name="numPad">Quantity pixel need wrap.</param>
        /// <param name="color">Color of pixel.</param>
        /// <returns></returns>
        unsafe
        public static Bitmap WrapAroundBorder(Bitmap image, int numPad, Color color)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);

            int padding = bitmapData.Stride - bitmapData.Width * 3;
            byte* top = (byte*)bitmapData.Scan0;
            byte* bottom = (byte*)bitmapData.Scan0 + bitmapData.Stride * (bitmapData.Height - 1);

            for (int j = 0; j < numPad; j++)
            {
                for (int i = 0; i < bitmapData.Width * 3; i++)
                {
                    top[i] = color.R;
                    bottom[i] = color.R;
                }
                top += bitmapData.Stride;
                bottom -= bitmapData.Stride;
            }

            for (int j = 0; j < numPad; j++)
            {
                top = (byte*)bitmapData.Scan0 + 3 * j;
                bottom = (byte*)bitmapData.Scan0 + (bitmapData.Width - 1) * 3 - 3 * j;
                for (int i = 0; i < bitmapData.Height; i++)
                {
                    top[0] = color.R;
                    top[1] = color.R;
                    top[2] = color.R;
                    bottom[0] = color.R;
                    bottom[1] = color.R;
                    bottom[2] = color.R;
                    top += bitmapData.Stride;
                    bottom += bitmapData.Stride;
                }
            }

            image.UnlockBits(bitmapData);
            return image;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="numPad"></param>
        /// <returns></returns>
        unsafe
        public static Bitmap ReplicateBorder(Bitmap image, int numPad)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);

            int padding = bitmapData.Stride - bitmapData.Width * 3;
            byte* top = (byte*)bitmapData.Scan0 + (3 * numPad) + ((numPad - 1) * bitmapData.Stride);
            byte* bottom = (byte*)bitmapData.Scan0 + (bitmapData.Stride * (bitmapData.Height - numPad - 1)) + (3 * numPad);

            for (int j = numPad - 1; j >= 0; j--)
            {
                for (int i = 0; i < (bitmapData.Width - numPad * 2) * 3; i++)
                {
                    top[i] = top[i + bitmapData.Stride];
                    bottom[i + bitmapData.Stride] = bottom[i];
                }
                top -= bitmapData.Stride;
                bottom += bitmapData.Stride;
            }

            for (int i = 0; i < bitmapData.Height; i++)
            {
                top = (byte*)bitmapData.Scan0 + i * bitmapData.Stride;
                bottom = (byte*)bitmapData.Scan0 + ((bitmapData.Width - numPad) * 3) - 3 + i * bitmapData.Stride;
                for (int j = 0; j < numPad * 3; j++)
                {
                    top[j] = top[3 * numPad];

                    bottom[j + 3] = bottom[0];
                }
            }

            image.UnlockBits(bitmapData);
            return image;
        }
    }
}
