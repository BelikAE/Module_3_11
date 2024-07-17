using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффицент k");
            float k = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b");
            float b = (float)Convert.ToDouble(Console.ReadLine());
            Uravnenie uravnenie = new Uravnenie(k, b);
            Console.WriteLine(uravnenie.Root());
            Console.ReadKey();
        }
    }
}
