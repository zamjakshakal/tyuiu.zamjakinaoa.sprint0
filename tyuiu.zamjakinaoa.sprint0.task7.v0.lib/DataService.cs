using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using tyuiu.zamjakinaoa.sprint0.task7.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task7.v0.lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
