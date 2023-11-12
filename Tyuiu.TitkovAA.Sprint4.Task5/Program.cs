using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint4.Task5.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task5
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
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от -4 до 7. Заменить четные элементы*");
            Console.WriteLine("* массива на 1.                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* массив: 4, 5, 5, 6, 4,                                                  *");
            Console.WriteLine("*         7, 8, 4, 7, 5,                                                  *");
            Console.WriteLine("*         5, 6, 5, 8, 5,                                                  *");
            Console.WriteLine("*         7, 5, 8, 7, 8,                                                  *");
            Console.WriteLine("*         4, 7, 7, 8, 8,                                                  *");
            DataService dt = new DataService();

            int[,] a = { {4, 5, 5, 6, 4 },
                        { 7, 8, 4, 7, 5 },
                        { 5, 6, 5, 8, 5 },
                        { 7, 5, 8, 7, 8 },
                        { 4, 7, 7, 8, 8 } };


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

        }
    }
}
