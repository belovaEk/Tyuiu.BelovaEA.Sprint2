using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelovaEA.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // при a = 324, b = 696, c = 254, d = 155
            //  |, &, ||, &&, !, ^
            bool[] res = new bool[6];

            res[0] = (a < b) | (b == c); // True
            res[1] = (a < b) & (d <= a); // True
            res[2] = (b > a) || (b == c); // True
            res[3] = (a < b) && (b == c); // False
            res[4] = !(b != c); // False
            res[5] = (a < b) ^ (b != c); //False

            return res;
        }
    }
}
