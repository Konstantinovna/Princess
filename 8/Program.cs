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
                    private static Random rnd = new Random();

        static void Main(string[] args)
        {


            Console.WriteLine("\nИсходный массив: ");
            AddColumn spliter = new AddColumn();


            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-9, 9);
                }
                Console.WriteLine();
            }
            spliter.print(array);

            var result = spliter.Array(array);


            int min = array[0, 0];
            int column = 0;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        column = j;
                    }
                }

            Console.WriteLine($"\nМинимальное отрицательное: {min} в столбце {column + 1}");
            Console.WriteLine("\nИзмененный массив: ");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == column) continue;
                    Console.Write(array[i, j]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}