using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mtx = new Matrix();
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-9, 9);
                }
            }
            Console.WriteLine("Исходная матрица: ");
            mtx.print(matrix);

            matrix = mtx.replacement(matrix);

            Console.WriteLine("\nИзмененная матрица: ");
            mtx.print(matrix);
            Console.Read();
        }
    }
}