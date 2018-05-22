using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Permutation
    {
        public int[] Change(int[] array)
        {
            int temp = array[2];
            array[2] = array[4];
            array[4] = temp;

            return array;
        }
    }
}
