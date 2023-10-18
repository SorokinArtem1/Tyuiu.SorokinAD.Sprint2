using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SorokinAD.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int month = (n % 12);
            
            switch (month)
            {
                case 0: return "Январь " + startYear + " года";
                case 1: return "Февраль " + startYear + " года";
                case 2: return "Март " + startYear + " года";
                case 3: return "Апрель " + startYear + " года";
                case 4: return "Май " + startYear + " года";
                case 5: return "Июнь " + startYear + " года";
                case 6: return "Июль " + startYear + " года";
                case 7: return "Август " + startYear + " года";
                case 8: return "Сентябрь " + startYear + " года";
                case 9: return "Октябрь " + startYear + " года";
                case 10: return "Ноябрь " + startYear + " года";
                case 11: return "Декабрь " + startYear + " года";

                default: throw new ArgumentException("Введите n равное количеству пройденных месяцев, Ваше значение " + n);
            }
            
            
            
        }
    }
}
