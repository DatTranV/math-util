using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils
{
    public class MathLib
    {
        public int Add(int x, int y) 
            { return x + y; }

        public int Subtract(int x, int y) => x - y;

        public  int Largest(int[] list)
        {
            int index, max = Int32.MinValue;
            for (index = 0; index < list.Length; index++)
            {
                if (list[index] > max)
                {
                    max = list[index];
                }
            }
            return max;
        }
    }
}
