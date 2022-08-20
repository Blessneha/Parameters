using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Q1
    {

        public void  sol1(double n,double m)
        {
            int month = 1;
            double balance = n;
            double tot = m;

            while(balance>0)
            {
                Console.WriteLine($"Month: {month} balance:{balance}                 total payments:{tot}");
                month++;
                tot += m;
                balance = (balance + (balance * (1.5 / 100))) - m;


            }

        }
    }
}
