using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TitkovAA.Sprint4.Task3.Lib
{
    public class DataService:ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            int t = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                t += array[i, 2];
            }
            return t;
        }
    }
}
