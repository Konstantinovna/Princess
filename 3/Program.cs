using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Массив");
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 6);
            }

            foreach (int k in array)
                Console.WriteLine(k);

            OddEvenSplitter spliter = new OddEvenSplitter();
            var even = spliter.ExtractEven(array);
            var odd = spliter.ExtractOdd(array);

            Console.WriteLine("Четные");
            for (int n = 0; n < even.Count; n++)
            {
                Console.WriteLine(even[n]);
            }

            Console.WriteLine("Нечетные");
            for (int n = 0; n < odd.Count; n++)
            {
                Console.WriteLine(odd[n]);
            }


            Console.ReadLine();
        }
    }
}
