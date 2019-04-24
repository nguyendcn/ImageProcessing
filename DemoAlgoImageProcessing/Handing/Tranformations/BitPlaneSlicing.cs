using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.Tranformations
{
    public static class BitPlaneSlicing
    {
        unsafe
        public static void GetResult(Bitmap image, int bitPlane)
        {
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                        ImageLockMode.ReadWrite,
                                                        PixelFormat.Format24bppRgb);
            int padding = bitmapData.Stride - image.Width * 3;
            byte* p = (byte*)bitmapData.Scan0;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    int newValue;
                    double bitValue = Math.Pow(2.0, (double)bitPlane);
                    newValue = ((p[0] & (int)bitValue) == bitValue) ? 255 : 0;
                    p[0] = (byte)newValue;
                    p[1] = (byte)newValue;
                    p[2] = (byte)newValue;
                    p += 3;
                }
                p += padding;
            }
            image.UnlockBits(bitmapData);
        }

        public static List<string> EnterInput()
        {
            UI.Tranformations.FormInput.InputForBitPlane inputForBitPlane = new UI.Tranformations.FormInput.InputForBitPlane();
            inputForBitPlane.ShowDialog();

            if (inputForBitPlane.isCancel)
            {
                return new List<string>();
            }
            else
            {
                return new List<string> { inputForBitPlane.lvl_1, inputForBitPlane.lvl_2, inputForBitPlane.lvl_3 };
            }
        }
    }
}
