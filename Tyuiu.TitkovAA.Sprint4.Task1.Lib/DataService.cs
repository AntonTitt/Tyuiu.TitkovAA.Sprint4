﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TitkovAA.Sprint4.Task1.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int t = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    t *= array[i];
                }
            }


            return t;
        }
    }
}
