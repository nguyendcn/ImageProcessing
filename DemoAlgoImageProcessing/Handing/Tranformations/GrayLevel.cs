using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.Tranformations
{
    public static class GrayLevel
    {
        unsafe
        public static void GrayLevelSlicing(Bitmap image, int startPoint, int endPoint)
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
                    if (p[0] >= startPoint && p[0] <= endPoint)
                        newValue = 255;
                    else
                        newValue = p[0];
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
            UI.Tranformations.FormInput.InputForGrayLevel inputForGrayLevel = new UI.Tranformations.FormInput.InputForGrayLevel();
            inputForGrayLevel.ShowDialog();

            if(inputForGrayLevel.isCancel)
            {
                return new List<string>();
            }
            else
            {
                return new List<string> {inputForGrayLevel.img_1, inputForGrayLevel.img_2, inputForGrayLevel.img_3 };
            }
        }
    }
}
