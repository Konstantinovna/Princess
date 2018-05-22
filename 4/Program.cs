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
            Console.WriteLine("Введите количество элементов");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Исходный массив");
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 6);
            }

            foreach (int k in array)
                Console.Write(k);

            Permutation spliter = new Permutation();
            var result = spliter.Change(array);

            Console.WriteLine("\nИзмененный массив");

            for (int m = 0; m < result.Length; m++)
            {
                Console.Write(result[m]);
            }


            Console.ReadLine();
        }
    }
}