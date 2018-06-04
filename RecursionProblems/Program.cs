using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //PowerSum ps = new PowerSum();
            //ps.FindPowerSum(100, 3);

            SuperDigit sd = new SuperDigit();
            sd.FindSuperDigit("3546630947312051453014172159647935984478824945973141333062252613718025688716704470547449723886626736", 100000);
            sd.FindSuperDigitWR("3546630947312051453014172159647935984478824945973141333062252613718025688716704470547449723886626736", 100000);
            Console.Read();
        }
    }
}
