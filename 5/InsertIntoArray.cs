using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class InsertIntoArray
    {
        public int[] Divider(int[] array)
        {
            int sum = Math.Abs(array[0]) + Math.Abs(array[1]) + Math.Abs(array[array.Length - 1]);
            Console.WriteLine($"Сумма первого, второго и последнего элементов: {sum}");

            string[] inString = Console.ReadLine().Split();
            string outString = " ";


            //проверка типа данных
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (!int.TryParse(inString[i], out array[i]))
                {
                    Console.ReadKey();
                }
            }

            for (int i = 0; i <= array.Length - 1; i++)
            {
                outString = outString + inString[i] + " ";
                if (sum % array[i] == 0)
                {
                    outString = outString + "0 ";
                }
            }

            return array;
        }
    }
}

