using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SorokinAD.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a > b | c == d; //False
            res[1] = a < b & c < d; //True
            res[2] = a == b || c != d; //True
            res[3] = a < b  && c < d; //True
            res[4] = !(res[0]); //True
            res[5] = a <= b ^ c != d; //False
            return res;
            //            int a = 185;
            //            int b = 216;
            //            int c = 174;
            //            int d = 917;
        }
    }
}
