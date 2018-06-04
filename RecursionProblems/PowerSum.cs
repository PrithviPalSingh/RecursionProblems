using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    class PowerSum
    {
        public void FindPowerSum(int x, int p)
        {
            Console.WriteLine(FindPowerSum(x, p, 1));
        }

        private int FindPowerSum(int x, int p, int num)
        {
            if ((int)Math.Pow(num, p) < x)
            {
                return FindPowerSum(x, p, num + 1) + FindPowerSum(x - (int)Math.Pow(num, p), p, num + 1);
            }
            else if ((int)Math.Pow(num, p) == x)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        int Root(int X, int n)
        {
            double div = (double)1 / n;
            return (int)Math.Pow(X, div);
        }

        bool IsPerfectrRoot(int X, int n)
        {
            double i = Math.Pow(X, 1 / n);
            if (i == 0)
            {
                return true;
            }

            return false;
        }
    }
}
