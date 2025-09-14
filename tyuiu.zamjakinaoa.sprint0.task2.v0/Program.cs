using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task2.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task2.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Олеся"));
            Console.ReadKey();
        }
    }
}
