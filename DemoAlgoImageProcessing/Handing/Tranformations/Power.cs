using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.Tranformations
{
    public static class Power
    {
        unsafe
        public static void PowerLaw(Bitmap image, double lamda, int c)
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
                    // s = c * r^lamda   r: [0, 1]
                    r = p[0] / 255.0;
                    s = c * Math.Pow(r, lamda) * 255.0;
                    p[0] = (byte)s;
                    p[1] = (byte)s;
                    p[2] = (byte)s;
                    p += 3;
                }
                p += padding;
            }
            image.UnlockBits(bitmapData);
        }

        public static List<string> EnterInput()
        {
            UI.Tranformations.FormInput.InputForPower inputForPower = new UI.Tranformations.FormInput.InputForPower();
            inputForPower.ShowDialog();
            
            if(inputForPower.isCancel)
            {
                return new List<string>();
            }
            else
            {
                return new List<string> { inputForPower.image_1, inputForPower.image_2, inputForPower.image_3};
            }
        }
    }
}
