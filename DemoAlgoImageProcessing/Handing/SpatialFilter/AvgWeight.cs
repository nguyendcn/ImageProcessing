using DemoAlgoImageProcessing.Handing.SpatialFilter.Type;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.SpatialFilter
{
    public static class AvgWeight
    {
        /// <summary>
        /// Get matrix value pixel around pixel have coordi (x, y).
        /// </summary>
        /// <param name="bitmapData">Bitmap of image need find.</param>
        /// <param name="x">Coor x of pixel.</param>
        /// <param name="y">>Coor y of pixel.</param>
        /// <param name="mtx">Matrix need find. _3x3 => 3</param>
        /// <returns>Matrix around pixel.</returns>
        unsafe
        private static int[,] GetMatrixAroundPixel(BitmapData bitmapData, int x, int y, Type.Matrix mtx)
        {

            int[,] matrix = new int[(int)mtx, (int)mtx];
            byte* p = (byte*)bitmapData.Scan0;
            int padding = ((int)mtx / 2);
            p = p + bitmapData.Stride * (y - padding) + 3 * (x - padding);

            for (int i = 0; i < (int)mtx; i++)
            {
                for (int j = 0; j < (int)mtx; j++)
                {
                    matrix[i, j] = p[0];
                    p += 3;
                }
                p -= (int)mtx * 3;
                p += bitmapData.Stride;
            }
            return matrix;
        }

        /// <summary>
        /// Average weight filter.
        /// </summary>
        /// <param name="srcImage">Image source.</param>
        /// <param name="desImage">Image des.</param>
        /// <param name="matrix">Matrix get.</param>
        /// <param name="pad">Padding border.</param>
        /// <returns>Result min filter image.</returns>
        unsafe
        private static Bitmap AvgWeightFilter(Bitmap srcImage, Bitmap desImage, Matrix matrix, int pad)
        {
            BitmapData srcBitmapData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, srcImage.Height),
                                                            ImageLockMode.ReadOnly,
                                                            PixelFormat.Format24bppRgb);

            BitmapData desBitmapData = desImage.LockBits(new Rectangle(0, 0, desImage.Width, desImage.Height),
                                                        ImageLockMode.WriteOnly,
                                                        PixelFormat.Format24bppRgb);

            int padding = srcBitmapData.Stride - srcBitmapData.Width * 3;
            byte* pSrc = (byte*)srcBitmapData.Scan0;
            byte* pDes = (byte*)desBitmapData.Scan0;

            // Di chuyển con trỏ tới (1, 1)
            pSrc = pSrc + (srcBitmapData.Stride + 3) * pad;
            pDes = pDes + (desBitmapData.Stride + 3) * pad;

            for (int i = pad; i < srcBitmapData.Height - pad; i++)
            {
                for (int j = pad; j < srcBitmapData.Width - pad; j++)
                {
                    int[,] matrix_temp = GetMatrixAroundPixel(srcBitmapData, j, i, matrix);
                    int newValue = GetAvgWeightInMatrix(matrix_temp, matrix);

                    pDes[0] = (byte)newValue;
                    pDes[1] = (byte)newValue;
                    pDes[2] = (byte)newValue;
                    pDes += 3;
                    pSrc += 3;
                }
                pDes += 3 * ((int)matrix - 1);
                pDes += padding;
                pSrc += 3 * ((int)matrix - 1);
                pSrc += padding;
            }

            srcImage.UnlockBits(srcBitmapData);
            desImage.UnlockBits(desBitmapData);

            return desImage;
        }

        /// <summary>
        /// Get result image by avg weight filter and fix border. 
        /// </summary>
        /// <param name="srcImage">Image source.</param>
        /// <param name="desImage">>Image destations</param>
        /// <param name="matrix">Matrix get.</param>
        /// <param name="borderType">Solution fix border.</param>
        /// <returns>Image after handing.</returns>
        unsafe
        public static Bitmap GetResult(Bitmap srcImage, Bitmap desImage, Matrix matrix, Replicate borderType)
        {
            int temp = (int)matrix / 2;

            if (borderType == Replicate.Replicate_Border)
            {
                desImage = BorderHanding.ReplicateBorder(srcImage, temp);

                return AvgWeightFilter(srcImage, (Bitmap)desImage.Clone(), matrix, temp);
            }
            else if (borderType == Replicate.Wrap_Color)
            {
                desImage = BorderHanding.WrapAroundBorder(srcImage, temp, Color.Black);

                return AvgWeightFilter(srcImage, (Bitmap)desImage.Clone(), matrix, temp);

            }
            return null;
        }

        /// <summary>
        /// Get value minimum in array matrix.
        /// </summary>
        /// <param name="matrix">Array matrix will be find min in this matrix.</param>
        /// <returns>Value minimum.</returns>
        public static int GetAvgWeightInMatrix(int[,] matrix, Matrix mtr)
        {
            double sum = 0;
            for (int i = 0; i < (int)mtr; i++)
                for (int j = 0; j < (int)mtr; j++)
                    sum += matrix[i, j] * MatrixAvgWeight.GaussianBlurMatrix_3x3[i, j];
            return (int)sum / MatrixAvgWeight.numDiv_3x3;
        }
    }
}
