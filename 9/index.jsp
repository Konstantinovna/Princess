using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Sort
    {

        private List<int> oneDimensionalArray = new List<int>();

        public int[,] SortingArray(int[,] array)
        {
            Regularize(array);
            int m = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = oneDimensionalArray[m];
                    m++;
                }
            }
            return array;
        }

        private List<int> Regularize(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    oneDimensionalArray.Add(array[i, j]);
                }
            }
            oneDimensionalArray.Sort();
            return oneDimensionalArray;
        }
    }
}
