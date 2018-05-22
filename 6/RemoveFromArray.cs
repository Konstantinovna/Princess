using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class RemoveFromArray
    {
        public List<double> DeleteElement(List<double> array)
        {
            double average = ArithmeticMean(array);

            for (int i = array.Count - 1; i >= 0; i--)
            {
                if (array[i] > average)
                {
                    array.Remove(array[i]);
                }
            }

            return array;
        }
    }
}
