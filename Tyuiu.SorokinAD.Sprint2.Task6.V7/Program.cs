using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint2.Task6.V7.Lib;

namespace Tyuiu.SorokinAD.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n;
            Console.Title = "Спринт #2| Выполнил: Сорокин А. Д. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество пройденные месяцев");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");

            if (n < 0)
            {
                Console.WriteLine("Введите число больше или равно 0");
            }
            else
            {
                Console.WriteLine($"Спустя {n} месяцев и 2 дня с начала 1990 года настал {ds.FindMonthName(startYear, n)}");
            }

            Console.ReadKey();

        }
    }
}
