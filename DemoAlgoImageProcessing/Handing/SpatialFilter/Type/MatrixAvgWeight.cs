using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoImageProcessing.Handing.SpatialFilter.Type
{
    public static class MatrixAvgWeight
    {
        public static int[,] GaussianBlurMatrix_3x3 = {
                                        { 1, 2, 1 },
                                        { 2, 4, 2 },
                                        { 1, 2, 1 }
                                     };
        public static int numDiv_3x3 = 16;
    }
}
