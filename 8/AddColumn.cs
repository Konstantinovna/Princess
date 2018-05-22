using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class AddColumn
    {
        public int[,] Array(int[,] array, int min, int column, int m, int n)
        {

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        column = j;
                    }
                    return array;
                }
        }

        public int[,] print(int[,] array, int column, int m, int n)
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == column) continue;
                    Console.Write(array[i, j]);
                    Console.Write('\t');
                }
                Console.WriteLine();
                return array;
            }
        }
    }
}
