﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint4.Task3.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #4 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 7. Найдите сумму элементов  *");
            Console.WriteLine("* в третьем столбце массива.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* массив: 4, 7, 4, 2, 1,                                                  *");
            Console.WriteLine("*         6, 7, 3, 6, 5,                                                  *");
            Console.WriteLine("*         6, 5, 3, 3, 5,                                                  *");
            Console.WriteLine("*         4, 4, 6, 4, 7,                                                  *");
            Console.WriteLine("*         2, 1, 2, 3, 4,                                                  *");
            DataService dt = new DataService();

            int[,] a = { {4, 7, 4, 2, 1 },
                        { 6, 7, 3, 6, 5 },
                        { 6, 5, 3, 3, 5 },
                        { 4, 4, 6, 4, 7 },
                        { 2, 1, 2, 3, 4 } };


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(dt.Calculate(a));

        }
    }
}
