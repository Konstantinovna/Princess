using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Test
    {
        static void Main(string[] args)
        {
            string str = "привет как твои дела";
            string[] array = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string item in array)
            {
                sb.Append(char.ToUpper(item[0]) + item.Substring(1, item.Length - 1) + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
