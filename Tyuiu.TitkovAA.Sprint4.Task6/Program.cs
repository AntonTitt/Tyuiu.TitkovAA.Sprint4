using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint4.Task6.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task6
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Чикаго\",\"Хьюстон\",\"Феникс\",         *");
            Console.WriteLine("* \"Филадельфия\",\"Сан-Антонио\",\"Сан-Диего\",\"Даллас\"] используя     *");
            Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых меньше 7    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* [\"Чикаго\",\"Хьюстон\",\"Феникс\",\"Филадельфия\",\"Сан-Антонио\",     *");
            Console.WriteLine("* \"Сан-Диего\",\"Даллас\"]                                               *");
            DataService dt = new DataService();
            Random rnd = new Random();

            string[] a = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dt.Calculate(a));
        }
    }
}
