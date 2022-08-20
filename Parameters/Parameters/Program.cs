using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Q3 q=new Q3();
               q.sum(2, 3);   */

            /*Q2 q2 = new Q2();
              Console.WriteLine("Enter a sentence: ");
              string res=Console.ReadLine();
              q2.sol2(res);  */
            
            double n, m;
            Console.WriteLine("Enter total amount: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter monthly payment: ");
            m = Convert.ToDouble(Console.ReadLine());

            Q1 q1 = new Q1();
            q1.sol1(n, m);


        }
    }
}
