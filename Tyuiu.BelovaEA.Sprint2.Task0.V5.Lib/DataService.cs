using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelovaEA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            // x = 105, y = 223
            res[0] = x == y; // False
            res[1] = x != y; // True 
            res[2] = x < y; // True
            res[3] = y > x; // True
            res[4] = y <= x; // False
            res[5] = y >= x; // True

            return res;
        }
    }
}
