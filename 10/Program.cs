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
            AddZero addZero = new AddZero();
            List<double> array = new List<double>();
            StreamReader read = new StreamReader("F:\\ПТИПО\\10\\input.txt");

            string line;

            while ((line = read.ReadLine()) != null)
            {
                array.Add(Convert.ToDouble(line));
            }

            array = addZero.addZero(array);

            StreamWriter write = new StreamWriter("F:\\ПТИПО\\10\\output.txt");

            for (int i = 0; i < array.Count; i++)
            {
                write.Write(array[i] + " ");
            }

            write.Close();

            Console.Read();
        }
    }
}