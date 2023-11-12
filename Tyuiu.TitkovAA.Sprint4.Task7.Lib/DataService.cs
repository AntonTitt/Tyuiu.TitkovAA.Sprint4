using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TitkovAA.Sprint4.Task7.Lib
{
    public class DataService : ISprint4Task7V0
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mat = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (mat[i, j] % 2 != 0)
                    {
                        t += mat[i, j];
                    }
                }
            }

            

            return t;
        }
    }
}
