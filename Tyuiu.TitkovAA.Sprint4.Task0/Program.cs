using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint4.Task0.Lib;


namespace Tyuiu.TitkovAA.Sprint4.Task0
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}                                          *");
            DataService dt = new DataService();

            int[] a = new int[] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(dt.GetSumEvenArrEl(a));
        }
    }
}
