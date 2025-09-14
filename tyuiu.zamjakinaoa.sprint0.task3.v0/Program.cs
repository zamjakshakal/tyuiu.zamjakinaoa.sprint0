using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task3.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task3.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(7, 7));
            Console.ReadKey();
        }
    }
}
