using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            SeparatingDigits stringNumbers = new SeparatingDigits();
            Console.WriteLine("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());
            string result = stringNumbers.separation(number);
            Console.WriteLine($"Сумма первых 3 десятичных цифр {result} сумме 3 последних десятичных цифр");
            Console.Read();
        }
    }
}
