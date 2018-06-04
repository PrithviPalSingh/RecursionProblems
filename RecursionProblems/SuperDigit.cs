using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    class SuperDigit
    {
        //Without recursion
        public void FindSuperDigit(string x, int n)
        {

            long newdig = 0;
            for (int i = 0; i < x.Length; i++)
            {
                newdig += long.Parse(x[i].ToString());
            }

            newdig = n * newdig;
            StringBuilder s = new StringBuilder(newdig.ToString());
            var length = s.Length;

            while (s.Length != 1)
            {
                long newdig1 = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    newdig1 += long.Parse(s[i].ToString());
                }

                s.Clear();
                s.Append(newdig1);
            }

            Console.WriteLine(s);
        }

        //With recursion
        public void FindSuperDigitWR(string x, int n)
        {

            long newdig = 0;
            for (int i = 0; i < x.Length; i++)
            {
                newdig += long.Parse(x[i].ToString());
            }

            newdig = n * newdig;
            Console.WriteLine(FormNextString(newdig.ToString()));
        }


        private string FormNextString(string s)
        {
            if (s.Length == 1)
                return s;

            long newdig = 0;
            for (int i = 0; i < s.Length; i++)
            {
                newdig += long.Parse(s[i].ToString());
            }

            return FormNextString(newdig.ToString());
        }
    }
}