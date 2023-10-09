using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Мастям игральных    *");
            Console.WriteLine("* карт условно присвоены следующие порядковые номера: масти «пики» — 1,   *");
            Console.WriteLine("* масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4. По заданному   *");
            Console.WriteLine("* номеру масти m (1 <= m <= 4) определить название соответствующей масти.                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти:");
            int m = int.Parse(Console.ReadLine());


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Номер масти = {m}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (m > 0 && m < 5)
            {
                Console.WriteLine($"Эта масть - {ds.FindCardSuit(m)}");
            }
            else
            {
                Console.WriteLine("Неверный диапазон");
            }

            Console.ReadKey();
        }
    }
}
