﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task6.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task6.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstructionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
