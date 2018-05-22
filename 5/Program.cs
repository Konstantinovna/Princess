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
            Console.WriteLine("Введите массив: ");
            string[] inString = Console.ReadLine().Split();
            string outString = " ";
            int[] array = new int[inString.Length];


            InsertIntoArray spliter = new InsertIntoArray();
            var result = spliter.Divider(array);


            //проверка типа данных
            for (int i = 0; i <= result.Length - 1; i++)
            {
                if (!int.TryParse(inString[i], out array[i]))
                {
                    Console.ReadKey();
                }
            }


            for (int i = 0; i <= result.Length - 1; i++)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine($"Измененный массив: {outString.Trim()}");
            Console.ReadLine();
        }
    }
}