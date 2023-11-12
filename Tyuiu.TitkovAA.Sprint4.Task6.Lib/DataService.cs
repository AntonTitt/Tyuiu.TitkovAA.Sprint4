using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TitkovAA.Sprint4.Task6.Lib
{
    public class DataService:ISprint4Task6V0//других нет
    {
        public int Calculate(string[] array)
        {
            

            return (Array.FindAll(array,x=>x.Length<7)).Length;
        }
    }
}
