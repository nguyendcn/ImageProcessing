using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.Tranformations
{
    public static class Logarithmic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="c"></param>
        unsafe
        public static void Getresult(Bitmap image, double c)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            double s, r;
            int padding = bitmapData.Stride - image.Width * 3;
            byte* p = (byte*)bitmapData.Scan0;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    // s = c * log(1 + r)   r: [0, 1]
                    //p[0] = p[0] > 255 ? (byte)255 : p[0];
                    r = p[0] / 255.0;
                    s = Math.Log10(1 + r) * c * 255;
                    //int temp = (int)s;

                    s = s > 255 ? 255 : s;

                    p[0] = (byte)s;
                    p[1] = (byte)s;
                    p[2] = (byte)s;
                    p += 3;
                }
                p += padding;
            }
            image.UnlockBits(bitmapData);
        }
    }
}
