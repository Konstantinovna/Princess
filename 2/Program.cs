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
            string input = Console.ReadLine();
            string[] splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string tmp;
            for (int i = 0; i < splited.Length; i++)
            {
                tmp = splited[i];
                if (!char.IsDigit(Convert.ToChar(tmp.Substring(0, 1))))
                {
                    splited[i] = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1, tmp.Length - 1);
                }
            }
            string result = "";
            foreach (string s in splited)
            {
                result += s + " ";
            }
            Console.Write(result);
        }
    }
}