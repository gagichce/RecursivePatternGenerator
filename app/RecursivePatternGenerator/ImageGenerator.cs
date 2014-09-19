using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RecursivePatternGenerator
{
    static class ImageGenerator
    {
        public static Image GenerateImage(RecursivePattern thePattern, int pixelDensity)
        {
            int x = thePattern.xSize;
            int y = thePattern.ySize;
            Image myCanvas = new Bitmap(x * pixelDensity * 3, y * pixelDensity * 3);


            Graphics e = Graphics.FromImage(myCanvas);
            e.Clear(Color.White);


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (thePattern.pattern[i, j])
                    {
                        myCanvas = SetPixel(i, j, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i + x, j + y, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i + 2 * x, j + 2 * y, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i, j + 2 * y, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i + 2 * x, j, pixelDensity, myCanvas);

                    }
                    else
                    {
                        myCanvas = SetPixel(i + x, j, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i + 2 * x, j + y, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i + x, j + 2 * y, pixelDensity, myCanvas);
                        myCanvas = SetPixel(i, j + y, pixelDensity, myCanvas);
                    }
                }
            }

            return myCanvas;
        }

        public static Image SetPixel(int x, int y, int pixelDensity, Image e)
        {
            for (int i = x * pixelDensity; i < (x + 1) * pixelDensity; i++)
            {
                for (int j = y * pixelDensity; j < (y + 1) * pixelDensity; j++)
                {
                    ((Bitmap)e).SetPixel(i, j, Color.Black);
                }
            }

            return e;
        }
    }
}