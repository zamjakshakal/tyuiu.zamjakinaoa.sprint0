﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task5.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task5.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
