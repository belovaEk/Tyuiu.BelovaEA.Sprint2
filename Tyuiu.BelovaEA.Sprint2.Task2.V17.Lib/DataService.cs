using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelovaEA.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x > 2 && x < 6 && y > 2 && y < 8) || (x > 5 && x < 9 && y > 4 && y < 8) ||
                (x > 8 && x < 11 && y > 2 && y < 8) || (x > 10 && x < 13 && y > 2 && y < 6) || (x == 13 && y == 4) ||
                (x > 5 && x < 8 && y > 7 && y < 12) || (x > 2 && x < 6 && y == 11) || (x == 10 && y > 7 && y < 13) ||
                (x > 10 && x < 13 && y > 9 && y < 12) || (x == 10 && y == 12))
            {
                return true;
            }

            else
            {
                return false;

            }
            if (2<4)
            {

            }
        }

        
    }
}
