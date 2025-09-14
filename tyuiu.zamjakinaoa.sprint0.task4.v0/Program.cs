using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task4.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task4.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(15, 5));
            Console.WriteLine(DataService.Multiplication(10, 10));
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
