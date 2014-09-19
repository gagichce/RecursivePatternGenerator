using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursivePatternGenerator
{
    class RecursivePattern
    {
        public bool[,] pattern;
        public int xSize;
        public int ySize;

        public RecursivePattern(int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            //init the array
            this.pattern = new bool[xSize, ySize];
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    this.pattern[i, j] = true;
                }
            }
        }

        public void TogglePosition(int x, int y)
        {
            pattern[x, y] ^= true;
            if (x != y)
                pattern[y, x] ^= true;
        }

        public bool[,] GetOutputArray()
        {
            return new bool[0, 0];
        }
    }
}
