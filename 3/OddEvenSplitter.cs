using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class OddEvenSplitter
    {
        public List<int> ExtractOdd(int[] array)
        {
            List<int> result = new List<int>();
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] % 2 != 0)
                {
                    result.Add(array[n]);
                }
            }

            return result;
        }

        public List<int> ExtractEven(int[] array)
        {
            List<int> result = new List<int>();
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] % 2 == 0 && array[n] != 0)
                {
                    result.Add(array[n]);
                }
            }

            return result;
        }

    }
}
